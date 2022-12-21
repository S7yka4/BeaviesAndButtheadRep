using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BevisAndButtheadClient
{
    public class Requester
    {
        HttpClient client;

        public Requester(string url)
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("http://BeavisAndButtheadBack.somee.com");
        }
    
        public string Get(string url)
        {
            HttpResponseMessage response =  client.GetAsync(url).Result;
            response.EnsureSuccessStatusCode();
            return response.Content.ReadAsStringAsync().Result;
        }

        public string Put(string url,string content)
        {
            var response=client.PutAsync(url, new StringContent(content, Encoding.UTF8, "application/json")).Result;
            response.EnsureSuccessStatusCode();
            return response.Content.ReadAsStringAsync().Result;
        }

        public string Post(string url,string content)
        {
            var response = client.PostAsync(url, new StringContent(content, Encoding.UTF8, "application/json")).Result;
            response.EnsureSuccessStatusCode();
            return response.Content.ReadAsStringAsync().Result;
        }
    }
}
