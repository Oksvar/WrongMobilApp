using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

using System.Linq;
using NewMobilApp.Model;
using System.Diagnostics;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Collections.Generic;

namespace NewMobilApp.ViewModel
{
   public class SkiViewModel : BaseViewModel
    {
        HttpClient httpClient;
        HttpClient Client => httpClient ?? (httpClient = new HttpClient());

        public ObservableCollection<Ski> skis { get; }
        public Command GetSkiCommand { get; }
        public SkiViewModel()
        {
            Title = "Ski Search";
            skis = new ObservableCollection<Ski>();
            
            
        }
        async Task GetSkiAsync()
        {
            if (IsBusy)
                return;
            try
            {
                IsBusy = true;
                var json = await Client.GetStringAsync("https://siutak.hu/export.php");
                var skis = Ski.FromJson(json);

              
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Wrong {ex.Message}");
                await Application.Current.MainPage.DisplayAlert("Error!", ex.Message, "Ok");
            }
            finally
            {
                IsBusy = false;
            }
        }
        

    }
}
