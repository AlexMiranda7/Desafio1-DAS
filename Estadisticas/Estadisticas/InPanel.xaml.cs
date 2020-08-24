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
using System.Windows.Shapes;

namespace Estadisticas
{
    /// <summary>
    /// Interaction logic for InPanel.xaml
    /// </summary>
    public partial class InPanel : Window
    {
        public InPanel()
        {
            InitializeComponent();
        }

        private void btnoff_Click(object sender, RoutedEventArgs e)
        {
           
            MessageBoxResult cierre = MessageBox.Show("¿Esta seguro de salir?", "Cierre de aplicación", MessageBoxButton.YesNo);
            if (cierre == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
            else
            {
               
            }
            
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void lstmenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = lstmenu.SelectedIndex;
            MoveEtiquetaMenu(index);

            switch (index)
            {
                case 0:

                    GridInPanel.Children.Clear();
                    GridInPanel.Children.Add(new USCInicio());
                    break;

                case 1:
                    GridInPanel.Children.Clear();
                    GridInPanel.Children.Add(new USCEntretenimiento());
                    break;

                case 2:
                    GridInPanel.Children.Clear();
                    GridInPanel.Children.Add(new USCLibros());
                    break;

                case 3:
                    GridInPanel.Children.Clear();
                    GridInPanel.Children.Add(new USCLenguajes());
                    break;

                default:
                    break;
            }
        }

        private void MoveEtiquetaMenu(int index)
        {
            etiqueta.OnApplyTemplate();
            GridEtiqueta.Margin = new Thickness(0,(75 +( 42* index)),0,(290-(42 * index)));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow i = new MainWindow();
            i.Show();
        }
    }
}
