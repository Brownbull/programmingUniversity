using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehiculos;

namespace AppAutomovil
{
    class Program
    {
        static void Main(string[] args)
        {
            Automovil auto = new Automovil(40, 10);
            Console.WriteLine(auto);
            Console.ReadKey();
        } // end of static void Main(string[] args)
    } // end of class Program
} // end of namespace AppAutomovil
