using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.DataVisualization.Charting;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using LiveCharts;
using LiveCharts.Wpf;

namespace Estadisticas
{
    /// <summary>
    /// Interaction logic for USCDPython.xaml
    /// </summary>
    public partial class USCDEstadisticasEstretenimiento : UserControl
    {
       
        public USCDEstadisticasEstretenimiento()
        {
            InitializeComponent();
            myPieChart.Series.Add(new LiveCharts.Wpf.PieSeries { Title = "Juego de Tronos", Fill = Brushes.Chocolate, StrokeThickness = 0, Values = new ChartValues<double> { 40.0 } });
            myPieChart.Series.Add(new LiveCharts.Wpf.PieSeries { Title = "Chernóbil", Fill = Brushes.DarkSeaGreen, StrokeThickness = 0, Values = new ChartValues<double> { 34.0 } });
            myPieChart.Series.Add(new LiveCharts.Wpf.PieSeries { Title = "La maravillosa Señora Maisel", Fill = Brushes.Azure, StrokeThickness = 0, Values = new ChartValues<double> { 26.0 } });

            DataContext = this;
        }
    }
}
