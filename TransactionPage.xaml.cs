using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Exotic_Cars
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class TransactionPage : Page
    {
        public TransactionPage()
        {
            this.InitializeComponent();
           
        }
       


        private async void Submit_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder addd = new StringBuilder();
            addd.Append(FirstNameBox.Text).Append("^");
            addd.Append(LastNameBox.Text).Append("^");
            addd.Append(IDNumberBox.Text).Append("^");
            addd.Append(EmailBox.Text).Append("^");
            addd.Append(AddressLineBox.Text).Append("^");
            addd.Append(CityBox.Text).Append("^");
            addd.Append(PostalBox.Text).Append("^");
            addd.Append(CreditCardBox.Text).Append("^");
            addd.Append(CountryBox.Text).Append("^");
            addd.Append(SecurityBox.Text).Append("^");
            addd.Append(StreetAddressBox.Text).Append("^");
            addd.Append(ProvinceBox.Text).Append("^");
            StorageFolder storageFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
            StorageFile sampleFile = await storageFolder.CreateFileAsync("dataFile.txt", CreationCollisionOption.ReplaceExisting);
            await FileIO.WriteTextAsync(sampleFile, addd.ToString());
            Frame.Navigate(typeof(SummaryPage));
           
        }


        private void goBackBtn_Click_1(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(CarsPage));
        }

        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            StorageFolder localFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
            StorageFile sampleFile = await localFolder.GetFileAsync("dataFile1.txt");
            String billData = await FileIO.ReadTextAsync(sampleFile);
            txtPrice.Text = billData.ToString();
        }
    }
}
