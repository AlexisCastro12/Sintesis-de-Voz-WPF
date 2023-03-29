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
    /// Lógica de interacción para ProcesoTexto.xaml
    /// </summary>
    public partial class ProcesoTexto : Page
    {
        public ProcesoTexto()
        {
            InitializeComponent();
        }

        private void ImgNormalizacion_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            TxtTituloSubproceso.Text = "NORMALIZACIÓN DEL TEXTO";
            TxtContenidoSubproceso.Text = "La normalización es el primer paso del procesamiento de texto, aquí se convierte la totalidad del texto a una forma textual convencional, lo anterior implica expandir abreviaciones, convertir números y fechas en texto, etc. Esta es una tarea importante ya que es necesario para el correcto funcionamiento de los siguientes módulos que el texto este constituido solamente por grafemas. En ocasiones se realiza también un etiquetado morfosintáctico, que resulta necesario para tareas como la conversión de grafemas a fonemas y la generación de junturas terminales en la prosodia.";
        }

        private void ImgFonetica_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            TxtTituloSubproceso.Text = "TRANSCRIPCIÓN FONÉTICA";
            TxtContenidoSubproceso.Text = "El segundo proceso del bloque de procesamiento de texto es la transcripción fonética, en esta se realiza la conversión de texto a grafemas y fonemas, así como también la silabificación para obtener la secuencia de fonemas necesaria para reproducir el texto, incluyendo la información sobre sílabas que también es importante para los siguientes módulos.";
        }
    }
}
