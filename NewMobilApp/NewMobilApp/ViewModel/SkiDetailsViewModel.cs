using System;
using System.Collections.Generic;
using System.Text;
using NewMobilApp.Model;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace NewMobilApp.ViewModel
{
    class SkiDetailsViewModel : BaseViewModel
    {
        public Command OpenMapCommand { get; }
     
        Ski ski;

        public SkiDetailsViewModel(Ski ski)
        {
            this.ski = ski;
        }

        public Ski Ski
        {
            get => ski;
            set
            {
                if (ski == value)
                    return;

                ski = value;
                OnPropertyChanged();
            }
        }
      
    }
}
