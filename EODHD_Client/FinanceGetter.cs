using Entities.RawModels;
using Newtonsoft.Json;
using System.Reflection.Metadata;

namespace EODHD_Client
{
    public class FinanceGetter: IFinanceGetter
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

        public async Task<FinancialData> GetFinancialDataAsync(string stockID)
        {
            try
            {
                string request = $"{_dataProviderEP}{stockID}.US?api_token={_APIKey}";
                var response = await _httpClient.GetAsync(request);
                if (response.IsSuccessStatusCode)
                {
                    var jString = await response.Content.ReadAsStringAsync();
                    var financeData = JsonConvert.DeserializeObject<FinancialData>(jString);
                    return financeData!;
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