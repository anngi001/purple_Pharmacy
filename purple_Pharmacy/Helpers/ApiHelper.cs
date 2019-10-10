using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace purple_Pharmacy.Helpers
{
    public static class ApiHelper
    {
        public static T Get<T>(string url)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://api-taller.herokuapp.com");

            var request = client.GetAsync(url).Result;
            if (request.IsSuccessStatusCode)
            {
                var responseJson = request.Content.ReadAsStringAsync().Result;
                var response = JsonConvert.DeserializeObject<T>(responseJson);

                return response;
            }

            return default(T);
        }
    }
}
