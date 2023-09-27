using Entities.EOM;
using Entities.FinalModels.Fundamentals;
using Entities.FinalModels.Profile;
using EODHD_Client.EOM_Client;
using EODHD_Client.Fundamentals_Client;
using EODHD_Client.Profile_Client;
using Logic.Contracts;
using System.Linq.Expressions;

namespace Logic.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IFundamentalsLogic _fundamentalsLogic;
        private IFinanceGetter _financeGetter;
        private readonly IProfileGetter _profileGetter;
        private readonly IProfileLogic _profileLogic;
        private readonly IEOMGetter _eomGetter;
        public UnitOfWork(IFundamentalsLogic fundamentalsLogic, IProfileLogic profileLogic,string apiKey, string dataProviderEP)
        {
            _fundamentalsLogic = fundamentalsLogic;
            _financeGetter = new FinanceGetter(dataProviderEP, apiKey);
            _profileGetter = new ProfileGetter(dataProviderEP, apiKey);
            _profileLogic = profileLogic;
            _eomGetter = new EOMGetter(dataProviderEP, apiKey);
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

        public async Task<Profile_Final> GetProfileData(string id)
        {
            try
            {
                var rawProfileData = await _profileGetter.GetProfileDataAsync(id);
                Profile_Final profileData = await _profileLogic.GetFinalProfile(rawProfileData);
                return profileData;
            }
            catch (Exception)
            {

                throw;
            }
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

        public async Task<List<EOM>> GetEOM(string id) => await _eomGetter.GetEOMAsync(id);
    }
}
