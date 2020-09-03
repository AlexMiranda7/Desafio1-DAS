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
    /// Interaction logic for USCD_JS.xaml
    /// </summary>
    public partial class USCD_JS : UserControl
    {
        string[] JSInfo = new string[]
       {
            "Desarrolladores: ECMA international", "Extensiones: .js",
            "Apareció en: 1995", "Sistema Operativo: Multiplataforma, maquina virtual JS",
             "Paradigma: Prototipado, funcional, Imperativo.", "Última versión estable: ECMAScript2020",
            "Licencia:  Creative Commons Attribution-ShareAlike License"
       };
        public USCD_JS()
        {
            InitializeComponent();
            Desarroladores.Text = JSInfo[0];
            Extensiones.Text = JSInfo[1];
            Aparecio.Text = JSInfo[2];
            OS.Text = JSInfo[3];
            Paradigma.Text = JSInfo[4];
            Version.Text = JSInfo[5];
            Licencia.Text = JSInfo[6];
        }
    }
}
