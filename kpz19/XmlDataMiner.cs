using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace kpz19
{
    public class XmlDataMiner : DataMiner
    {
        protected override string LoadData(string filePath)
        {
            return File.ReadAllText(filePath);
        }

        protected override string ParseData(string data)
        {
            var xml = XDocument.Parse(data);
            return $"XML-структура:\n{xml}";
        }
    }

}
