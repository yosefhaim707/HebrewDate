using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HebrewDate
{
    internal interface IReposittory
    {
        public string GetDayInWeek(string comboString);
        public string GetDayInMonth(string comboString);
        public string GetMonth(string comboString);
        public string GetYear(string comboString);
        public void AddToXML(DateTemplate dateTemplate);
    }
}
