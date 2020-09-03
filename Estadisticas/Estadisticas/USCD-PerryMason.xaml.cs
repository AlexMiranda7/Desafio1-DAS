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
    /// Interaction logic for USCDPerryMason.xaml
    /// </summary>
    public partial class USCDPerryMason : UserControl
    {
        string[] ParryMandonInfo = new string[]
       {
            "Título: Perry Manson", "Autor: Erle Stanley Gardner",
            "Protagonistas: Perry Manson", "Antagonistas: Diversos",
             "Genero: Policiaco", "Sugéneros: Suspenso, Investigación",
            "Sinopsis: El personaje era un abogado que llegó a aparecer en 80 novelas e historias cortas, la mayoría de las cuales versaban sobre la defensa de un cliente que había sido acusado de asesinato. En general, Perry Mason era capaz de demostrar la inocencia de su cliente mediante la averiguación de la culpabilidad del verdadero asesino, otro personaje de la historia."
       };
        public USCDPerryMason()
        {
            InitializeComponent();
            Titulo.Text = ParryMandonInfo[0];
            Autor.Text = ParryMandonInfo[1];
            Protagonistas.Text = ParryMandonInfo[2];
            Antagonistas.Text = ParryMandonInfo[3];
            Genero.Text = ParryMandonInfo[4];
            Subgeneros.Text = ParryMandonInfo[5];
            Sinopsis.Text = ParryMandonInfo[6];
        }
    }
}
