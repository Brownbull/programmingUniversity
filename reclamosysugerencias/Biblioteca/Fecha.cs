using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Fecha
    {
        private int _day;
        private int _month;
        private int _year;

        public override string ToString()
        {
            return Day + "/" + Month + "/" + Year + "\n";
        }

        public Fecha(int dia, int mes, int anio)
        {
            Day = dia;
            Month = mes;
            Year = anio;
        }
        public Fecha()
        { }
        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

        public int Month
        {
            get { return _month; }
            set { _month = value; }
        }

        public int Day
        {
            get { return _day; }
            set { _day = value; }
        }
        
    }
}
