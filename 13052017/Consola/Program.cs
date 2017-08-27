using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;
using Manejadora;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            float nota;
            int op, op1;
            Estudiante estu;
            Curso cur = new Curso();

            do
            {
                Console.WriteLine("Que desea hacer??? digite opcion");
                Console.WriteLine("1: Ingresar un estudiante");
                Console.WriteLine("2: Salir ");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Console.WriteLine("Ingrese nombre del estudiante");
                        nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese nota del estudiante");
                        nota = float.Parse(Console.ReadLine());
                        estu = new Estudiante(nombre, nota);
                        cur.AgregarParticipante(estu);
                        Console.WriteLine("Estudiante Ingresado");
                        break;
                    case 2:
                        break;
                    default:
                        break;
                }

            } while (op != 2);

            do
            {
                Console.WriteLine("Que desea Ver??? digite opcion");
                Console.WriteLine("1: Ver todos los estudiantes");
                Console.WriteLine("2: Ver promedi de todos los estudiantes");
                Console.WriteLine("3: Ver la mejor nota");
                Console.WriteLine("4: Ver nombre del alumno con peor nota");
                Console.WriteLine("5: salir");
                op1 = int.Parse(Console.ReadLine());
                switch (op1)
                {
                    case 1:
                        Console.WriteLine("Los estudiantes son:");
                        Estudiante[] ver = cur.Participantes;

                        for (int i = 0; i < ver.Length; i++)
                        {
                            Console.Write(ver[i]);
                        }
                        break;
                    case 2:
                        Console.WriteLine("El promedio es " + cur.Promedio());
                        break;
                    case 3:
                        Console.WriteLine("La mejor nota es " + cur.MayorCalificacion());
                        break;
                    case 4:
                        Console.WriteLine("El mas Weon es " + cur.NombreMenorCalificacion());
                        break;
                    case 5:
                        break;
                    default:
                        break;
                }
                
            } while (op1 != 5);
            Console.ReadKey();
        }
    }
}
