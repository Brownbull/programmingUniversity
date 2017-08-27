using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Vehiculos;

namespace Grafica
{
    public class Put
    {
        public void PutLine(Canvas canv, Automovil auto)
        {
            double PortionHeight = canv.Height / auto.Capacidad;
            int X1 = (int)canv.Height;
            int Y1 = 0;
            int X2 = (int)canv.Width;
            int Y2 = (int)(canv.Height - (PortionHeight * auto.Contenido));

            System.Windows.Shapes.Rectangle recta1 = new System.Windows.Shapes.Rectangle(1, 1, 1);
            canv.Children.Add(recta1);

        }
    }
}
