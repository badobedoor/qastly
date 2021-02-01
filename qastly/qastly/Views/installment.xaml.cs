using qastly.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using qastly.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using qastly.Helpers;

namespace qastly.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class installment : ContentPage
    {
        public Data.installment Old_installment;
        public installment()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();

   
   
        }



        protected override void OnAppearing()
        {
            MessagingCenter.Subscribe<string, string>("installment", "UbdateListView", (sender, result) =>
            {
                BindingContext = new MainViewModel();
            });
        }

        protected override void OnDisappearing()
        {
            MessagingCenter.Unsubscribe<installment>(this, "UbdateListView");
        }

        private void CostomarSearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            var _Contanir = BindingContext as MainViewModel;
            if (string.IsNullOrWhiteSpace(e.NewTextValue))
            {
                Deal_Data_ListView.ItemsSource = _Contanir.List_Deal_Data;
            }
            else
            {
                Deal_Data_ListView.ItemsSource = _Contanir.List_Deal_Data.Where(i =>
                i.IDnum.ToString().Contains(e.NewTextValue)
                || i.name.Contains(e.NewTextValue)
               
                
                || i.phone1.ToString().Contains(e.NewTextValue));
                //|| i.Collectedvalue.ToString().Contains(e.NewTextValue)
                // || i.group_Name.Contains(e.NewTextValue)

            }
            var KeyWord = CostomarSearchBar.Text;
        }



        //private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        //{

        //    var o_dataservices = new DealService();
        //    var res = e.Item as Data.V_costomar_deal_installment;
        //    var New_installment = new Data.installment
        //    {
        //        installment_id = res.installment_id,
        //        deal_id = res.deal_id,
        //        Collectedvalue = res.Collectedvalue,
        //        installmedntColor = res.installmedntColor,
        //        InstallmentDueDate = res.InstallmentDueDate,
        //        InstallmentPaymentDate = res.InstallmentPaymentDate,



        //    };

        //    if (Old_installment != null)
        //    {
        //        if (Old_installment.installment_id == New_installment.installment_id && Old_installment.deal_id == New_installment.deal_id)
        //        {
        //            //لو ضغط على نفس الخامه مرتين 
        //            New_installment.list_Down_visible = !New_installment.list_Down_visible;
        //            var Update_Res = await o_dataservices.Update_installment(New_installment);
        //            //MessagingCenter.Send("Updateinstallment", "UbdateListView", "Success");
        //        }
        //        else
        //        {
        //            //لو ضغط على خانه مختلفه 
        //            Old_installment.list_Down_visible = false;
        //            var Update_Res = await o_dataservices.Update_installment(Old_installment);
        //            New_installment.list_Down_visible = true;
        //            var Update_Old_installment_Res = await o_dataservices.Update_installment(New_installment);
        //            //MessagingCenter.Send("Updateinstallment", "UbdateListView", "Success");
        //        }
        //    }
        //    else
        //    {
        //        //لو اول مره يضغط
        //        New_installment.list_Down_visible = true;
        //        var Update_Old_installment_Res = await o_dataservices.Update_installment(New_installment);
        //    }


        //    Old_installment = New_installment;
        //    BindingContext = new MainViewModel();
        //    List<Data.V_costomar_deal_installment> Source = new MainViewModel().List_Deal_Data;
        //    listview_deal.SetBinding(ListView.BindingContextProperty, Source);
        //    listview_deal.BindingContext = BindingContext
        //    OnAppearing();
        //    //MessagingCenter.Send("Updateinstallment", "UbdateListView", "Success");

        //}
    }
}

#region Comment
//private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
//{

//    var o_dataservices = new DealService();
//    var res = e.Item as Data.V_costomar_deal_installment;
//    var New_installment = new Data.installment
//    {
//        installment_id = res.installment_id,
//        deal_id = res.deal_id,
//        Collectedvalue = res.Collectedvalue,
//        installmedntColor = res.installmedntColor,
//        InstallmentDueDate = res.InstallmentDueDate,
//        InstallmentPaymentDate = res.InstallmentPaymentDate,



//    };

//    if (Old_installment != null)
//    {
//        if (Old_installment.installment_id == New_installment.installment_id && Old_installment.deal_id == New_installment.deal_id)
//        {
//            //لو ضغط على نفس الخامه مرتين 
//            New_installment.list_Down_visible = !New_installment.list_Down_visible;
//            var Update_Res = await o_dataservices.Update_installment(New_installment);
//            //MessagingCenter.Send("Updateinstallment", "UbdateListView", "Success");
//        }
//        else
//        {
//            //لو ضغط على خانه مختلفه 
//            Old_installment.list_Down_visible = false;
//            var Update_Res = await o_dataservices.Update_installment(Old_installment);
//            New_installment.list_Down_visible = true;
//            var Update_Old_installment_Res = await o_dataservices.Update_installment(New_installment);
//            //MessagingCenter.Send("Updateinstallment", "UbdateListView", "Success");
//        }
//    }
//    else
//    {
//        //لو اول مره يضغط
//        New_installment.list_Down_visible = true;
//        var Update_Old_installment_Res = await o_dataservices.Update_installment(New_installment);
//    }


//    Old_installment = New_installment;
//    OnAppearing();
//    //MessagingCenter.Send("Updateinstallment", "UbdateListView", "Success");

//}
#endregion

