﻿using System.Net.Http;
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
        private static HttpClient sharedClient = new() { BaseAddress = new("https://localhost:5001") };
        public MainWindow()
        {
            InitializeComponent();
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

        private async void FeltoltoKonyvtar() { }
    }
}