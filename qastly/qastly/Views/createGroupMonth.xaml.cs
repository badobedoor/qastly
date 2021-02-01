using qastly.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using qastly.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;

namespace qastly.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class createGroupMonth 
    {
        public ObservableCollection<string> group_month_Num_Items;
        public createGroupMonth()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();
        }

        protected override void OnAppearing()
        {
            MessagingCenter.Subscribe<string, string>("createGroupMonth", "UbdateListView", (sender, result) =>
            {
                BindingContext = new MainViewModel();
            });
        }

        protected override void OnDisappearing()
        {
            MessagingCenter.Unsubscribe<createGroupMonth>(this, "UbdateListView");
        }

        //private void Check_CheckedChanged(object sender, CheckedChangedEventArgs e)
        //{
        //    if(group_month_Num_Items != null)
        //    {
        //        var cbox = (CheckBox)sender;
        //        var BindContext = (Data.group_month_Num)cbox.BindingContext;
                
        //        var o_DisplaymonthNum = BindContext.DisplaymonthNum;
        //        var o_Items = group_month_Num_Items.FirstOrDefault(x => x == o_DisplaymonthNum);
        //        if(o_Items != null)
        //        {
        //            var resIndex = group_month_Num_Items.IndexOf(o_Items);
        //            group_month_Num_Items.RemoveAt(resIndex);
        //            ListdebtSum_picker.ItemsSource = group_month_Num_Items;
        //        }
        //        else
        //        {
        //            group_month_Num_Items.Add(o_DisplaymonthNum);
        //            ListdebtSum_picker.ItemsSource = group_month_Num_Items;
        //        }                                
        //    }
        //    else
        //    {
        //        var cbox = (CheckBox)sender;
        //        var BindContext = (Data.group_month_Num)cbox.BindingContext;

        //        var o_DisplaymonthNum = BindContext.DisplaymonthNum;
        //        group_month_Num_Items = new ObservableCollection<string> { o_DisplaymonthNum };
        //        ListdebtSum_picker.ItemsSource = group_month_Num_Items;
        //    }

        //}
    }
}