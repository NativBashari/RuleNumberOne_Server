using Newtonsoft.Json;
namespace Entities.RawModels
{
    public partial class FinancialData
    {
        public Financials Financials { get; set; }
    }
        public partial class Financials
        {
        public BalanceSheet BalanceSheet { get; set; }

        public CashFlow CashFlow { get; set; }

            public IncomeStatement IncomeStatement { get; set; }
        }

        public partial class BalanceSheet
        {
        public string CurrencySymbol { get; set; }

        public Dictionary<string, Dictionary<string, string>> Quarterly { get; set; }

            public Dictionary<string, Dictionary<string, string>> Yearly { get; set; }
        }

        public partial class CashFlow
        {
        public string CurrencySymbol { get; set; }

        public Dictionary<string, Dictionary<string, string>> Quarterly { get; set; }

            public Dictionary<string, Dictionary<string, string>> Yearly { get; set; }
        }

        public partial class IncomeStatement
        {
        public string CurrencySymbol { get; set; }

        public Dictionary<string, Dictionary<string, string>> Quarterly { get; set; }

            public Dictionary<string, Dictionary<string, string>> Yearly { get; set; }
        }
}

