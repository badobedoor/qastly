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
    public partial class pocketMoney : ContentPage
    {
        public pocketMoney()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();
        }


        protected override void OnAppearing()
        {
            MessagingCenter.Subscribe<string, string>("pocketMoney", "UbdateListView", (sender, result) =>
            {
                BindingContext = new MainViewModel();
            });
        }

        protected override void OnDisappearing()
        {
            MessagingCenter.Unsubscribe<pocketMoney>(this, "UbdateListView");
        }
    }
}