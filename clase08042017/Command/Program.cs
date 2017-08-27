using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            int alumnos;
            //Console.WriteLine("Ingrese numero de alumnos:");

            do
            {
                Console.WriteLine("Ingrese numero de alumnos:");
            } while (!int.TryParse(Console.ReadLine(), out alumnos));

           
            Curso curso = new Curso(alumnos);

            // mostar todas las notas y sexos
            for (int i = 0; i < alumnos; i++)
            {
                Console.WriteLine("Nota : " + curso.Notas[i] + "\t Sexo: " + curso.Sexo[i]);
            }

            Console.WriteLine("Promedio: " + curso.Promediocurso());
            Console.WriteLine("Aprobados: " + curso.AlumnosAprobados());
            Console.WriteLine("Sexo Mejor alumno: " + curso.SexoMejorAlumno());
            Console.ReadKey();
            
        }
    }
}
