using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DataAccess.DTOs
{

        public class GlobalQuote
        {
            [JsonPropertyName("01. symbol")]
            public string symbol { get; set; }

            [JsonPropertyName("02. open")]
            public string open { get; set; }

            [JsonPropertyName("03. high")]
            public string high { get; set; }

            [JsonPropertyName("04. low")]
            public string low { get; set; }

            [JsonPropertyName("05. price")]
            public string price { get; set; }

            [JsonPropertyName("06. volume")]
            public string volume { get; set; }

            [JsonPropertyName("07. latest trading day")]
            public string latesttradingday { get; set; }

            [JsonPropertyName("08. previous close")]
            public string previousclose { get; set; }

            [JsonPropertyName("09. change")]
            public string change { get; set; }

            [JsonPropertyName("10. change percent")]
            public string changepercent { get; set; }

            [JsonIgnore]
            public DateTime LoadDateTime { get; set; } = DateTime.Now;


           

    }
}
