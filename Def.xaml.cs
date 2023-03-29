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
using System.Windows.Threading;

namespace WPFProyectoFinal
{
    /// <summary>
    /// Lógica de interacción para Def.xaml
    /// </summary>
    public partial class Def : Page
    {

		public Def()
        {
            InitializeComponent();

			DispatcherTimer timer = new DispatcherTimer();
			timer.Interval = TimeSpan.FromSeconds(1);
			timer.Tick += timer_Tick;
			timer.Start();
			SldStatus.Maximum = 430;
		}

		void timer_Tick(object sender, EventArgs e)
		{
				if (Audio.NaturalDuration.HasTimeSpan)
					TxtStatus.Text = String.Format("{0} / {1}", Audio.Position.ToString(@"mm\:ss"), Audio.NaturalDuration.TimeSpan.ToString(@"mm\:ss"));
			SldStatus.Value = Audio.Position.TotalSeconds;
		}
		private void btnPlay_Click(object sender, RoutedEventArgs e)
		{
			Audio.Play();
		}

		private void btnPause_Click(object sender, RoutedEventArgs e)
		{
			Audio.Pause();
		}

		private void btnStop_Click(object sender, RoutedEventArgs e)
		{
			Audio.Stop();
		}

        private void SldStatus_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
			TimeSpan ts = TimeSpan.FromSeconds(e.NewValue);
			Audio.Position = ts;
        }
    }
}
