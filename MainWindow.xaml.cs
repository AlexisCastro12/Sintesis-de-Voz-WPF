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

namespace WPFProyectoFinal
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuFirma_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("Castro.exe");
        }

        private void MenuSalir_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void BtnSeleccion_Click(object sender, RoutedEventArgs e)
        {
            if (RbtnOpc1.IsChecked == true)
            {
                ConcyDef Ventana1 = new ConcyDef();
                Ventana1.ShowDialog();
            }
            if (RbtnOpc2.IsChecked == true)
            {
                Evolucion Ventana2 = new Evolucion();
                Ventana2.ShowDialog();
            }
            if (RbtnOpc3.IsChecked == true)
            {
                Funcionamiento Ventana3 = new Funcionamiento();
                Ventana3.ShowDialog();
            }
            if (RbtnOpc4.IsChecked == true)
            {
                Aplicacion App1 = new Aplicacion();
                App1.ShowDialog();
            }
        }

        private void MenuBiblio_Click(object sender, RoutedEventArgs e)
        {
            Bibliografia Bib = new Bibliografia();
            Bib.ShowDialog();
        }
    }
}
