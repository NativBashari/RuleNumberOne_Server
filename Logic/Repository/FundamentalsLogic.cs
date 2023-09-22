using Entities.FinalModels;
using Entities.RawModels;
using Logic.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Repository
{
    public class FundamentalsLogic : IFundamentalsLogic
    {
        public Task<IEnumerable<BalanceSheet_Final>> GetBalanceSheetsAsync(BalanceSheet balanceSheet)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CashFlow_Final>> GetCashFlowsAsync(CashFlow cashFlow)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProfitLoss_Final>> GetProfitLossAsync(IncomeStatement incomeStatement)
        {
            throw new NotImplementedException();
        }
    }
}
