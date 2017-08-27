using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enumeracion;
using Windows.UI.Xaml.Shapes;
using System.Windows;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI;

namespace Juego
{
    /// <summary>
    /// Ficha:
    /// permite generar circulos con diferenctes posiciones y medidas
    /// </summary>
    public class Ficha
    {
        private DeColor _color = DeColor.Negro;
        private int _left;
        private int _size = 15;
        private int _top;
        private Ellipse _circulo;

        public void Pintar()
        {
            // para cambiar color de ciruclo
            SolidColorBrush colo = new SolidColorBrush();
            switch (Color)
            {
                case DeColor.Amarillo:
                    colo.Color = Colors.Yellow;
                    break;
                case DeColor.Azul:
                    colo.Color = Colors.Blue;
                    break;
                case DeColor.Blanco:
                    colo.Color = Colors.White;
                    break;
                case DeColor.Cafe:
                    colo.Color = Colors.Brown;
                    break;
                case DeColor.Negro:
                    colo.Color = Colors.Black;
                    break;
                case DeColor.Rojo:
                    colo.Color = Colors.Red;
                    break;
                case DeColor.Verde:
                    colo.Color = Colors.Green;
                    break;
                case DeColor.Violeta:
                    colo.Color = Colors.Violet;
                    break;
                default:
                    colo.Color = Colors.Black;
                    break;
            }

            Circulo.Fill = colo;
        }
        /// <summary>
        /// This method draws a circle on a canvas:
        /// set size, color and position
        /// </summary>
        /// <param name="tela">canvas to draw</param>
        /// <param name="left">left alignment</param>
        /// <param name="top">top aligment</param>
        public void Dibujar(Canvas tela, int left, int top)
        {
            Circulo = new Ellipse();
            // setear posicion de la elipse en el canvas
            Canvas.SetLeft(Circulo, Left);
            Canvas.SetTop(Circulo, Top);
            
            // transformar elipse en circulo
            Circulo.Height = Size;
            Circulo.Width = Size;

            // para cambiar color de ciruclo
            SolidColorBrush colo = new SolidColorBrush();
            switch(Color)
            {
                case DeColor.Amarillo:
                    colo.Color = Colors.Yellow;
                    break;
                case DeColor.Azul:
                    colo.Color = Colors.Blue;
                    break;
                case DeColor.Blanco:
                    colo.Color = Colors.White;
                    break;
                case DeColor.Cafe:
                    colo.Color = Colors.Brown;
                    break;
                case DeColor.Negro:
                    colo.Color = Colors.Black;
                    break;
                case DeColor.Rojo:
                    colo.Color = Colors.Red;
                    break;
                case DeColor.Verde:
                    colo.Color = Colors.Green;
                    break;
                case DeColor.Violeta:
                    colo.Color = Colors.Violet;
                    break;
                default:
                    colo.Color = Colors.Black;
                    break;
            }

            Circulo.Stroke = colo;

            // definimos grueso de trazo de dibujo
            Circulo.StrokeThickness = 1;

            // draw on canvas
            tela.Children.Add(Circulo);
        }

        /// <summary>
        /// Establece posicion del objeto en el Canvas
        /// </summary>
        /// <param name="left">alineacion desde la izquierda a la derecha</param>
        /// <param name="top">alineacion desde arriba hacia abajo</param>
        public void Posicion(int left, int top)
        {
            Left = left;
            Top = top;
        }
        public Ficha(int size)
        {
            Size = size;
        }
        public Ficha(DeColor nuevoColor, int size)
        {
            Color = nuevoColor;
            Size = size;
        }
        public Ficha(DeColor nuevoColor)
        {
            Color = nuevoColor;
        }
        public Ficha()
        {
        }

        public Ellipse Circulo
        {
            get { return _circulo; }
            set { _circulo = value; }
        }

        public int Top
        {
            get { return _top; }
            set { _top = value; }
        }
        public int Size
        {
            get { return _size; }
            set { _size = value; }
        }
        public int Left
        {
            get { return _left; }
            set { _left = value; }
        }
        
        public DeColor Color
        {
            get { return _color; }
            set { _color = value; }
        }


    }
}
