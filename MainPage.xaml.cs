using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace XboxGameBarWatch
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            textBlockTime.Foreground = new SolidColorBrush(Color.FromArgb(255, 238, 244, 248));

            SetUpTimer();
            ShowCurrentTime();
        }

        private void SetUpTimer()
        {
            var timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 1, 0);
            timer.Tick += (s, a) => ShowCurrentTime();
            timer.Start();
        }

        private void ShowCurrentTime()
        {
            textBlockTime.Text = DateTime.Now.ToString("HH:mm");
        }
    }
}
