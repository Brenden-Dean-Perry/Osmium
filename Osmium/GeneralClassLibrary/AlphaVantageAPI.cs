using System;
using System.Collections.Generic;
using System.Net;
using System.Text.Json;


namespace GeneralClassLibrary
{
    public class AlphaVantageAPI
    {
        private string _apiKey {get; set;}
        public AlphaVantageAPI(string apiKey)
        {
            _apiKey = apiKey;
        }

        public dynamic? GetTickerSearchResults(string text)
        {
            // replace the "demo" apikey below with your own key from https://www.alphavantage.co/support/#api-key
            string QUERY_URL = $"https://www.alphavantage.co/query?function=SYMBOL_SEARCH&keywords={text}&apikey={_apiKey}";
            Uri queryUri = new Uri(QUERY_URL);

            using (HttpClient client = new HttpClient())
            {
                string result = client.GetStringAsync(queryUri).Result;
                dynamic json_data = JsonSerializer.Deserialize<Dictionary<string, dynamic>>(result);
                return json_data;
            }
        }
        
    }
}