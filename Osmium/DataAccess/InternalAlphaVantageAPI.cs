using System;
using System.Collections.Generic;
using System.Net;
using System.Text.Json;


namespace DataAccess
{
    internal class InternalAlphaVantageAPI
    {
        private string _apiKey { get; set; }
        internal InternalAlphaVantageAPI(string apiKey)
        {
            _apiKey = apiKey;
        }

        internal dynamic? GetTickerSearchResults(string text)
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

        internal decimal GetPrice(string symbol)
        {
            string QUERY_URL = $"https://www.alphavantage.co/query?function=GLOBAL_QUOTE&symbol=IBM&apikey={_apiKey}";
            Uri queryUri = new Uri(QUERY_URL);

            using (HttpClient client = new HttpClient())
            {
                DTOs.Root price = new DTOs.Root();
                string result = client.GetStringAsync(queryUri).Result;
                price = GeneralClassLibrary.Utilities.JSONUtilities.JSONStringToObject<DTOs.Root>(result);
                return Decimal.Parse(price.GlobalQuote.price);
                //dynamic json_data = JsonSerializer.Deserialize<Dictionary<string, dynamic>>(client.GetStringAsync(queryUri).Result);

            }
        }

        internal string GetTest()
        {
            string QUERY_URL = $"https://www.alphavantage.co/query?function=GLOBAL_QUOTE&symbol=IBM&apikey={_apiKey}";
            Uri queryUri = new Uri(QUERY_URL);

            using (HttpClient client = new HttpClient())
            {
                DTOs.Root quote = new DTOs.Root();
                quote.GlobalQuote = new DTOs.GlobalQuote();
                string result = client.GetStringAsync(queryUri).Result;
                quote = GeneralClassLibrary.Utilities.JSONUtilities.JSONStringToObject<DTOs.Root>(result);
                return quote.GlobalQuote.symbol;
                //dynamic json_data = JsonSerializer.Deserialize<Dictionary<string, dynamic>>(client.GetStringAsync(queryUri).Result);

            }
        }
    }
}