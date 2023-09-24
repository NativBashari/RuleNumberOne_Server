using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.FinalModels
{
    public class FinancialData_Final
    {
        public FinancialData_Final()
        {
            BalanceSheet = new List<BalanceSheet_Final>();
            CashFlow = new List<CashFlow_Final>();
            ProfitLoss = new List<ProfitLoss_Final>();
            stockProfit = new List<StockProfit_Final>();
        }
        public IList<BalanceSheet_Final> BalanceSheet { get; set; }
        public IList<CashFlow_Final> CashFlow { get; set; }
        public IList<ProfitLoss_Final> ProfitLoss { get; set; }
        public IList<StockProfit_Final> stockProfit { get; set; }
    }
}
