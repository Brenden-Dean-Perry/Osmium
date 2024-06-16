﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace DataAccess.Utilities
{
    internal class JSONUtilities
    {
        internal static string GetJSONStringFromAPIRequest(string URL)
        {
            Uri queryUri = new Uri(URL);
            using (HttpClient client = new HttpClient())
            {
                string result = client.GetStringAsync(queryUri).Result;
                return result;
            }
        }

        internal static void ObjectToJSONFile<T>(T obj, string FullFilePath)
        {
            var options = new JsonSerializerOptions();
            options.WriteIndented = true;
            string jsonString = JsonSerializer.Serialize(obj, options);
            File.WriteAllText(FullFilePath, jsonString);
        }

        internal static T JSONFileToObject<T>(string FullFilePath)
        {
            string jsonString = File.ReadAllText(FullFilePath);
            T obj = JsonSerializer.Deserialize<T>(jsonString)!;
            return obj;
        }

        internal static T JSONStringToObject<T>(string jsonString)
        {
            var options = new JsonSerializerOptions();
            options.AllowTrailingCommas = true;
            options.PropertyNameCaseInsensitive = true;
            var obj = JsonSerializer.Deserialize<T>(jsonString, options)!;
            return obj;
        }
    }
}
