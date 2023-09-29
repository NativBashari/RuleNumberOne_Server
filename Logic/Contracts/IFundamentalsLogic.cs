using Entities.FinalModels.Fundamentals;
using Entities.RawModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Contracts
{
    public interface IFundamentalsLogic
    {
        Task<IList<BalanceSheet_Final>> GetBalanceSheetsAsync(BalanceSheet balanceSheet);
        Task<IList<CashFlow_Final>> GetCashFlowsAsync(CashFlow cashFlow);
        Task<IList<ProfitLoss_Final>> GetProfitLossAsync(IncomeStatement incomeStatement);
        Task GetRoic(IList<ProfitLoss_Final> profitLoss_Final, IList<BalanceSheet_Final> balanceSheet_Finals);
        Task<IList<StockProfit_Final>> GetStockProfit(BalanceSheet balanceSheet,IncomeStatement incomeStatement);
       // Task<RuleNumberOneNumbers> GetRuleNumberOneNumbers(BalanceSheet balanceSheet);
    }
}
