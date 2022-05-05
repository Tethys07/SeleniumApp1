using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumApp1
{
    internal class TestAPI
    {
        private HttpClient _httpClient = new HttpClient();
        private string _uri = "https://api.publicapis.org";

        public async Task<string> testRequest()
        {
            var Builder = new UriBuilder($"{_uri}/entries?category=animals&HTTPS=true");
            var Response = await _httpClient.GetAsync(Builder.Uri);
            var Context = await Response.Content.ReadAsStringAsync();

            //return await _httpClient.GetStringAsync(_uri);
            return Context;
        }

    }
}
