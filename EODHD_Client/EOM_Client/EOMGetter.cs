using Entities.EOM;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EODHD_Client.EOM_Client
{
    public class EOMGetter : IEOMGetter
    {
        private readonly HttpClient _httpClient;
        private readonly string _dataProviderEP;
        private readonly string _apiKey;
        public EOMGetter(string dataProvider, string apiKey)
        {
            _httpClient = new HttpClient();
            _apiKey = apiKey;
            _dataProviderEP = dataProvider;
        }

        public async Task<List<EOM>> GetEOMAsync(string stockID)
        {
            string from = "2022-09-26";
            string to = "2023-09-26";
            string request = $"{_dataProviderEP}/eod/{stockID}.US?from={from}&to={to}&period=m&fmt=json&&api_token={_apiKey}";
            try
            {
                var response = await _httpClient.GetAsync(request);
                if (response.IsSuccessStatusCode)
                {
                    var jString = await response.Content.ReadAsStringAsync();
                    var EOM = JsonConvert.DeserializeObject<List<EOM>>(jString);
                    return EOM;
                }
            }
            catch (Exception)
            {

                throw;
            }
            return null;
        }
    }
}
