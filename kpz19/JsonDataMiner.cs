using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace kpz19
{
    public class JsonDataMiner : DataMiner
    {
        protected override string LoadData(string filePath)
        {
            return File.ReadAllText(filePath);
        }

        protected override string ParseData(string data)
        {
            var jsonElement = JsonSerializer.Deserialize<JsonElement>(data);
            return $"JSON-об'єкт: {jsonElement.ToString()}";
        }
    }

}
