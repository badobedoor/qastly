using qastly.SQLite;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms; 
using Xamarin.Forms.Xaml;
using qastly.Models;
using qastly.ViewModels;

namespace qastly.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class costomares : ContentPage
    {

        

        public costomares()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();

        }

        protected override void OnAppearing()
        {
            MessagingCenter.Subscribe<string, string>("costomares", "UbdateListView", (sender, result) =>
            {
                BindingContext = new MainViewModel();
            });
        }

        protected override void OnDisappearing()
        {
            MessagingCenter.Unsubscribe<costomares>(this, "UbdateListView");
        }
       
    }
}