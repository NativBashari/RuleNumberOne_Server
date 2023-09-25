using Entities.RawModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EODHD_Client.Profile_Client
{
    public class ProfileGetter : IProfileGetter
    {
        private readonly string dataProviderEP;
        private readonly string apiKey;
        private HttpClient _client;

        public ProfileGetter(string dataProviderEP, string apiKey)
        {
            this.dataProviderEP = dataProviderEP;
            this.apiKey = apiKey;
            _client = new HttpClient();
        }
        public async Task<General> GetProfileDataAsync(string stockID)
        {
            try
            {
                string request = $"{dataProviderEP}/fundamentals/{stockID}.US?api_token={apiKey}&filter=General";
                var response = await _client.GetAsync(request);
                if (response.IsSuccessStatusCode)
                {
                    var jString = await response.Content.ReadAsStringAsync();
                    var profile = JsonConvert.DeserializeObject<General>(jString);
                    return profile;
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
