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
    /// Interaction logic for USCLenguajes.xaml
    /// </summary>
    public partial class USCLenguajes : UserControl
    {
        public USCLenguajes()
        {
            InitializeComponent();
        }
        private void lstlenguajes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            /*Se crea variable que identifique la seleccion*/
            int index = lstlenguajes.SelectedIndex;

            /*Se crean los casos de lo que se mostrar en el InPanelSecondary segun la seleccion*/
            switch (index)
            {
                case 0:
                    GridInPanelSecondary.Children.Clear(); /*Se limpia el stack secundario*/
                    GridInPanelSecondary.Children.Add(new USCDPython()); /*Se llama a la otra pestaña, en este caso USCD-GOT*/
                    break;

                case 1:
                    GridInPanelSecondary.Children.Clear();
                    GridInPanelSecondary.Children.Add(new USCD_Java());
                    break;

                case 2:
                    GridInPanelSecondary.Children.Clear();
                    GridInPanelSecondary.Children.Add(new USCD_JS());
                    break;

                default:
                    break;
            }
        }
    }
}
