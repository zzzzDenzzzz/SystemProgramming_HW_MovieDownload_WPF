using System;
using System.Threading;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Media.Animation;

namespace SystemProgramming_HW_MovieDownload_WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        void DownloadStart(object sender, RoutedEventArgs e)
        {
            downloadStatus.BeginAnimation(RangeBase.ValueProperty, new DoubleAnimation(100, new Duration(TimeSpan.FromSeconds(20))));
        }

        void MessageShow(object sender, RoutedEventArgs e)
        {
            new Thread(() => MessageBox.Show("Test")).Start();
        }
    }
}
