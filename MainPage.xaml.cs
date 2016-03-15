using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Exotic_Cars.model;
using Windows.Storage;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Exotic_Cars
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        
        public MainPage()
        {
            this.InitializeComponent();
            myFrame.Navigate(typeof(CarsPage));

        }

        private void Bike_Click(object sender, RoutedEventArgs e)
        {
            myFrame.Navigate(typeof(BikePage));
        }

        private void Transaction_Click(object sender, RoutedEventArgs e)
        {
            myFrame.Navigate(typeof(support));
        }

        private void Summary_Click(object sender, RoutedEventArgs e)
        {
            myFrame.Navigate(typeof(AboutUS));
        }

        private void Cars_Click(object sender, RoutedEventArgs e)
        {

            myFrame.Navigate(typeof(CarsPage));
        }

       
    }
}
