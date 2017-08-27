using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public abstract class FiguraGeometrica
    {
        private double _valor;
        private int _codigo;
        protected double Valor
        {
            get { return _valor; }
            set { _valor = value; }
        }
        

        protected int Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        public override int GetHashCode()
        {
            return this.Codigo.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            FiguraGeometrica fig = obj as FiguraGeometrica;

            if (fig == null)
            {
                return false;
            }
            else
            {
                return base.Equals(obj);
            }
        }

        public abstract double Area();
        public abstract double Perimetro();

        public FiguraGeometrica(double valor, int codigo)
        {
            Valor = valor;
            Codigo = codigo;
        }

        public FiguraGeometrica()
        { }

        public override string ToString()
        {
            return "Figura geometrica";
        }



    } // end of public abstract class FiguraGeometrica
} // end of namespace Biblioteca
