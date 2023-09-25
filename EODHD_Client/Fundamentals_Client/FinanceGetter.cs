using Entities.RawModels;
using Newtonsoft.Json;
using System.Security.AccessControl;

namespace EODHD_Client.Fundamentals_Client
{
    public class FinanceGetter : IFinanceGetter
    {
        private HttpClient _httpClient;
        private readonly string _dataProviderEP;
        private readonly string _APIKey;
        public FinanceGetter(string dataProviderEP, string apiKey)
        {
            _dataProviderEP = dataProviderEP;
            _APIKey = apiKey;
            _httpClient = new HttpClient();
        }

        public async Task<FinancialData> GetFinancialDataAsync(string stockID)
        {
            try
            {
                string request = $"{_dataProviderEP}{stockID}.US?api_token={_APIKey}&filter=Financials::Balance_Sheet::yearly,Financials::Cash_Flow::yearly,Financials::Income_Statement::yearly";
                var response = await _httpClient.GetAsync(request);
                if (response.IsSuccessStatusCode)
                {
                    var jString = await response.Content.ReadAsStringAsync();
                    var financeDataYearly = JsonConvert.DeserializeObject<FinancialsYearly>(jString);
                    FinancialData financialData = new FinancialData()
                    {
                        Financials = new Financials()
                        {
                            BalanceSheet = new BalanceSheet()
                            {
                                Yearly = financeDataYearly.BalanceSheetYearly
                            },
                            IncomeStatement = new IncomeStatement()
                            {
                                Yearly = financeDataYearly.IncomeStatementYearly
                            },
                            CashFlow = new CashFlow()
                            {
                                Yearly = financeDataYearly.CashFlowYearly
                            }
                        }
                    };
                    return financialData!;
                }

            }
            catch (Exception)
            {

                throw;
            }

            return new FinancialData();
        }
    }
}