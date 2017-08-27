using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Circulo:FiguraGeometrica
    {
        public Circulo(double valor, int codigo)
            :base(valor,codigo) // pasamos datoa a clase madre
        {

        }

        public Circulo()
        { }

        public override string ToString()
        {
            return "Circulo " + "Permetro =" + Perimetro() + "Area = " + Area();
        }

        public override double Perimetro()
        {
            return 2 * Math.PI * Valor;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(Valor, 2);
        }




    } // end of public class Circulo:FiguraGeometrica
}
