using Entities.FinalModels;
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
        Task<IEnumerable<BalanceSheet_Final>> GetBalanceSheetsAsync(BalanceSheet balanceSheet);
        Task<IEnumerable<CashFlow_Final>> GetCashFlowsAsync(CashFlow cashFlow);
        Task<IEnumerable<ProfitLoss_Final>> GetProfitLossAsync(IncomeStatement incomeStatement);



    }
}
