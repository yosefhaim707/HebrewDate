using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HebrewDate
{
    internal class Repository : IReposittory
    {
        public void AddToXML(DateTemplate dateTemplate)
        {
           var xmlString = 

        }

        

        private static string SerializeObjectToXmlString(DateTemplate dateTemplate)
        {
            

            var xmlSerializer = new XmlSerializer(typeof(DateTemplate));
            using (var writer = new StringWriter())
            {
                xmlSerializer.Serialize(writer, dateTemplate);
                var xmlContent = writer.ToString();
                
                
                return xmlContent;
            }
        }

        public string GetDayInMonth(string comboString)
        {
            throw new NotImplementedException();
        }

        public string GetDayInWeek(string comboString)
        {
            throw new NotImplementedException();
        }

        public string GetMonth(string comboString)
        {
            throw new NotImplementedException();
        }

        public string GetYear(string comboString)
        {
            throw new NotImplementedException();
        }
    }
}
