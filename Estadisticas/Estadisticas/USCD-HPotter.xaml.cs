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
    /// Interaction logic for USCDHPotter.xaml
    /// </summary>
    public partial class USCDHPotter : UserControl
    {
        string[] PotterInfo = new string[]
       {
            "Título: Harry Potter", "Autor: J. K. Rowling",
            "Protagonistas:Harry Potter, Ron weasley, Hermione Granger, Ginny Weasley, Neville Longbottom, Albus Dumbledore",
            "Antagonistas: Lord Voldemort, Mortífagos", "Género: Novela", "Subgéneros: fantástica, juvenil...",
            "Sinopsis: La historia comienza con la celebración del mundo mágico. Durante muchos años, había sido aterrorizado por el malvado mago Lord Voldemort. La noche del 31 de octubre, mató a Lily y James Potter. Sin embargo, cuando intenta matar a su hijo de 1 año, Harry, la maldición asesina Avada Kedavra se vuelve sobre sí mismo. El cuerpo de Voldemort resulta destruido, pero él sobrevive: no está muerto ni vivo. Por su parte, a Harry solo le queda una cicatriz con forma de rayo en la frente que es el único remanente físico de la maldición de Voldemort. Harry es el único sobreviviente de la maldición asesina, y a raíz de la misteriosa derrota de Voldemort, el mundo mágico empieza a llamarlo como \"el niño que sobrevivió\""
       };
        public USCDHPotter()
        {
            InitializeComponent();
            Titulo.Text = PotterInfo[0];
            Autor.Text = PotterInfo[1];
            Protagonistas.Text = PotterInfo[2];
            Antagonistas.Text = PotterInfo[3];
            Genero.Text = PotterInfo[4];
            Subgeneros.Text = PotterInfo[5];
            Sinopsis.Text = PotterInfo[6];
        }
    }
}
