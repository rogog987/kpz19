using kpz19;
using System;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Запуск програми...\n");

        try
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory;

            string testFilesPath = Path.Combine(basePath, "..", "..", "..", "TestFiles"); 
            string csvPath = Path.Combine(testFilesPath, "data.csv");
            string jsonPath = Path.Combine(testFilesPath, "data.json");
            string xmlPath = Path.Combine(testFilesPath, "data.xml");
                    
            DataMiner csvMiner = new CsvDataMiner();
            DataMiner jsonMiner = new JsonDataMiner();
            DataMiner xmlMiner = new XmlDataMiner();

            Console.WriteLine("Обробка JSON-файлу...");
            jsonMiner.Mine(jsonPath);

            Console.WriteLine("Обробка XML-файлу...");
            xmlMiner.Mine(xmlPath);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Помилка: {ex.Message}");
        }

        Console.WriteLine("\nПрограма завершила роботу.");
    }
}
