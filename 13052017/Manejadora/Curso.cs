using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Manejadora
{
    public class Curso
    {
        private Estudiante[] _participantes;

        // devuelve nota menor del curso
        public string NombreMenorCalificacion()
        {
            float menor = Participantes[0].Nota;
            string nombre = Participantes[0].Nombre;

            for (int i = 0; i < Participantes.Length; i++)
            {
                if (Participantes[i].Nota < menor)
                {
                    menor = Participantes[i].Nota;
                    nombre = Participantes[0].Nombre; 
                }
            }
            return nombre;
        }

        // devuelve nota mayor del curso
        public float MayorCalificacion()
        {
            float mayor = Participantes[0].Nota;

            for (int i = 0; i < Participantes.Length; i++)
            {
                if(Participantes[i].Nota > mayor)
                {
                    mayor = Participantes[i].Nota;
                }
            }
            return mayor;
        }
        
        // devuelve promedio de notas de todo el curso
        public float Promedio()
        {
            float suma = 0;
            for (int i = 0; i < Participantes.Length; i++)
            {
                suma = suma + Participantes[i].Nota;
            }

            return suma / Participantes.Length;
        }
        
        public void AgregarParticipante(Estudiante e)
        {
            Array.Resize(ref _participantes, _participantes.Length + 1);
            _participantes[_participantes.Length - 1] = e;
        }
        public Curso()
        {
            _participantes = new Estudiante[0];
        }

        public Estudiante[] Participantes
        {
            get { return _participantes; }
            set { _participantes = value; }
        }
    }
}
