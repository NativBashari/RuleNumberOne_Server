using Entities.RawModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EODHD_Client.Highlights_Client
{
    public class HighlightsGetter : IHighlightsGetter
    {
        private readonly string dataProviderEP;
        private readonly string apiKey;
        private HttpClient _client;

        public HighlightsGetter(string dataProviderEP, string apiKey)
        {
            this.dataProviderEP = dataProviderEP;
            this.apiKey = apiKey;
            _client = new HttpClient();
        }
        public async Task<Highlights> GetHighlightsAsync(string stockID)
        {
            try
            {
                string request = $"{dataProviderEP}/fundamentals/{stockID}.US?api_token={apiKey}&filter=Highlights";
                var response = await _client.GetAsync(request);
                if (response.IsSuccessStatusCode)
                {
                    var jString = await response.Content.ReadAsStringAsync();
                    var highlights = JsonConvert.DeserializeObject<Highlights>(jString);
                    return highlights;
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
