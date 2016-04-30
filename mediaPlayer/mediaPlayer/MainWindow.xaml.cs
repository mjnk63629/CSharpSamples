using System;
using System.Collections.Generic;
using System.IO.Packaging;
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
using Microsoft.Win32;

namespace mediaPlayer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonPlay_Click(object sender, RoutedEventArgs e)
        {
        mediaElement.Play();
        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    OpenFileDialog selectSong = new OpenFileDialog();
        //    selectSong.AddExtension = true;
        //    selectSong.DefaultExt = "*.*";
        //    selectSong.Filter = "audio Files(*.*|*.*";
        //    selectSong.ShowDialog();
        //    try
        //    {
        //        mediaElement.Source = new Uri(selectSong.FileName);
        //    }
        //    catch
        //    {
        //        new NullReferenceException("Error");
        //    }
        //    System.Windows.Threading.DispatcherTimer dispatcherTimer = new DispatcherTimer();
        //    dispatcherTimer.Tick+=new EventHandler(timerTick);
        //    dispatcherTimer.Interval= new TimeSpan(0,0,1);
        //    dispatcherTimer.Start();
        //}

        

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            OpenFileDialog selectSong = new OpenFileDialog();
            selectSong.AddExtension = true;
            selectSong.DefaultExt = "*.*";
            selectSong.Filter = "audio Files(*.*|*.*";
            selectSong.ShowDialog();
            try
            {
                mediaElement.Source = new Uri(selectSong.FileName);
            }
            catch
            {
                new NullReferenceException("Error");
            }
            System.Windows.Threading.DispatcherTimer dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(timerTick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();
            mediaElement.Play();
        }
        void timerTick(object sender, EventArgs e)
        {
            slider.Value = mediaElement.Position.TotalSeconds;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            mediaElement.Stop();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            mediaElement.Pause();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            mediaElement.Play();
        }

        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            TimeSpan timeSpan = TimeSpan.FromSeconds(e.NewValue);
            mediaElement.Position = timeSpan;
        }

        private void mediaElement_MediaOpened(object sender, RoutedEventArgs e)
        {
            if (mediaElement.NaturalDuration.HasTimeSpan)
            {
                TimeSpan timeSpan = TimeSpan.FromMilliseconds(mediaElement.NaturalDuration.TimeSpan.TotalMilliseconds);
                slider.Maximum = timeSpan.TotalSeconds;
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (mediaElement.Volume > 0)
            {
                mediaElement.Volume = 0;
                buttonMute.ToolTip = "UnMute";
                buttonMute.Source= new BitmapImage(new Uri("pack://application:,,/Images/UnMute.png"));
            }
            else
            {
                mediaElement.Volume = 100;
                buttonMute.ToolTip = "Mute";
                buttonMute.Source = new BitmapImage(new Uri("pack://application:,,/Images/Mute.png"));
            }
        }

        private void slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            mediaElement.Volume = slider1.Value;
        }
    }
}
