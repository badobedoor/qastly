using qastly.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using qastly.Helpers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace qastly.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CostomarSearch : ContentPage
    {
        public CostomarSearch()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();

            if(Settings.pop_navigation == 1)
            {
                Settings.pop_navigation = 0;
                Navigation.PopAsync();
            } 
            

        }

        protected override void OnAppearing()
        {
            MessagingCenter.Subscribe<string, string>("CostomarSearch", "UbdateListView", (sender, result) =>
            {
                BindingContext = new MainViewModel();
            });
        }

        protected override void OnDisappearing()
        {
            MessagingCenter.Unsubscribe<CostomarSearch>(this, "UbdateListView");
        }

        private void CostomarSearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            var _Contanir =  BindingContext as MainViewModel;
            if (string.IsNullOrWhiteSpace(e.NewTextValue))
            {
                CostomarListView.ItemsSource = _Contanir.Costomar;
            }
            else
            {
                CostomarListView.ItemsSource = _Contanir.Costomar.Where(i => 
                i.IDnum.ToString().Contains(e.NewTextValue) 
                || i.name.Contains(e.NewTextValue)  
                || i.phone1.ToString().Contains(e.NewTextValue));
                
            }
            var KeyWord = CostomarSearchBar.Text;            
        }

        //private void CheckoutBtn_Clicked(object sender, EventArgs e)
        //{
        //    Navigation.PushModalAsync(new CreateCostomar());
        //}
    }
}