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
using System.Reflection;

namespace WPFProyectoFinal
{
    /// <summary>
    /// Lógica de interacción para PaginasActual.xaml
    /// </summary>
    public partial class PaginasActual : Page
    {
        public PaginasActual()
        {
            InitializeComponent();
            web1AppNew.Navigate("https://www.lavanguardia.com/ciencia/20190424/461846301188/sintetizador-voz-convierte-pensamiento-habla.html");
            HideScriptErrors(web1AppNew, true);
            web2Microsoft.Navigate("https://www.lavanguardia.com/vida/20191212/472192692367/microsoft-desarrolla-un-nuevo-modelo-de-sintesis-de-habla-con-mejoras-en-el-rendimiento-al-reproducir-el-texto-a-voz.html");
            HideScriptErrors(web2Microsoft, true);
            web3Android.Navigate("https://www.emezeta.com/articulos/10-sintetizadores-de-voz-tts-para-android");
            HideScriptErrors(web3Android, true);
        }

        public void HideScriptErrors(WebBrowser wb, bool hide)
        {
            var fiComWebBrowser = typeof(WebBrowser).GetField("_axIWebBrowser2", BindingFlags.Instance | BindingFlags.NonPublic);
            if (fiComWebBrowser == null) return;
            var objComWebBrowser = fiComWebBrowser.GetValue(wb);
            if (objComWebBrowser == null)
            {
                wb.Navigated += (o, s) => HideScriptErrors(wb, hide);
                return;
            }
            objComWebBrowser.GetType().InvokeMember("Silent", BindingFlags.SetProperty, null, objComWebBrowser, new object[] { hide });
        }
    }
}
