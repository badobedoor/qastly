using qastly.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace qastly.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Group : ContentPage
    {
        public Group()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();
            var s = Month_piker.IsVisible;
            if(s == true) { Month_piker_Focus(); }

            
        }

        protected override void OnAppearing()
        {
            MessagingCenter.Subscribe<string, string>("Group", "UbdateListView", (sender, result) =>
            {
                BindingContext = new MainViewModel();
            });
        }

        protected override void OnDisappearing()
        {
            MessagingCenter.Unsubscribe<Group>(this, "UbdateListView");
        }

        public void Month_piker_Focus()
        {
            Month_piker.Focus();
        }
    }
}