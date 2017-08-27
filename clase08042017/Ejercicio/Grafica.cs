using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Ejercicio
{
    public class Grafica
    {
        public void PintarTodo(Canvas canv, Curso curso, double Min, double Max)
        {
            double Portionwidth = canv.Width / 4;
            double PortionHeight = canv.Height / 7;

            Line recta1 = new Line();
            recta1.StrokeThickness = 20;
            recta1.X1 = Portionwidth/2;
            recta1.Y1 = canv.Height;
            recta1.X2 = Portionwidth/2;
            recta1.Y2 = canv.Height - ((curso.MenoresQue(Min) * canv.Height / curso.Alumnos));
            recta1.Stroke = Brushes.Red;
            recta1.StrokeThickness = 20;

            canv.Children.Add(recta1);

            Line recta2 = new Line();
            recta2.StrokeThickness = 20;
            recta2.X1 = (2 * Portionwidth) - Portionwidth / 2;
            recta2.Y1 = canv.Height;
            recta2.X2 = (2 * Portionwidth) - Portionwidth / 2;
            recta2.Y2 = canv.Height - ((curso.MayoresQue(Max) * canv.Height / curso.Alumnos));
            recta2.Stroke = Brushes.Yellow;
            recta2.StrokeThickness = 20;

            canv.Children.Add(recta2);

            Line recta3 = new Line();
            recta3.StrokeThickness = 20;
            recta3.X1 = (3 * Portionwidth) - Portionwidth / 2;
            recta3.Y1 = canv.Height;
            recta3.X2 = (3 * Portionwidth) - Portionwidth / 2;
            recta3.Y2 = canv.Height - ((curso.CuantosEntre(Min, Max) * canv.Height / curso.Alumnos));
            recta3.Stroke = Brushes.Green;
            recta3.StrokeThickness = 20;

            canv.Children.Add(recta3);

            Line recta4 = new Line();
            recta4.StrokeThickness = 20;
            recta4.X1 = (4 * Portionwidth) - Portionwidth / 2;
            recta4.Y1 = canv.Height;
            recta4.X2 = (4 * Portionwidth) - Portionwidth / 2;
            recta4.Y2 = canv.Height - ((curso.Alumnos * canv.Height / curso.Alumnos));
            recta4.Stroke = Brushes.Black;
            recta4.StrokeThickness = 20;

            canv.Children.Add(recta4);


            

        }
    }
}
