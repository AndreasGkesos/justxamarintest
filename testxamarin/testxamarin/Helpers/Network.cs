using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using testxamarin.Models;

namespace testxamarin.Helpers
{
    static class Network
    {
        public static async Task<LoginViewModel> LoginAsync(string keyUrl, LoginBindingModel loginData)
        {

            HttpClient client = new HttpClient();

            var url = Constants.GetUrls()[keyUrl];
            var result = await client.PostAsync(url, new StringContent(JsonConvert.SerializeObject(loginData, Formatting.Indented)));
            var data = JsonConvert.DeserializeObject<LoginViewModel>(await result.Content.ReadAsStringAsync());

            return data;
        }

        public static async Task<T> GetAsync<T>(string keyUrl)
        {

            HttpClient client = new HttpClient();

            var url = Constants.GetUrls()[keyUrl];
            var result = await client.GetAsync(url);
            var data = JsonConvert.DeserializeObject<T>(await result.Content.ReadAsStringAsync());

            return data;
        }
    }
}
