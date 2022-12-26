using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO.Packaging;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
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
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace YT
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

       
        public async Task ExampleMethodAsync()
        {
            var client = new YoutubeClient();
            var streamManifest = await client.Videos.Streams.GetManifestAsync("https://www.youtube.com/watch?v=4uUiPaCrqB8");
            var streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();
            vidos.Source = new Uri(streamInfo.Url);

          

        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            await ExampleMethodAsync();
        }
    }
}

