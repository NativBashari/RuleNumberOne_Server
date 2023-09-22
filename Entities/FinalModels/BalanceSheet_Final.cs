using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.FinalModels
{
    public class BalanceSheet_Final
    {
        public int Year { get; set; }
        public long Equity { get; set; }
        public long Debts { get; set; }
        public float GrowthRates { get; set; } // Equity - last year
    }
}
