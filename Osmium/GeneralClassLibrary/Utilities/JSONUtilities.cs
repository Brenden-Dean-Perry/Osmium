using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace GeneralClassLibrary.Utilities
{
    public static class JSONUtilities
    {
        public static void ObjectToJSONFile<T>(T obj, string FullFilePath)
        {
            var options = new JsonSerializerOptions();
            options.WriteIndented = true;
            string jsonString = JsonSerializer.Serialize(obj, options);
            File.WriteAllText(FullFilePath, jsonString);
        }

        public static T? JSONFileToObject<T>(string FullFilePath)
        {
            string jsonString = File.ReadAllText(FullFilePath);
            T obj = JsonSerializer.Deserialize<T>(jsonString);
            return obj;
        }
        public static T JSONStringToObject<T>(string jsonString)
        {
            var options = new JsonSerializerOptions();
            options.AllowTrailingCommas = true;
            options.PropertyNameCaseInsensitive = true;
            return JsonSerializer.Deserialize<T>(jsonString, options);
        }
    }
}
