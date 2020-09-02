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
    /// Interaction logic for USCD_TMS.xaml
    /// </summary>
    public partial class USCD_TMS : UserControl
    {
        string[] TmsInfo = new string[]
        {
            "Título: La maravillosa Señora Maisel", "Creadores: Amy Sherman-Palladino.",
            "Protagonistas: Rachel Brosnahan, Michael Zegen, Alex Borstein, Tony Shalhoub, Marin Hinkle",
            "País de origen: Estados Unidos", "Temporadas: 3", "Episodios: 26",
            "Sinopsis: La serie cuenta la historia de un ama de casa en Nueva York que descubre que tiene una habilidad especial para la comedia en vivo. El primer episodio se estrenó como parte de la temporada de pilotos de primavera de Amazon Studios el 17 de marzo de 2017, recibiendo la aclamación de la crítica."
        };
        public USCD_TMS()
        {
            InitializeComponent();
            Titulo.Text = TmsInfo[0];
            Creador.Text = TmsInfo[1];
            Protagonistas.Text = TmsInfo[2];
            Pais.Text = TmsInfo[3];
            Temporadas.Text = TmsInfo[4];
            Episodios.Text = TmsInfo[5];
            Sinopsis.Text = TmsInfo[6];
        }
    }
}
