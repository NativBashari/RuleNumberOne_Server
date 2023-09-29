using Entities.FinalModels.Fundamentals;
using Entities.RawModels;
using Logic.Contracts;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Repository
{
    public class FundamentalsLogic : IFundamentalsLogic
    {

        async Task<IList<BalanceSheet_Final>> IFundamentalsLogic.GetBalanceSheetsAsync(BalanceSheet balanceSheet)
        {
            List<BalanceSheet_Final> balanceSheet_Finals = new List<BalanceSheet_Final>();
            int i = 0;
            foreach (var entry in balanceSheet.Yearly)
            {
                BalanceSheet_Final balanceSheet_final;
                if (i == 10)
                    break;
                string fillingDate = string.Empty;
                string totalAssets = string.Empty;
                string totalLiab = string.Empty;
                if (!entry.Value.TryGetValue("filing_date", out fillingDate!)) fillingDate = "0";
                if (!entry.Value.TryGetValue("totalAssets", out totalAssets!)) totalAssets = "0";
                if (!entry.Value.TryGetValue("totalLiab", out totalLiab!)) totalLiab = "0";
                balanceSheet_final = new BalanceSheet_Final()
                {
                    Year = DateTime.Parse(fillingDate).Year,
                    Debts = double.Parse(totalLiab),
                    Assets = double.Parse(totalAssets)
                };
                balanceSheet_Finals.Add(balanceSheet_final);
                i++;
            }
            GetAssetsGrowthRates(balanceSheet_Finals);
            return balanceSheet_Finals;

        }



        async Task<IList<CashFlow_Final>> IFundamentalsLogic.GetCashFlowsAsync(CashFlow cashFlow)
        {
            List<CashFlow_Final> cashFlow_Finals = new List<CashFlow_Final>();
            int i = 0;
            foreach (var entry in cashFlow.Yearly)
            {
                CashFlow_Final cashFlow_Final;
                string fillingDate = string.Empty;
                string totalCashFromOperatingActivities = string.Empty;
                if (!entry.Value.TryGetValue("filing_date", out fillingDate!)) fillingDate = "0";
                if (!entry.Value.TryGetValue("totalCashFromOperatingActivities", out totalCashFromOperatingActivities!)) totalCashFromOperatingActivities = "0";
                cashFlow_Final = new CashFlow_Final()
                {
                    Year = DateTime.Parse(fillingDate).Year,
                    Cash = double.Parse(totalCashFromOperatingActivities)
                };
                cashFlow_Finals.Add(cashFlow_Final);
                i++;
            }
            GetCashFlowGrowthRates(cashFlow_Finals);

            return cashFlow_Finals;

        }



        async Task<IList<ProfitLoss_Final>> IFundamentalsLogic.GetProfitLossAsync(IncomeStatement incomeStatement)
        {
            List<ProfitLoss_Final> profitLoss_Finals = new List<ProfitLoss_Final>();
            int i = 0;
            foreach (var entry in incomeStatement.Yearly)
            {
                ProfitLoss_Final profitLoss;
                if (i == 10)
                    break;
                string fillingDate = string.Empty;
                string netIncome = string.Empty;
                string totalRevenue = string.Empty;
                if (!entry.Value.TryGetValue("filing_date", out fillingDate!)) fillingDate = "0";
                if (!entry.Value.TryGetValue("netIncome", out netIncome!)) netIncome = "0";
                if (!entry.Value.TryGetValue("totalRevenue", out totalRevenue!)) totalRevenue = "0";

                profitLoss = new ProfitLoss_Final()
                {
                    Year = DateTime.Parse(fillingDate).Year,
                    Income = double.Parse(totalRevenue),
                    Profit = double.Parse(netIncome)
                };
                profitLoss_Finals.Add(profitLoss);
                i++;
            }
            GetIncomeGrowthRates(profitLoss_Finals);
            return profitLoss_Finals;
        }

        public async Task<IList<StockProfit_Final>> GetStockProfit(BalanceSheet balanceSheet, IncomeStatement incomeStatement)
        {
            List<StockProfit_Final> stockProfit_Finals = new List<StockProfit_Final>();
            for (int i = 0; i < balanceSheet.Yearly.Count || i < incomeStatement.Yearly.Count; i++)
            {
                if (i == 10)
                {
                    break;
                }
                StockProfit_Final stockProfit_Final;
                string commonStockSharesOutstandingS = string.Empty;
                string netIncomeS = string.Empty;
                string fillingDate = string.Empty;
                if (!balanceSheet.Yearly.ElementAt(i).Value.TryGetValue("commonStockSharesOutstanding", out commonStockSharesOutstandingS!)) commonStockSharesOutstandingS = "0";
                if (!incomeStatement.Yearly.ElementAt(i).Value.TryGetValue("netIncome", out netIncomeS!)) netIncomeS = "0";
                if (!incomeStatement.Yearly.ElementAt(i).Value.TryGetValue("filing_date", out fillingDate!)) balanceSheet.Yearly.ElementAt(i).Value.TryGetValue("filing_date", out fillingDate!);
                double commonStockSharesOutstanding = double.Parse(commonStockSharesOutstandingS);
                double netIncome = double.Parse(netIncomeS);
                double stockProfit = netIncome / commonStockSharesOutstanding;
                stockProfit_Final = new StockProfit_Final()
                {
                    Year = DateTime.Parse(fillingDate).Year,
                    Profit = Math.Round(stockProfit, 2)
                };
                stockProfit_Finals.Add(stockProfit_Final);
            }
            GetStockProfitGrowthRates(stockProfit_Finals);
            return stockProfit_Finals;
        }

        private void GetIncomeGrowthRates(List<ProfitLoss_Final> profitLoss_Finals)
        {
            double lastIncome = 0;
            profitLoss_Finals.Reverse();
            for (int i = 0; i < profitLoss_Finals.Count; i++)
            {
                if (lastIncome != 0)
                {
                    profitLoss_Finals[i].GrowthRates = GrowthRatesPrecentage(lastIncome, profitLoss_Finals[i].Income);
                }
                lastIncome = profitLoss_Finals[i].Income;

            }
        }
        private void GetAssetsGrowthRates(List<BalanceSheet_Final> balanceSheet_Finals)
        {
            double lastAssets = 0;
            balanceSheet_Finals.Reverse();
            for (int i = 0; i < balanceSheet_Finals.Count; i++)
            {
                if (lastAssets != 0)
                {
                    balanceSheet_Finals[i].GrowthRates = GrowthRatesPrecentage(lastAssets, balanceSheet_Finals[i].Assets - balanceSheet_Finals[i].Debts);
                }
                lastAssets = balanceSheet_Finals[i].Assets - balanceSheet_Finals[i].Debts;
            }
        }
        private void GetCashFlowGrowthRates(List<CashFlow_Final> cashFlow_Finals)
        {
            double lastCash = 0;
            cashFlow_Finals.Reverse();
            for (int i = 0; i < cashFlow_Finals.Count; i++)
            {
                if (lastCash != 0)
                {
                    cashFlow_Finals[i].GrowthRates = GrowthRatesPrecentage(lastCash, cashFlow_Finals[i].Cash);
                }
                lastCash = cashFlow_Finals[i].Cash;
            }
        }
        private void GetStockProfitGrowthRates(List<StockProfit_Final> stockProfit_Finals)
        {
            double lastStockProfit = 0;
            stockProfit_Finals.Reverse();
            for (int i = 0; i < stockProfit_Finals.Count; i++)
            {
                if (lastStockProfit != 0)
                {
                    stockProfit_Finals[i].GrowthRates = GrowthRatesPrecentage(lastStockProfit, stockProfit_Finals[i].Profit);
                }
                lastStockProfit = stockProfit_Finals[i].Profit;
            }

        }

        private double GrowthRatesPrecentage(double lastYear, double currentYear) => Math.Round(((currentYear - lastYear) * 100) / lastYear, 2);

        public Task GetRoic(IList<ProfitLoss_Final> profitLoss_Final, IList<BalanceSheet_Final> balanceSheet_Finals)
        {
            for (int i = 0; i < profitLoss_Final.Count || i < balanceSheet_Finals.Count; i++)
            {
                double netIncome = profitLoss_Final[i].Income;
                double equity = balanceSheet_Finals[i].Assets;
                double debts = balanceSheet_Finals[i].Debts;

                double roic = netIncome / (equity + debts);
                balanceSheet_Finals[i].Roic = Math.Round(roic, 2);
            }
            return Task.CompletedTask;
        }

        public async Task<RuleNumberOneNumbers> GetRuleNumberOneNumbers(IList<BalanceSheet_Final> balanceSheet, Highlights highlights, StockProfit_Final lastStockProfit_Final)
        {
            double currentStockProfit = lastStockProfit_Final.Profit;
            double EquityGrowthRatesSum = 0;
            for (int i = 1; i < balanceSheet.Count; i++)
            {
                EquityGrowthRatesSum += balanceSheet[i].GrowthRates;
            }
            double equityGrowthRatesAvg = EquityGrowthRatesSum / balanceSheet.Count -1;
            double futurePE = GetFuturePE(EquityGrowthRatesSum, highlights.PeRatio);
            int numberOfMultiplications = GetNumOfMul(EquityGrowthRatesSum);
            double futureStockProfit = GetEstimateFutureStockProfit(currentStockProfit, numberOfMultiplications);
            double futureStockPrice = GetEstimatedFutureStockPrice(futurePE, futureStockProfit);
            double stickerPrice = GetStickerPrice(futureStockPrice);
            double stockPriceAfterMOS = GetStockPriceAfterMOS(stickerPrice);
            RuleNumberOneNumbers ruleNumberOneNumbers = new RuleNumberOneNumbers()
            {
                CurrentStockProfit = currentStockProfit,
                EstimatedAssetsGrowthRates = EquityGrowthRatesSum,
                EstimatedPE = futurePE,
                PriceAfterMOS = stockPriceAfterMOS,
                StickerPrice = stickerPrice,
                futureStockPrice = futureStockPrice
            };
            return ruleNumberOneNumbers;
        }

        private double GetStockPriceAfterMOS(double stickerPrice) => stickerPrice / 2;

        private double GetStickerPrice(double futureStockPrice) => futureStockPrice / 4;

        private double GetEstimatedFutureStockPrice(double futurePE, double futureStockProfit) => futurePE * futureStockProfit;

        private double GetEstimateFutureStockProfit(double currentStockProfit, int numberOfMultiplications)
        {
            double futureStockPrice = currentStockProfit;
            for (int i = 0; i < numberOfMultiplications; i++)
            {
                futureStockPrice = futureStockPrice * 2;
            }
            return futureStockPrice;
        }

        private int GetNumOfMul(double equityGrowthRatesAvg) => (int)Math.Round(72 / equityGrowthRatesAvg);

        private double GetFuturePE(double equityGrowthRatesAvg, double epsEstimateCurrentYear) => Math.Min(equityGrowthRatesAvg * 2, epsEstimateCurrentYear);
    }
}
