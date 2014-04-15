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
using Windows.UI.Popups;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace BrailleReader
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            Image img = new Image();

            
            for (int i = 0; i < 5; i++)
            {
                TextBlock T = new TextBlock();
            T.Text = "bla ";
                file1.Children.Add(T);
            }
        }

        async void Double_tapped(object sender, RoutedEventArgs e)
        {
            MessageDialog d;

            d = new MessageDialog("Delete selected note?", "Confirmation");
            await d.ShowAsync();
        }

        private  async void  Image_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MessageDialog d;

            d = new MessageDialog("image tapped?", "Confirmation");
            await d.ShowAsync();
        }


        private async void Image_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            //if(e.)
            MessageDialog d;

            d = new MessageDialog("image hovered?", "Confirmation");
            await d.ShowAsync();
        }

        private async void DeleteDoc_Click(object sender, RoutedEventArgs e)
        {
            MessageDialog d;

            d = new MessageDialog("Delete?", "Confirmation");
            await d.ShowAsync();
            
        }
     private async void NewDoc_Click(object sender, RoutedEventArgs e)
        {
            MessageDialog d;

            d = new MessageDialog("add?", "Confirmation");
            await d.ShowAsync();
            
        }

     private void listView1_SelectionChanged(object sender, SelectionChangedEventArgs e)
     {

     }
    }
}
