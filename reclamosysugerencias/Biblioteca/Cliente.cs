using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Cliente
    {
        private string _nombre;
        private string _rut;
        public string Rut
        {
            get { return _rut; }
            set { _rut = value; }
        }
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        // Constructores
        public Cliente()
        { }
        public Cliente(string nombre, string rut)
        { 
            Nombre = nombre;
            Rut = rut;
        }

        public override string ToString()
        {
            return "Cliente : " + Nombre + " Rut : " + Rut + "\n";
        }
    } // end of public class Cliente
} // end of namespace Biblioteca
