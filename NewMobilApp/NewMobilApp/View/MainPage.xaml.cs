using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewMobilApp.Model;
using NewMobilApp.View;
using NewMobilApp.ViewModel;
using Xamarin.Forms;

namespace NewMobilApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new SkiViewModel();
        }
        async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var ski = e.SelectedItem as Ski;
            if (ski == null)
                return;
            await Navigation.PushAsync(new DetailsPage(ski));

            ((ListView)sender).SelectedItem = null;

        }
    }
}
