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
    /// Interaction logic for USCDGoose.xaml
    /// </summary>
    public partial class USCDGoose : UserControl
    {
        string[] GooseInfo = new string[]
       {
            "Título: Pesadillas", "Autor: Robert Lawrence Stine", 
            "Protagonistas: Diversos", "Antagonistas: Moustros y situaciones adversos",
             "Genero: Ficción, Infantil", "Sugéneros: Terror, Suspenso",
            "Sinopsis: La serie consta de un total de 60 libros para España, el último de los cuales (Sangre de monstruo IV) se publicó en 1999, mientras que en Hispanoamérica consta de 45 historias. El nombre se tradujo en España como Pesadillas y en Hispanoamérica como Escalofríos."
       };
        public USCDGoose()
        {
            InitializeComponent();
            Titulo.Text = GooseInfo[0];
            Autor.Text = GooseInfo[1];
            Protagonistas.Text = GooseInfo[2];
            Antagonistas.Text = GooseInfo[3];
            Genero.Text = GooseInfo[4];
            Subgeneros.Text = GooseInfo[5];
            Sinopsis.Text = GooseInfo[6];
        }
    }
}
