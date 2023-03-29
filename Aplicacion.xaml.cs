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
using System.Speech.Synthesis;

namespace WPFProyectoFinal
{
    /// <summary>
    /// Lógica de interacción para Aplicacion.xaml
    /// </summary>
    public partial class Aplicacion : Window
    {
        private SpeechSynthesizer Sintetizador = new SpeechSynthesizer();
        private List<VoiceInfo> TiposDeVoces = new List<VoiceInfo>();
        private int SeleccionVoz;

        public Aplicacion()
        {
            InitializeComponent();
            foreach (InstalledVoice voice in Sintetizador.GetInstalledVoices()) //Cargamos los tipos de voces que nos ofrece el ordenador
            {
                TiposDeVoces.Add(voice.VoiceInfo);
                CmbxVoces.Items.Add(voice.VoiceInfo.Name);
            }
            CmbxVoces.SelectedIndex = 0;    //Inicializamos por defecto con la el tipo de voz registrado como 0
        }

        private void MenuFirma_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("Castro.exe");
        }

        private void MenuSalir_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void MenuRegresar_Click(object sender, RoutedEventArgs e)
        {
            Close();
            Sintetizador.Dispose(); //Elimina los recursos de Síntesis utilizados en la aplicación
        }

        private void BtnIniciar_Click(object sender, RoutedEventArgs e)
        {
            SeleccionVoz = CmbxVoces.SelectedIndex;
            Sintetizador.SelectVoice(TiposDeVoces.ElementAt(SeleccionVoz).Name);  //Cargamos la voz seleccionada para trabajar en el Combobox
            Sintetizador.Rate = int.Parse(TxtRate.Text);        //Cargamos la velocidad
            Sintetizador.Volume = int.Parse(TxtVol.Text);       //Cargamos el Volumen

            if (Sintetizador.State.ToString() == "Paused")
            {
                Sintetizador.Resume();
                Sintetizador.SpeakAsyncCancelAll();
            }

            if (Sintetizador.State.ToString() == "Speaking")
            {
                Sintetizador.SpeakAsyncCancelAll();
            }


            Sintetizador.SpeakAsync(TxtSintetizar.Text);
        }

        private void BtnPausar_Click(object sender, RoutedEventArgs e)
        {
                Sintetizador.Pause();
        }

        private void BtnReanudar_Click(object sender, RoutedEventArgs e)
        {
                Sintetizador.Resume();
        }

        private void BtnFin_Click(object sender, RoutedEventArgs e)
        {
            if (Sintetizador.State.ToString() == "Paused")
            {
                Sintetizador.Resume();
            }
            Sintetizador.SpeakAsyncCancelAll();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Sintetizador.Dispose(); //Elimina los recursos de Síntesis utilizados en la aplicación
        }

        private void MenuBiblio_Click(object sender, RoutedEventArgs e)
        {
            Bibliografia Bib = new Bibliografia();
            Bib.ShowDialog();
        }
    }
}
