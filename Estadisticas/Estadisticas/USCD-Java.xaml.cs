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
    public partial class USCD_Java : UserControl
    {
        string[] JavaInfo = new string[]
      {
            "Desarrolladores: Oracle Corporation", "Extensiones: .jar, .class, .jad",
            "Apareció en: 1995", "Sistema Operativo: Multiplataforma",
             "Paradigma: Orientado a Objetos.", "Última versión estable: 3.8.5",
            "Licencia: GPL"
      };
        public USCD_Java()
        {
            InitializeComponent();
            Desarroladores.Text = JavaInfo[0];
            Extensiones.Text = JavaInfo[1];
            Aparecio.Text = JavaInfo[2];
            OS.Text = JavaInfo[3];
            Paradigma.Text = JavaInfo[4];
            Version.Text = JavaInfo[5];
            Licencia.Text = JavaInfo[6];
        }
    }
}
