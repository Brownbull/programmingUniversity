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
using Equation;

namespace EqPanel
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Eq Eq = new Eq();
        float valueA, valueB, valueC;
        int signA, signB, signC;
        public MainWindow()
        {
            InitializeComponent();
        }



        private void boxSymbolA_Initialized(object sender, EventArgs e)
        {
            boxSymbolA.Items.Add("+");
            boxSymbolA.Items.Add("-");
            boxSymbolA.SelectedIndex = 0;
        }

        private void boxSymbolB_Initialized(object sender, EventArgs e)
        {
            boxSymbolB.Items.Add("+");
            boxSymbolB.Items.Add("-");
            boxSymbolB.SelectedIndex = 0;
        }

        private void boxSymbolC_Initialized(object sender, EventArgs e)
        {
            boxSymbolC.Items.Add("+");
            boxSymbolC.Items.Add("-");
            boxSymbolC.SelectedIndex = 0;
        }

        private void txtFactorA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (float.TryParse(txtFactorA.Text, out valueA))
                {
                    txtFactorA.IsEnabled = false;
                    txtFactorB.IsEnabled = true;
                    txtFactorB.Focus();
                    Eq.FactorA = valueA;
                }
                else
                {
                    MessageBox.Show("Valor debe ser numerico.");
                    txtFactorA.Clear();
                }
            }
        }

        private void txtFactorB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (float.TryParse(txtFactorB.Text, out valueB))
                {
                    txtFactorB.IsEnabled = false;
                    txtFactorC.IsEnabled = true;
                    txtFactorC.Focus();
                    Eq.FactorB = valueB;
                }
                else
                {
                    MessageBox.Show("Valor debe ser numerico.");
                    txtFactorB.Clear();
                }
            }
        }

        private void txtFactorC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (float.TryParse(txtFactorC.Text, out valueC))
                {
                    txtFactorC.IsEnabled = false;
                    txtXFirstvalue.IsEnabled = true;
                    txtXFirstvalue.Focus();
                    Eq.FactorC = valueC;
                }
                else
                {
                    MessageBox.Show("Valor debe ser numerico.");
                    txtFactorC.Clear();
                }
            }
        }
    }
}
