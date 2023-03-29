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
using System.Windows.Shapes;

namespace WPFProyectoFinal
{
    /// <summary>
    /// Lógica de interacción para Funcionamiento.xaml
    /// </summary>
    public partial class Funcionamiento : Window
    {
        public Funcionamiento()
        {
            InitializeComponent();
        }

        private void MenuRegresar_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void MenuSalir_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void MenuFirma_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("Castro.exe");
        }

        private void BtnProcesamiento_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            FrameFuncionamiento.NavigationService.Navigate(new ProcesoTexto());
        }

        private void BtnProsodia_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            FrameFuncionamiento.NavigationService.Navigate(new Prosodia());
        }

        private void BtnVoz_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            FrameFuncionamiento.NavigationService.Navigate(new VozArtificial());
        }

        private void MenuBiblio_Click(object sender, RoutedEventArgs e)
        {
            Bibliografia Bib = new Bibliografia();
            Bib.ShowDialog();
        }
    }
}
