using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HebrewDate
{
    [Serializable]
    [XmlRoot("Query")]
    internal class DateTemplate
    {
        // Properties
        [XmlElement("Day")]
        public string dayInWeek { get; set; }
        [XmlElement("DayMonth")]
        public string dayImMonth { get; set; }
        [XmlElement("Month")]
        public string monthName { get; set; }
        [XmlElement("Year")]
        public string yearName { get; set; }
        [XmlElement("Result")]
        public string result { get; set; }

        // Constractor
        public DateTemplate(string dayInWeek, string dayImMonth, string monthName, string yearName, string result)
        {
            this.dayInWeek = dayInWeek;
            this.dayImMonth = dayImMonth;
            this.monthName = monthName;
            this.yearName = yearName;
            this.result = result
        }
    }
}
