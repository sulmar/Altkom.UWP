using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Altkom.Bicycle.UWPClient.Services
{
    public class GenericHttpClient
    {
        public static async Task<TResult> GetAsync<TResult>(string uri)
        {
            var client = new HttpClient();

            HttpRequestMessage request = new HttpRequestMessage();

            var response = await client.GetAsync(uri);

            TResult result = default(TResult);

            if (response.IsSuccessStatusCode)
            {
                // deserializacja 
                result = await response.Content.ReadAsAsync<TResult>();
            }

            return result;

        }
    }
}
