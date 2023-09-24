using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Globalization;


namespace Entities.RawModels
{
    public partial class FinancialData
    {
        public partial class Financials
        {
            [JsonProperty("Balance_Sheet")]
            public BalanceSheet BalanceSheet { get; set; }

            [JsonProperty("Cash_Flow")]
            public CashFlow CashFlow { get; set; }

            [JsonProperty("Income_Statement")]
            public IncomeStatement IncomeStatement { get; set; }
        }

        public partial class BalanceSheet
        {
            [JsonProperty("currency_symbol")]
            public string CurrencySymbol { get; set; }

            [JsonProperty("quarterly")]
            public Dictionary<string, Dictionary<string, string>> Quarterly { get; set; }

            [JsonProperty("yearly")]
            public Dictionary<string, Dictionary<string, string>> Yearly { get; set; }
        }

        public partial class CashFlow
        {
            [JsonProperty("currency_symbol")]
            public string CurrencySymbol { get; set; }

            [JsonProperty("quarterly")]
            public Dictionary<string, Dictionary<string, string>> Quarterly { get; set; }

            [JsonProperty("yearly")]
            public Dictionary<string, Dictionary<string, string>> Yearly { get; set; }
        }

        public partial class IncomeStatement
        {
            [JsonProperty("currency_symbol")]
            public string CurrencySymbol { get; set; }

            [JsonProperty("quarterly")]
            public Dictionary<string, Dictionary<string, string>> Quarterly { get; set; }

            [JsonProperty("yearly")]
            public Dictionary<string, Dictionary<string, string>> Yearly { get; set; }
        }


    }
}