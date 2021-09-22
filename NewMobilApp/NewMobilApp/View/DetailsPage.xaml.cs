using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewMobilApp.Model;
using NewMobilApp.ViewModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NewMobilApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailsPage : ContentPage
    {
        public DetailsPage()
        {
            InitializeComponent();
        }
        public DetailsPage(Ski ski)
        {
            InitializeComponent();
            BindingContext = new SkiDetailsViewModel(ski);
        }
    }
}