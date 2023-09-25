using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.EOM
{
    public class EOM
    {
        public string date { get; set; } = string.Empty;
        public double open { get; set; }
        public double high { get; set; }
        public double low { get; set; }
        public double close { get; set; }
        public double adjusted_close { get; set; }
        public int volume { get; set; }
    }
}
