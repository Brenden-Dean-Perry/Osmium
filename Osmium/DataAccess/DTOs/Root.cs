using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DataAccess.DTOs
{
    public class Root
    {
        [JsonPropertyName("Global Quote")]
        public GlobalQuote GlobalQuote { get; set; }

    }
}
