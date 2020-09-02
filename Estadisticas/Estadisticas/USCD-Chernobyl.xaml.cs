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
    /// Interaction logic for USCD_Chernobyl.xaml
    /// </summary>
    public partial class USCD_Chernobyl : UserControl
    {
        string[] ChernobylInfo = new string[]
        {
            "Título: Chernónil", "Creador: Craig Mazin.",
            "Protagonistas: Jared Harris Stellan Skarsgård Emily Watson.",
            "País de origen: Estados Unidos - Reino Unido", "Temporadas: 1", "Episodios: 5",
            "Sinopsis: La serie gira en torno al desastre nuclear de Chernóbil de abril de 1986 y los esfuerzos de limpieza sin precedentes que siguieron."
        };
        public USCD_Chernobyl()
        {
            InitializeComponent();
            Titulo.Text = ChernobylInfo[0];
            Creador.Text = ChernobylInfo[1];
            Protagonistas.Text = ChernobylInfo[2];
            Pais.Text = ChernobylInfo[3];
            Temporadas.Text = ChernobylInfo[4];
            Episodios.Text = ChernobylInfo[5];
            Sinopsis.Text = ChernobylInfo[6];
        }
    }
}
