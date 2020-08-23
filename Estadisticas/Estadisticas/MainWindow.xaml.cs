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

namespace Estadisticas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string[,] login = { { "rmiranda", "rvillalta" }, {"$3nt!n3la","ingreso20" } };
        int intentos = 0;
        public MainWindow()
        {
            System.Threading.Thread.Sleep(300);
            InitializeComponent();
        }

        private void Button_ColorChanged(object sender, RoutedPropertyChangedEventArgs<Color> e)
        {

        }

        private void btningresar_Click(object sender, RoutedEventArgs e)
        {
            int j;
            for (j = 0; j < 4; j++)
            {
                if (txtusuario.Text != login[0, j] && pst.Password != login[1, j])
                {
                    j++;
                }
                if (txtusuario.Text == login[0, j] && pst.Password == login[1, j])
                {
                    this.Hide();
                    InPanel i = new InPanel();
                    i.Show(); break;
                }
                if (intentos == 3)
                {
                    MessageBox.Show("Has alcanzado el numero maximo de intentos, cerrando sistema", "Mensaje del sistema", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    intentos++;
                    MessageBox.Show("Error de autenticacion, verifique usuario y/O contraseña ó es posible que su cuenta este inhabilitada", "Mensaje del sistema", MessageBoxButton.OK, MessageBoxImage.Information);
                    txtusuario.Clear();
                    pst.Clear();
                    break;
                }

            }            
          
        }
    }
}
