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
using Vehiculos;
using Graph;

namespace wpfVehiculo
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int Capacity, Content, Performance, Distance;
        Automovil auto = new Automovil();
        Grafica graph = new Grafica();
        public MainWindow()
        {
            InitializeComponent();
            lblSalida.Content = "Ingrese Capacidad Estanque";
        }

        // Validation
        private void txtCapacidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (int.TryParse(txtCapacidad.Text, out Capacity))
                {
                    txtCapacidad.IsEnabled = false;
                    txtContenido.IsEnabled = true;
                    txtContenido.Focus();
                    auto.Capacidad = Capacity;
                    lblSalida.Content = "Ingrese Contenido Estanque";
                }
                else
                {
                    MessageBox.Show("Capacidad estanque debe ser numerico mayor que 0.");
                    txtCapacidad.Clear();
                }
            }
        } // end of txtCapacidad_KeyDown

        private void txtContenido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (int.TryParse(txtContenido.Text, out Content))
                {
                    if (Content > Capacity)
                    {
                        MessageBox.Show("Contenido no puede ser mayor que capacidad del estanque");
                        txtContenido.Clear();
                    }
                    else
                    {
                        txtContenido.IsEnabled = false;
                        txtRendimiento.IsEnabled = true;
                        txtRendimiento.Focus();
                        auto.Contenido = Content;
                        lblSalida.Content = "Ingrese Rendimiento por Litro";
                    }
                }
                else
                {
                    MessageBox.Show("Contenido estanque debe ser numerico mayor que 0.");
                    txtContenido.Clear();
                }
            }
        } // end of txtContenido_KeyDown

        private void txtRendimiento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (int.TryParse(txtRendimiento.Text, out Performance))
                {
                    txtRendimiento.IsEnabled = false;
                    btnCalcular.IsEnabled = true;
                    btnViajar.IsEnabled = true;
                    btnCalcular.Focus();
                    auto.Rendimiento = Performance;
                    lblSalida.Content = "Calcule Estado Actual";
                }
                else
                {
                    MessageBox.Show("Rendimiento por Litro debe ser numerico mayor que 0.");
                    txtRendimiento.Clear();
                }
            }
        } // end of txtRendimiento_KeyDown


        // setea valores a 0 y resetea botones y cuadros de texto
        private void btnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            txtCapacidad.IsEnabled = true;
            txtContenido.IsEnabled = false;
            txtRendimiento.IsEnabled = false;
            txtViajar.IsEnabled = false;
            btnCalcular.IsEnabled = false;
            btnViajar.IsEnabled = false;
            btnLlenar.IsEnabled = false;
            auto.Rendimiento = 0;
            auto.Contenido = 0;
            auto.Capacidad = 0;
            graph.Put(Fabric, auto);
        }

        private void btnTodo_Click(object sender, RoutedEventArgs e)
        {
            auto.Capacidad = Capacity;
            auto.Contenido = Content;
            auto.Rendimiento = Performance;
            txtViajar.IsEnabled = true;
            btnLlenar.IsEnabled = true;
            btnCalcular.IsEnabled = false;
            lblSalida.Content = "Autonomia Actual: " + auto.Autonomia() + " Kilometros";
            graph.Put(Fabric, auto);
        } // end of btnLimpiar_Click

        private void btnViajar_Click(object sender, RoutedEventArgs e)
        {
            int Distance;
            double Restante;
            if (int.TryParse(txtViajar.Text, out Distance))
            {
                Restante = auto.Viajar(Distance);
                btnViajar.Focus();
                if (Restante < 0)
                {
                    MessageBox.Show("Combustible insuficiente favor llene el tanque." + Restante);
                    btnLlenar.Focus();
                    txtViajar.Clear();
                }
                else
                {
                    auto.Contenido = Restante;
                    MessageBox.Show("Viaje Realizado, litros restantes : " + auto.Contenido );
                    lblSalida.Content = "Viaje Realizado, litros restantes : " + auto.Contenido;
                    auto.Contenido = Restante;
                }
            }
            else
            {
                MessageBox.Show("Distancia debe ser numerico mayor que 0.");
                txtViajar.Clear();
            }
            graph.Put(Fabric, auto);

        } // end of btnViajar_Click

        private void btnLlenar_Click(object sender, RoutedEventArgs e)
        {
            Content = Capacity;
            auto.Contenido = Capacity;
        } // end of btnLlenar_Click







    } //  end of public partial class MainWindow : Window
} // end of namespace wpfVehiculo
