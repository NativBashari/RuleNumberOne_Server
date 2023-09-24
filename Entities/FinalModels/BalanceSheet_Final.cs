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
        public double Assets { get; set; }
        public double Debts { get; set; }
        public double GrowthRates { get; set; }
        public double Roic { get;set; }

    }
}
