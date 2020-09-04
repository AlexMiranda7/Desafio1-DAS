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
    /// Interaction logic for USCEstadisticas.xaml
    /// </summary>
    public partial class USCEstadisticas : UserControl
    {
        public USCEstadisticas()
        {
            InitializeComponent();
        }

        private void lstserie_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            /*Se crea variable que identifique la seleccion*/
            int index = lstserie.SelectedIndex;
            MoveEtiquetaMenu(index); /*Permite identificar la seleccion para utlizarse en el marcador*/

            /*Se crean los casos de lo que se mostrar en el InPanelSecondary segun la seleccion*/
            switch (index)
            {
                case 0:
                    GridInPanelSecondary.Children.Clear(); /*Se limpia el stack secundario*/
                    GridInPanelSecondary.Children.Add(new USCDEstadisticasEstretenimiento()); /*Se llama a la otra pestaña, en este caso USCD-GOT*/
                    break;

                case 1:
                    GridInPanelSecondary.Children.Clear();
                    GridInPanelSecondary.Children.Add(new USCDEstadisticasLibros());
                    break;

                case 2:
                    GridInPanelSecondary.Children.Clear();
                    GridInPanelSecondary.Children.Add(new USCDEstadisticasLenguages());
                    break;

                default:
                    break;
            }
        }
        private void MoveEtiquetaMenu(int index)
        {
            eti.OnApplyTemplate();
            GridEti.Margin = new Thickness(0, (25 + (42 * index)), 0, (340 - (42 * index)));
        }
    }
}
