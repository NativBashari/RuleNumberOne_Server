using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.RawModels
{
    public class FinancialsYearly
    {
        [JsonProperty("Financials::Balance_Sheet::yearly")]

        public Dictionary<string, Dictionary<string, string>> BalanceSheetYearly { get; set; } = new Dictionary<string, Dictionary<string, string>>();
        [JsonProperty("Financials::Income_Statement::yearly")]
        public Dictionary<string, Dictionary<string, string>> IncomeStatementYearly { get; set; } = new Dictionary<string, Dictionary<string, string>>();
        [JsonProperty("Financials::Cash_Flow::yearly")]
        public Dictionary<string, Dictionary<string, string>> CashFlowYearly { get; set; } = new Dictionary<string, Dictionary<string, string>>();


    }
}
