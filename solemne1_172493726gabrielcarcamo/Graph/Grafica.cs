using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using Vehiculos;

namespace Graph
{
    public class Grafica
    {
        public void Put(Canvas canv, Automovil auto)
        {
            canv.Children.Clear();
            double PortionHeight = canv.Height / auto.Capacidad;

            Line recta1 = new Line();
            recta1.StrokeThickness = canv.Width;
            recta1.X1 = canv.Width/2;
            recta1.Y1 = (int)canv.Height;
            recta1.X2 = canv.Width/2;//(int)(canv.Height -  (PortionHeight * auto.Contenido));
            recta1.Y2 = (int)(canv.Height - (PortionHeight * auto.Contenido));

            if ((auto.Capacidad * 0.25) > auto.Contenido)
            {
                recta1.Stroke = Brushes.Yellow;
            }
            if ((auto.Capacidad * 0.25) < auto.Contenido)
            {
                recta1.Stroke = Brushes.Green;
            }
            if ((auto.Capacidad * 0.10) > auto.Contenido)
            {
                recta1.Stroke = Brushes.Red;
            }
          //  recta1.StrokeThickness = canv.Width;

            canv.Children.Add(recta1);
        }
    }
}
