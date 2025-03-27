using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kpz19
{
    public abstract class DataMiner
    {
        public void Mine(string filePath)
        {
            Console.WriteLine($"Обробка файлу: {filePath}");
            string data = LoadData(filePath);
            string parsedData = ParseData(data);
            AnalyzeData(parsedData);
            Console.WriteLine("Парсинг завершено.\n");
        }

        protected abstract string LoadData(string filePath);
        protected abstract string ParseData(string data);

        protected virtual void AnalyzeData(string parsedData)
        {
            Console.WriteLine($"Аналіз даних:\n{parsedData}");
        }
    }
}
