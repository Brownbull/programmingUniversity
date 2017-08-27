using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Rectangulo:Cuadrado
    {
        private double _valor2;

        public double Valor2
        {
            get { return _valor2; }
            set { _valor2 = value; }
        }

        public Rectangulo(double valor, int codigo, double valor2)
            :base(valor, codigo)
        {
            Valor2 = valor2;
        }
        public Rectangulo()
        { }

        public override string ToString()
        {
            return "Rectangulo " + "Perimetro= " + Perimetro() + " Area= " + Area();
        }

        public override double Perimetro()
        {
            return (Valor * 2) + (Valor2 * 2);
        }
        public override double Area()
        {
            return Valor * Valor2;
        }


    } // end of public class Rectangulo:FiguraGeometrica
}
