using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Ejercicio;

namespace Graphics
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnLTMin_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnLTMax_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnMTMin_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnMTMax_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnBetween_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnTodo_Click(object sender, RoutedEventArgs e)
        {
            int alumnos = int.Parse(txtAlumnos.Text);
            double Min = double.Parse(txtMin.Text);
            double Max = double.Parse(txtMax.Text);
            Curso curso = new Curso(alumnos);
            Grafica graph = new Grafica();
            graph.PintarTodo(Fabric, curso, Min, Max);

            
        }
    }
}
