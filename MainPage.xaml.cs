using System;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace XboxGameBarWatch
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();

            textBlockTime.Foreground = new SolidColorBrush(Color.FromArgb(255, 238, 244, 248));

            SetUpTimer();
            ShowCurrentTime();
        }

        private void SetUpTimer()
        {
            var timer = new DispatcherTimer
            {
                Interval = new TimeSpan(0, 1, 0)
            };
            timer.Tick += (s, a) => ShowCurrentTime();
            timer.Start();
        }

        private void ShowCurrentTime() => textBlockTime.Text = DateTime.Now.ToString("HH:mm");
    }
}
