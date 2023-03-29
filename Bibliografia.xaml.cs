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
    /// Lógica de interacción para Bibliografia.xaml
    /// </summary>
    public partial class Bibliografia : Window
    {
        public Bibliografia()
        {
            InitializeComponent();
        }

        private void ImgBib2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            TxtBib.Text = "Título: Tratamiento Digital de Voz e Imagen y Aplicación a la Multimedia\n\nAutor: Faundez, M.\n\nNúmero de Páginas: 288 páginas\n\nEditorial: Marcombo\n\nAño de Edición: 2000\n\n";
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

        private void ImgBib1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            TxtBib.Text = "Título: Formula.Cuadernos De Ciencias Físico-Químicas Y Matemáticas, No. 4\n\nAutor: Varona, A. [et al.]\n\nNúmero de Páginas: 321-346 páginas\n\nEditorial: Eusko Ikaskuntza\n\nAño de Edición: 1997\n\n";
        }

        private void ImgBib4_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            TxtBib.Text = "Título: ANÁLISIS Y RECONOCIMEINTO DE VOZ. Fundamentos y técnicas. \n\nAutor: Pajares, G. \n\nNúmero de Páginas: 132 páginas\n\nEditorial: Alfaomega, RC Libros \n\nAño de Edición: 2017 \n\n";
        }

        private void ImgBib3_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            TxtBib.Text = "Título: Sistema de Síntesis de Voz en Español de México. \n\nAutor: Franco, C. [et al.] \n\nNúmero de Páginas: 57 páginas\n\nEditorial: Académica Española \n\nAño de Edición: 2018\n\n";
        }
    }
}
