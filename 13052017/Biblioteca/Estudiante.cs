using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Estudiante
    {
        private string _nombre;
        private float _nota;

        public override string ToString()
        {
            // this come from class object
            return "El alumno " + Nombre + " tiene una nota de : " + Nota + "\n";
        }
        public Estudiante(Estudiante estu)
        {
            Nombre = estu.Nombre;
            Nota = estu.Nota;
        }
        public Estudiante(string nombre, float nota)
        {
            Nombre = nombre;
            Nota = nota;
        }
        public Estudiante()
        { }
        public float Nota
        {
            get { return _nota; }
            set { _nota = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
    }
}
