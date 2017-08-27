using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    public class Automovil
    {
        // Attributes
        private int _capacidad;
        private double _contenido;
        private double _rendimiento;

        // Operations
        // Constructors
        private void Init()
        {
            this.Contenido = this.Capacidad / 2;
        }

        public Automovil()
        {
            Init();
        }

        public Automovil(Automovil CarToCopy)
        {
            Init();
            this.Rendimiento = CarToCopy.Rendimiento;
            this.Contenido = CarToCopy.Contenido;
            this.Capacidad = CarToCopy.Capacidad;
        }

        public Automovil(int Capacity, double Performance)
        {
            Init();
            this.Rendimiento = Performance;
            this.Contenido = Capacity;
        }
            
        // Access Methods
        public double Rendimiento
        {
            get { return _rendimiento; }
            set { _rendimiento = value; }
        }
        public double Contenido
        {
            get { return _contenido; }
            set { _contenido = value; }
        }
   
        public int Capacidad
        {
            get { return _capacidad; }
            set { _capacidad = value; }
        }

        // Custom Methods
        // Calcula Autonomia de Vehiculo en base a litros de combusible en estanque y rendimiento por litro
        public double Autonomia()
        { 
            return this.Contenido * this.Rendimiento; 
        }

        // Asigna a contenido de litros en estanque su maximo valor posible
        public void LlenarEstanque()
        {
            this.Contenido = this.Capacidad;
        }

        // muestra Contenido y autonomia de un Vehiculo
        public override string ToString()
        {
            return "Combustible en Estanque: " + this.Contenido.ToString() + "\t Autonomia: " + Autonomia();
        }
        
        // Gasta litros en estanque segun la cantidad a recorrer, retorna -1 si la distacia no se puede recorrer con el combustible restante
        public double Viajar(int Distance)
        {
            double ToUse = Distance / this.Rendimiento;

                return this.Contenido - ToUse;
            
        }

    } // end of  public class Automovil
} // end of namespace Vehiculos
