using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    public class Curso
    {
        private int _alumnos;
        private double[] _notas;
        private string[] _sexo;

        /// <summary>
        /// Constructres
        /// </summary>
        public Curso(Curso curso) 
        {
            // copy all values from received object
            this.Alumnos = curso.Alumnos;
            this.Notas = new double[this.Alumnos];
            this.Sexo = new string[this.Alumnos];

            for (int i = 0; i < curso.Notas.Length; i++)
            {
                this.Notas[i] = curso.Notas[i];
            }

            for (int j = 0; j < curso.Sexo.Length; j++)
            {
                this.Sexo[j] = curso.Sexo[j];
            }

        } // end of public Curso(Curso curso) 
        
        public Curso(int alumnos)
        {
            Alumnos = alumnos;
            Random azar = new Random();
            Notas = new double[alumnos];
            Sexo = new string[alumnos];

            // assign random values
            // randomize Notas
            for (int i = 0; i < Notas.Length; i++)
            {
                Notas[i] = (float)azar.Next(10, 70) / (float)10.0;
            } // end of for

            // randomize Sexo
            for (int j = 0; j < Sexo.Length; j++)
            {
                if (azar.Next(0, 2) == 0)
                {
                    Sexo[j] = "Mujer";
                }
                else
                {
                    Sexo[j] = "Hombre";
                }
            } // end of for
        } //  end of  public Curso(int alumnos)
        public Curso()
        {
            Init();
        }

        private void Init()
        {
            Alumnos = 10;
            Random azar = new Random();
            Notas = new double[10];
            Sexo = new string[10];

            // assign random values
            // randomize Notas
            for (int i = 0; i < Notas.Length ; i++)
            {
                Notas[i] = (float)azar.Next(10, 70) / (float)10.0;
            }

            // randomize Sexo
            for (int j = 0; j < Sexo.Length; j++)
            {
                if (azar.Next(0, 2) == 0)
                {
                    Sexo[j] = "Mujer";
                }
                else
                { 
                    Sexo[j] = "Hombre"; 
                }                
            }


        }
        public string[] Sexo
        {
            get { return _sexo; }
            set { _sexo = value; }
        }
        public double[] Notas
        {
            get { return _notas; }
            set { _notas = value; }
        } // end of public double[] Notas
        public int Alumnos
        {
            get { return _alumnos; }
            set { _alumnos = value; }
        } // end of public int Alumnos

        // custom Methods
        public int AlumnosAprobados()
        {
            int count = 0;
            for (int i =0; i < Alumnos; i++)
            {
                if (Notas[i] >= 4)
                {
                    count++;
                }
            }

            return count;
        } // end of public int AlumnosAprobados()

        public double Promediocurso()
        {
            double total = 0;
            for (int i = 0; i < Alumnos; i++)
            {
                    total = total + Notas[i];       
            }

            return total / Alumnos;
        } // end of public int Promediocurso()

        public string SexoMejorAlumno()
        {
            double mejor = Notas[0];
            string salida = Sexo[0];
            for (int i = 0; i < Alumnos; i++)
            {
                if( Notas[i] > mejor)
                {
                    mejor = Notas[i];
                    salida = Sexo[i];
                }
            }
            return salida;
        } // end of public string SexoMejorAlumno()

        public int MenoresQue(double Limit)
        {
            int count = 0;
            
            for (int i = 0; i < Alumnos; i++)
            {
                if (Notas[i] < Limit)
                {
                    count++;
                }
            }
            return count;
        } // end of public int MenoresQue(int Limit)

        public int MayoresQue(double Limit)
        {
            int count = 0;

            for (int i = 0; i < Alumnos; i++)
            {
                if (Notas[i] > Limit)
                {
                    count++;
                }
            }
            return count;
        } // end of public int MayoresQue(int Limit)


        public int CuantosEntre(double A, double B)
        {
            int count = 0;
            double max, min;

            if(A > B)
            {
                max = A;
                min = B;
            }
            else
            {
                max = B;
                min = A;
            }

            for (int i = 0; i < Alumnos; i++)
            {
                if ((Notas[i] <= max) && (Notas[i] >= min))
                {
                    count++;
                }
            }
            return count;
        } // end of public int CuantosEntre(int A, int B)

        // sobreescribir methodo to string
        public override string ToString()
        {
            //return base.ToString();
            return "La cantidad de alumnos son: " + Alumnos;
        }


    } // end of public class Curso
} // end of namespace Ejercicio
