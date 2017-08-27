using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;


namespace Manejadora
{
    public class Maneja
    {
        private List<FiguraGeometrica> _lista;

        public List<FiguraGeometrica> Lista
        {
            get { return _lista; }
            set { _lista = value; }
        }

        public Maneja()
        {
            Lista = new List<FiguraGeometrica>();
        }

        public bool Verifica(FiguraGeometrica figura)
        {
            foreach (FiguraGeometrica ni in Lista)
            {
                if (figura.Equals(figura))
                    return true;
            }
            return false;
        }

        public void Agregar(FiguraGeometrica figura)
        {
            Lista.Add(figura);
        }

        public string Contar()
        {
            int contCirculo = 0;
            int contCuadrado = 0;
            int contRectangulo = 0;

            foreach ( FiguraGeometrica fig in Lista)
            {
                if ( fig is Circulo)
                {
                    contCirculo++;
                }
                else if (fig is Cuadrado)
                {
                    contCuadrado++;
                }
                else if (fig is Rectangulo)
                {
                    contRectangulo++;
                }
            }

            return "Circulos = " + contCirculo + " Cuadrados = " + contCuadrado + " Rectangulos = " + contRectangulo;
        }

        public string Lado2DePrimerRectangulo()
        {
            foreach (FiguraGeometrica fig in Lista)
            {
                if (fig is Rectangulo)
                {
                    Rectangulo aux = (Rectangulo)fig;
                    return "El lado del primer Rectangulo encontrado es : " + aux.Valor2;
                }
            }

            return "No hay rectagulos";
        }




    }  // end of public class Maneja
} // end of namespace Manejadora
