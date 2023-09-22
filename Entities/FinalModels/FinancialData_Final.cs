using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.FinalModels
{
    public class FinancialData_Final
    {
        public BalanceSheet_Final BalanceSheet { get; set; }
        public CashFlow_Final CashFlow { get; set; }
        public ProfitLoss_Final ProfitLoss { get; set; }
    }
}
