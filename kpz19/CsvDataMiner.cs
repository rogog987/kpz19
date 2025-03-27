using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kpz19
{
    public class CsvDataMiner : DataMiner
    {
        protected override string LoadData(string filePath)
        {
            return File.ReadAllText(filePath);
        }

        protected override string ParseData(string data)
        {
            return $"CSV-дані: {data.Replace(",", " | ")}";
        }
    }

}
