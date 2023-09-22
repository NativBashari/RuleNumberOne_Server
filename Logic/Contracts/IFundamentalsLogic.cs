using Entities.FinalModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Contracts
{
    public interface IFundamentalsLogic
    {
        Task<IEnumerable<BalanceSheet>> GetBalanceSheetsAsync(string id);
        Task<IEnumerable<CashFlow>> GetCashFlowsAsync(string id);
        Task<IEnumerable<ProfitLoss>> GetProfitLossAsync(string id);



    }
}
