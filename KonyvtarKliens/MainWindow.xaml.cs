using KonyvtarApi.Models;
using KonyvtarKliens.DTOs;
using KonyvtarKliens.Services;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KonyvtarKliens
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private static HttpClient sharedClient = new() { BaseAddress = new("http://localhost:5000") };
        private static List<KonyvtarakDTO>konyvtarak=new List<KonyvtarakDTO>();
        public MainWindow()
        {
            InitializeComponent();
            FeltoltoKonyvtar();
        }

        private void btnuj_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnmodosit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btntorol_Click(object sender, RoutedEventArgs e)
        {

        }

        private async void FeltoltoKonyvtar()
        {
           konyvtarak=await Konyvtarservices.GetAll(sharedClient);
            Task.Delay(1000).Wait();
            dgrkonyvtarak.ItemsSource = konyvtarak;
            
        }
    }
}