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
    /// Interaction logic for USCD_GOT.xaml
    /// </summary>
    public partial class USCD_GOT : UserControl
    {
        string[] GotInfo = new string[]
        {
            "Título: Juego de tronos", "Creador: David Benioff, D. B. Weiss.",
            "Protagonistas: Sean Bean Nikolaj, Coster-Waldau, Peter Dinklag,e Emilia Clarke, Lena Headey, Iain Glen, Kit Harington, Sophie Turner, Maisie Williams, Isaac Hempstead, Natalie Dormer",
            "País de origen: Estados Unidos", "Temporadas: 8", "Episodios: 73",
            "Sinopsis: La trama de Game of Thrones está basada en la serie de novelas Canción de hielo y fuego, y relata las vivencias de un grupo de personajes de distintas casas nobiliarias en el continente ficticio Poniente para tener el control del Trono de Hierro y gobernar los siete reinos que conforman el territorio."
        };
        public USCD_GOT()
        {
            InitializeComponent();
            Titulo.Text = GotInfo[0];
            Creador.Text = GotInfo[1];
            Protagonistas.Text = GotInfo[2];
            Pais.Text = GotInfo[3];
            Temporadas.Text = GotInfo[4];
            Episodios.Text = GotInfo[5];
            Sinopsis.Text = GotInfo[6];
        }

    }
}
