using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace Osmium
{
    internal class OpenAIAPI
    {
        private string _apiKey { get; set; }
        public OpenAIAPI(string ApiKey)
        {
            _apiKey = ApiKey;
        }

        public string? GetData(string Prompt)
        {
            Uri baseUrl = new Uri("https://api.openai.com/v1/chat/completions");
            IRestClient client = new RestClient(baseUrl);

            var request = new RestRequest("completions", Method.Post);
            request.AddHeader("Authorization", $"Bearer {_apiKey}");
            request.AddHeader("Content-Type", "application/json");

            var body = new
            {
                model = "gpt-4o",
                prompt = Prompt,
                max_tokens = 150,
                temperature = 0.7
            };

            RestResponse response = client.Execute(request);

            if (response.IsSuccessful)
            {
                return response.ToString();
            }
            else
            {
                return "Error encountered";
            }

        }

        public string GetEmbedding(string text)
        {

            Uri baseUrl = new Uri("https://api.openai.com/v1/embeddings");
            IRestClient client = new RestClient(baseUrl);

            var request = new RestRequest("completions", Method.Post);
            request.AddHeader("Authorization", $"Bearer {_apiKey}");
            request.AddHeader("Content-Type", "application/json");

            var body = new
            {
                model = "text-embedding-ada-002",
                input = text
            };

            RestResponse response = client.Execute(request);

            if (response.IsSuccessful)
            {
                return response.ToString();
            }
            else
            {
                return "Error encountered";
            }

        
        }
    }
}
