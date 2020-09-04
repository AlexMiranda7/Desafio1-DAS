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
using LiveCharts;
using LiveCharts.Wpf;

namespace Estadisticas
{
    /// <summary>
    /// Interaction logic for USCDPython.xaml
    /// </summary>
    public partial class USCDEstadisticasLenguages : UserControl
    {
       
        public USCDEstadisticasLenguages()
        {
            InitializeComponent();
            myPieChart.Series.Add(new LiveCharts.Wpf.PieSeries { Title = "Python", Fill = Brushes.Chocolate, StrokeThickness = 0, Values = new ChartValues<double> { 47.0 } });
            myPieChart.Series.Add(new LiveCharts.Wpf.PieSeries { Title = "Java", Fill = Brushes.DarkSeaGreen, StrokeThickness = 0, Values = new ChartValues<double> { 38.0 } });
            myPieChart.Series.Add(new LiveCharts.Wpf.PieSeries { Title = "Javascript", Fill = Brushes.Azure, StrokeThickness = 0, Values = new ChartValues<double> { 15.0 } });

            DataContext = this;
        }
    }
}
