using Entities.FinalModels.Fundamentals;
using EODHD_Client;
using Logic.Contracts;


namespace Logic.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IFundamentalsLogic _fundamentalsLogic;
        private IFinanceGetter _financeGetter;
        public UnitOfWork(IFundamentalsLogic fundamentalsLogic, string apiKey, string dataProviderEP)
        {
            _fundamentalsLogic = fundamentalsLogic;
            _financeGetter = new FinanceGetter(dataProviderEP, apiKey);
        }

        public async Task<FinancialData_Final> GetFinancialSummury(string stockMarkUp)
        {
            FinancialData_Final financialData_Final = new FinancialData_Final();
            try
            {
                var rawFinancialData = await _financeGetter.GetFinancialDataAsync(stockMarkUp);

                IList<ProfitLoss_Final> profitLoss_Final = await _fundamentalsLogic.GetProfitLossAsync(rawFinancialData.Financials.IncomeStatement);
                IList<BalanceSheet_Final> balanceSheet_Finals = await _fundamentalsLogic.GetBalanceSheetsAsync(rawFinancialData.Financials.BalanceSheet);
                await _fundamentalsLogic.GetRoic(profitLoss_Final, balanceSheet_Finals);
                IList<CashFlow_Final> cashFlow_Finals = await _fundamentalsLogic.GetCashFlowsAsync(rawFinancialData.Financials.CashFlow);
                IList<StockProfit_Final> stockProfit_Finals = await _fundamentalsLogic.GetStockProfit(rawFinancialData.Financials.BalanceSheet, rawFinancialData.Financials.IncomeStatement);
                financialData_Final = FinancialDataObjBuilder(profitLoss_Final, balanceSheet_Finals, cashFlow_Finals, stockProfit_Finals);
            }
            catch (Exception)
            {
            }
            return financialData_Final;
        }
        private FinancialData_Final FinancialDataObjBuilder(IList<ProfitLoss_Final> profitLoss_Final, IList<BalanceSheet_Final> balanceSheet_Finals, IList<CashFlow_Final> cashFlow_Finals, IList<StockProfit_Final> stockProfit_Finals)
        {
            return new FinancialData_Final()
            {
                BalanceSheet = balanceSheet_Finals,
                CashFlow = cashFlow_Finals,
                ProfitLoss = profitLoss_Final,
                stockProfit = stockProfit_Finals
            };
        }
    }
}
