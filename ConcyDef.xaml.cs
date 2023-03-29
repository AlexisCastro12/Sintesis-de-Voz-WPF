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
    /// Lógica de interacción para ConcyDef.xaml
    /// </summary>
    public partial class ConcyDef : Window
    {
        public ConcyDef()
        {
            InitializeComponent();
        }

        private void MenuFirma_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("Castro.exe");
        }

        private void MenuRegresar_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void MenuSalir_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void BtnDef_Click(object sender, RoutedEventArgs e)
        {
            FrameWin1.NavigationService.Navigate(new Def());
        }

        private void BtnPar_Click(object sender, RoutedEventArgs e)
        {
            FrameWin1.NavigationService.Navigate(new Calidad());
        }

        private void BtnDif_Click(object sender, RoutedEventArgs e)
        {
            FrameWin1.NavigationService.Navigate(new Diferencias());
        }

        private void MenuBiblio_Click(object sender, RoutedEventArgs e)
        {
            Bibliografia Bib = new Bibliografia();
            Bib.ShowDialog();
        }
    }
}
