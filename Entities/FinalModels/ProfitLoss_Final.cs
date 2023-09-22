using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.FinalModels
{
    public class ProfitLoss_Final
    {
        public int Year { get; set; }
        public long Income { get; set; }
        public long Profit { get; set; }
        public float GrowthRates { get; set; } // From last year

    }
}
