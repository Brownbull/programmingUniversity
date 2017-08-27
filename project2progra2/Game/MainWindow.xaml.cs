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
using lib;

namespace Game
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int CurrentPlayer = 0, winScore = 24;
        int rolldice1 = 0, rolldice2 = 0;
        int Next = 0;
        Dado dado1 = new Dado();
        Dado dado2 = new Dado();
        Ficha ficha1sapo = new Ficha(0, "sapo");
        Ficha ficha1tortuga = new Ficha(0, "tortuga");
        Ficha ficha2sapo = new Ficha(0, "sapo");
        Ficha ficha2tortuga = new Ficha(0, "tortuga");

        public MainWindow()
        {
            InitializeComponent();
            Initialize();
            System.Windows.MessageBox.Show("Bienvenido a Sapos y Tortugas \n El objetivo del juego es llevar ambas piezas mas alla del final del tablero, esto es la casilla 24! \n El Sapo se movera el doble de la suma de los 2 dados!\n La Tortuga solo ira adelante el menor de los numeros obtenidos en los dados!\n Good Luck!");
            do
            {
                CurrentPlayer = WhoStarts();
            } while (CurrentPlayer == 0);

            PlayPlayer(CurrentPlayer);

        } // end of public MainWindow()

        private void PlayPlayer(int CurrentPlayer)
        {
            if (CurrentPlayer == 1)
            {
                ActivePlayer(1);
                DeactivePlayer(2);
            }
            else
            {
                ActivePlayer(2);
                DeactivePlayer(1);
            }
        } // end of private void PlayPlayer(int turn)

        private void ActivePlayer(int Player)
        {
            btnDado1.IsEnabled = true;
            btnDado2.IsEnabled = true;
            lblDado1.Content = "";
            lblDado2.Content = "";
            if (Player == 1)
            {
                lblStatus1.Content = "Your Turn!";
                btnSapo1.IsEnabled = true;
                btnTortuga1.IsEnabled = true;
                rolldice1 = 0;
            }
            else
            {
                lblStatus2.Content = "Your Turn!";
                btnSapo2.IsEnabled = true;
                btnTortuga2.IsEnabled = true;
                rolldice2 = 0;
            }
        }

        private void DeactivePlayer(int Player)
        {
            Next = 0;
            if (Player == 2)
            {
                btnSapo2.IsEnabled = false;
                btnTortuga2.IsEnabled = false;
                rolldice2 = -1;
                lblStatus2.Content = "Waiting...";
            }
            else
            {
                btnSapo1.IsEnabled = false;
                btnTortuga1.IsEnabled = false;
                rolldice1 = -1;
                lblStatus1.Content = "Waiting...";
            }
        }

        // Click on Dado 1
        private void btnDado1_Click(object sender, RoutedEventArgs e)
        {
            dado1.Roll();
            System.Windows.MessageBox.Show(dado1.Value + " Obtained!");
            lblDado1.Content = dado1.Value;
            btnDado1.IsEnabled = false;
            rolldice1 = 1;
        }

        public void Initialize()
        {
            btnSapo1.IsEnabled = false;
            btnSapo2.IsEnabled = false;
            btnTortuga1.IsEnabled = false;
            btnTortuga2.IsEnabled = false;
        }

        private void btnSapo1_Click(object sender, RoutedEventArgs e)
        {
            if ((rolldice1 == 1) && (rolldice2 == 1))
            {
                ficha1sapo.Move(dado1.Value, dado2.Value);
                lblPositionSapo1.Content = ficha1sapo.Position;
                CurrentPlayer = 2;
                Next = 1;
                if ((ficha1sapo.Position >= winScore) && (ficha1tortuga.Position >= winScore))
                {
                    System.Windows.MessageBox.Show("Player 1 Win!");
                    Application.Current.Shutdown();
                }
                else
                {
                    PlayPlayer(CurrentPlayer);
                }
            }
            else
            { System.Windows.MessageBox.Show("Roll both Dices please!"); }
        }

        private void btnTortuga1_Click(object sender, RoutedEventArgs e)
        {
            if ((rolldice1 == 1) && (rolldice2 == 1))
            {
                ficha1tortuga.Move(dado1.Value, dado2.Value);
                lblPosotonTortuga1.Content = ficha1tortuga.Position;
                CurrentPlayer = 2;
                Next = 1;
                if ((ficha1sapo.Position >= winScore) && (ficha1tortuga.Position >= winScore))
                {
                    System.Windows.MessageBox.Show("Player 1 Win!");
                    Application.Current.Shutdown();
                }
                else
                {
                    PlayPlayer(CurrentPlayer);
                }
            }
            else
            { System.Windows.MessageBox.Show("Roll both Dices please!"); }
        }

        private void btnSapo2_Click(object sender, RoutedEventArgs e)
        {
            if ((rolldice1 == 1) && (rolldice2 == 1))
            {
                ficha2sapo.Move(dado1.Value, dado2.Value);
                lblPositionSapo2.Content = ficha2sapo.Position;
                CurrentPlayer = 1;
                Next = 1;
                if ((ficha1sapo.Position >= winScore) && (ficha1tortuga.Position >= winScore))
                {
                    System.Windows.MessageBox.Show("Player 2 Win!");
                    Application.Current.Shutdown();
                }
                else
                {
                    PlayPlayer(CurrentPlayer);
                }
            }
            else
            { System.Windows.MessageBox.Show("Roll both Dices please!"); }
        }

        private void btnTortuga2_Click(object sender, RoutedEventArgs e)
        {
            if ((rolldice1 == 1) && (rolldice2 == 1))
            {
                ficha2tortuga.Move(dado1.Value, dado2.Value);
                lblPosotonTortuga2.Content = ficha2tortuga.Position;
                CurrentPlayer = 1;
                Next = 1;
                if ((ficha1sapo.Position >= winScore) && (ficha1tortuga.Position >= winScore))
                {
                    System.Windows.MessageBox.Show("Player 2 Win!");
                    Application.Current.Shutdown();
                }
                else
                {
                    PlayPlayer(CurrentPlayer);
                }
            }
            else
            { System.Windows.MessageBox.Show("Roll both Dices please!"); }
        }

        // Click on Dado 2
        private void btnDado2_Click(object sender, RoutedEventArgs e)
        {
            dado2.Roll();
            System.Windows.MessageBox.Show(dado2.Value + " Obtained!");
            lblDado2.Content = dado2.Value;
            btnDado2.IsEnabled = false;
            rolldice2 = 1;
        }

        // Initial step to decide who starts
        public int WhoStarts()
        {
            System.Windows.MessageBox.Show("Player 1 Roll!");
            dado1.Roll();
            System.Windows.MessageBox.Show(dado1.Value + " Obtained!");
            System.Windows.MessageBox.Show("Player 2 Roll!");
            dado2.Roll();
            System.Windows.MessageBox.Show(dado2.Value + " Obtained!");

            if (dado1.Value > dado2.Value)
            {
                System.Windows.MessageBox.Show("Player 1 Starts!");
                return 1;
            }
            else if (dado1.Value < dado2.Value)
            {
                System.Windows.MessageBox.Show("Player 2 Starts!");
                return 2;
            }
            else
            {
                System.Windows.MessageBox.Show("Draw! Try Again!");
                return 0;
            }
    
        } //  end of public int WhoStarts()

    } //  end of public partial class MainWindow : Window
}
