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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Exotic_Cars
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CarsPage : Page
    {
        public List<Photo> photos;
        public CarsPage()
        {
            this.InitializeComponent();
            photos = PhotoManager.getPhoto();
        }

        private void ListView_ItemClick(object sender, ItemClickEventArgs e)
        {
           var photo= (Photo)e.ClickedItem;
            carSelection.Text = "you have selected:  " + photo.photoTitle;
           
        }
       

        private async void myBut_Click(object sender, RoutedEventArgs e)
        {

            StorageFolder storageFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
            StorageFile sampleFile = await storageFolder.CreateFileAsync("dataFile1.txt", CreationCollisionOption.ReplaceExisting);
            await FileIO.WriteTextAsync(sampleFile, carSelection.Text);
            Frame.Navigate(typeof(TransactionPage));
        }
    }
}
