using Entities.RawModels;
namespace EODHD_Client
{
    public class FinanceGetter  
    {
        private HttpClient _httpClient;
        private string _dataProviderEP;
        private string _APIKey;
        public FinanceGetter(string dataProviderEP, string apiKey)
        {
            _dataProviderEP = dataProviderEP;
            _APIKey = apiKey;
            _httpClient = new HttpClient();
        }

        public async Task<List<FinancialData>> GetFinancialDatasAsync(string stockID)
        {
             return new List<FinancialData>();
        }

    }
}