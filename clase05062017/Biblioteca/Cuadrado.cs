using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Cuadrado:FiguraGeometrica
    {
        public Cuadrado(double valor, int codigo)
            :base(valor, codigo)
        {

        }
        public Cuadrado()
        {

        }

        public override string ToString()
        {
            return "Cuadrado " + "Perimetro= " + Perimetro() + " Area= " + Area();
        }

        public override double Perimetro()
        {
            return Valor * 4;
        }
        public override double Area()
        {
            return Math.Pow(Valor,2);
        }

    } // end of class Cuadrado:FiguraGeometrica
} // end of namespace Biblioteca
