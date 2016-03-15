using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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
    public sealed partial class SummaryPage : Page
    {
        public SummaryPage()
        {
            this.InitializeComponent();
            myAccess();
        }
        public async void myAccess()
        {
            StorageFolder localFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
            StorageFile sampleFile = await localFolder.GetFileAsync("dataFile.txt");
            String billData = await FileIO.ReadTextAsync(sampleFile);
            string []ade = billData.Split('^');
            FirstNameBox.Text = ade[0];
            LastNameBox.Text = ade[1];
            IDNumberBox.Text = ade[2];
            EmailBox.Text = ade[3];
            AddressLineBox.Text = ade[4];
            CityBox.Text = ade[5];
            PostalBox.Text = ade[6];
            CreditCardBox.Text = ade[7];
            CountryBox.Text = ade[8];
            SecurityBox.Text = ade[9];
            StreetAddressBox.Text = ade[10];
            ProvinceBox.Text = ade[11];

            
          
        }

        private void goBackBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
