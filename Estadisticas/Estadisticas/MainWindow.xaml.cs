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
        
        
        public MainWindow()
        {
            System.Threading.Thread.Sleep(15000); /*Corregir a 15000 antes de entregar*/
            InitializeComponent();
        }

        private void Button_ColorChanged(object sender, RoutedPropertyChangedEventArgs<Color> e)
        {

        }

        private void btningresar_Click(object sender, RoutedEventArgs e)
        {
            string[] Usuario = {"rmiranda","rvillalta","test","prueba","Valhala" };
            string[] Pass = { "rm#2019", "rv#2020", "1020304050", "12345", "odin" };
            int intentos = 0;

            if (Usuario.Contains(txtusuario.Text) && Pass.Contains(pst.Password) && Array.IndexOf(Usuario,txtusuario.Text) == Array.IndexOf(Pass,pst.Password))
            {
                this.Hide();
                InPanel i = new InPanel();
                i.Show(); 
            }
            
            else
            {
                intentos++;
                MessageBox.Show("Error de autenticacion, verifique usuario y/O contraseña ó es posible que su cuenta este inhabilitada", "Mensaje del sistema", MessageBoxButton.OK, MessageBoxImage.Information);
                txtusuario.Clear();
                pst.Clear();
            }

        }
    }
}
