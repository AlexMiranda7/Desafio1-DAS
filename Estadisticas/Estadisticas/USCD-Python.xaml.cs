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
    /// Interaction logic for USCDPython.xaml
    /// </summary>
    public partial class USCDPython : UserControl
    {
        string[] PythonInfo = new string[]
       {
            "Desarrolladores: Python Software Foundation", "Extensiones: .py, .pyc, .pyd, .pyo, .pyw, .pyz",
            "Apareció en: 1991", "Sistema Operativo: Multiplataforma",
             "Paradigma: Orientado a Objetos, funcional, Imperativo.", "Última versión estable: 3.8.5",
            "Licencia: Python Software Foundation License"
       };
        public USCDPython()
        {
            InitializeComponent();
            Desarroladores.Text = PythonInfo[0];
            Extensiones.Text = PythonInfo[1];
            Aparecio.Text = PythonInfo[2];
            OS.Text = PythonInfo[3];
            Paradigma.Text = PythonInfo[4];
            Version.Text = PythonInfo[5];
            Licencia.Text = PythonInfo[6];
        }
    }
}
