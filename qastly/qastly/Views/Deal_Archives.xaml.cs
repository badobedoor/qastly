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
    public partial class Deal_Archives : ContentPage
    {
        public Deal_Archives()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();

        }
        protected override void OnAppearing()
        {
            MessagingCenter.Subscribe<string, string>("Deal_Archives", "UbdateListView", (sender, result) =>
            {
                BindingContext = new MainViewModel();
            });
        }

        protected override void OnDisappearing()
        {
            MessagingCenter.Unsubscribe<Deal_Archives>(this, "UbdateListView");
        }

        private void CostomarSearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            var _Contanir = BindingContext as MainViewModel;
            if (string.IsNullOrWhiteSpace(e.NewTextValue))
            {
                Deal_Data_ListView.ItemsSource = _Contanir.List_deal_Archives;
            }
            else
            {
                Deal_Data_ListView.ItemsSource = _Contanir.List_deal_Archives.Where(i =>
                i.IDnum.ToString().Contains(e.NewTextValue)
                || i.name.Contains(e.NewTextValue)


                || i.phone1.ToString().Contains(e.NewTextValue));
                //|| i.Collectedvalue.ToString().Contains(e.NewTextValue)
                // || i.group_Name.Contains(e.NewTextValue)

            }
            var KeyWord = CostomarSearchBar.Text;
        }


    }
}