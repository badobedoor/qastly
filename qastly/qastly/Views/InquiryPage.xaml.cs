using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using qastly.Helpers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using qastly.Models;
using qastly.ViewModels;

namespace qastly.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InquiryPage : ContentPage
    {
        Data.V_Group_month_Lisst o_V_Group_month_Lisst = new Data.V_Group_month_Lisst();
        int totalMonith;
        int pricee;
        int selcet_month;
        int given;
        int remainder;
        int qast;
        int group_id;
        string month;
        string group_name;
        int Pons_installment;
        List<int> o_Group_Month_Num_Picker;
        int Total_installment;
        BindingMode mode = BindingMode.TwoWay;
        public InquiryPage()
        {
            InitializeComponent();
            //var viewModel =  MainViewModel.getinstace();
            BindingContext = new MainViewModel();
            
            bt.Text = "المجموعة";
            monthBt.Text = "عدد الأشهر";

        }

        private void mainpicker_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (group_name != null)
            {
                monthpicker.ItemsSource.Clear();
                monthBt.Text = "عدد الاشهر";
                msg.Text = "0";
            }



            group_name = Grouppicker.Items[Grouppicker.SelectedIndex];            
            bt.SetBinding(Button.TextProperty, "VM_Creat_Deal_group_name", mode);
            bt.Text = group_name;

            var opj = Grouppicker.SelectedItem;
                o_V_Group_month_Lisst = opj as Data.V_Group_month_Lisst;
                Settings.GroupID = o_V_Group_month_Lisst.group_id;
                group_id = o_V_Group_month_Lisst.group_id;
                
                lable_group_id.SetBinding(Label.TextProperty, "VM_Creat_Deal_group_id", mode);
            lable_group_id.Text = group_id.ToString();
            var o_GroupService = new GroupService();
                o_Group_Month_Num_Picker = o_GroupService.getGroup_Month_Num_Picker(Settings.GroupID).Result;
                if (o_Group_Month_Num_Picker != null)
                {
                    monthpicker.ItemsSource = o_Group_Month_Num_Picker;
                }
            DependencyService.Get<IMessage>().ShortAlert( "أنت أخترت مجموعة  :-  " + group_name);
            
            

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            
            if (Grouppicker.Items.Count != 0)
            {
                Grouppicker.Focus();
            }
            else
            {
                DisplayAlert("تنبيه", "لم يتم إضافه اي مجموعه ", "حسنا");
            }

        }

        private void monthpicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if(o_V_Group_month_Lisst == null)
            {
                DisplayAlert("خطأ", "تاكد من إدخال البنات صحيحه  ", "حسنا");
            }
            else
            {
                if(monthpicker.SelectedIndex == -1 ){ }
                else
                {
                    month = monthpicker.Items[monthpicker.SelectedIndex];
                    //DisplayAlert("عدد الاشهر", "أنت أخترت عدد الاشهر  :-  " + month, "Ok");
                    try
                    {
                        pricee = int.Parse(price.Text);
                        given = int.Parse(pary.Text);
                        monthBt.SetBinding(Button.TextProperty, "VM_Creat_Deal_selcet_month", mode);
                        price.SetBinding(Entry.TextProperty, "VM_Creat_Deal_price", mode);
                        pary.SetBinding(Entry.TextProperty, "VM_Creat_Deal_given", mode);                        
                        lable_remainder.SetBinding(Label.TextProperty, "VM_Creat_Deal_remainder", mode);

                        price.Text = pricee.ToString();
                        pary.Text = given.ToString();                        
                        selcet_month = int.Parse(month);
                        
                        remainder = pricee - given;
                        var f = ((o_V_Group_month_Lisst.MonthlyProfitRate.Value * selcet_month) + 100) / 1000;
                        if (remainder > o_V_Group_month_Lisst.maximumAmount)
                        {
                            DisplayAlert("خطأ", " أقصى مبلغ للتقسيط  " + o_V_Group_month_Lisst.maximumAmount, "حسنا");
                        }                           
                        else if (remainder < 100)
                        {
                            price.Text = "";
                            pary.Text = "";
                            DisplayAlert("خطأ", "أقل مبلغ للتقسيط 100", "حسنا");
                        }

                        else
                        {
                            //qast
                            monthBt.Text = month;
                            lable_remainder.Text = remainder.ToString();




                            //....
                            decimal result = Math.Round((remainder * f) / selcet_month) * 10;

                           
                            lable_qast.SetBinding(Label.TextProperty, "VM_Creat_Deal_qast", mode);
                            lable_qast.Text = result.ToString();
                            qast = int.Parse(result.ToString());
                            msg.Text = result.ToString();

                            //Pons_installment
                            var Total_res = qast * selcet_month;

                            

                            Total_installment = Total_res + given;

                            lable_Total_installment.SetBinding(Label.TextProperty, "VM_Creat_Deal_Total_installment", mode);
                            lable_Total_installment.Text = Total_installment.ToString();

                            //Total_installment                                                                                                                

                            Pons_installment = Total_res - remainder;

                            lable_Pons_installment.SetBinding(Label.TextProperty, "VM_Creat_Deal_Pons_installment", mode);
                            lable_Pons_installment.Text = Pons_installment.ToString();
                        }
                    }
                    catch
                    {
                        DisplayAlert("خطأ", "تاكد من ثمن السلعه والمقدم", "حسنا");
                        monthBt.Text = "عدد الاشهر";
                    }
                }
            }
           
        }

        private void monthBt_Clicked(object sender, EventArgs e)
        {
            if (bt.Text == "المجموعة")
            {
                DisplayAlert("خطأ", "برجاء أختيار مجموعة اولا", "Ok");
            }else
            monthpicker.Focus();
        }

        private void Totalinstallment_Clicked(object sender, EventArgs e)
        {
            if (msg.Text == "0")
            {
                
                DisplayAlert("خطأ", "الرجاء التأكد من ثمن السلعه والمقدم وعدد أشهر التقسيط ", "حسنا");
            }
            else
            {
                msg.Text = Total_installment.ToString();
                
            }
        }

        private void Ponsinstallment_Clicked(object sender, EventArgs e)
        {
            if (msg.Text == "0")
            {
                DisplayAlert("خطــــأ", "الرجاء التأكد من ثمن السلعه والمقدم وعدد أشهر التقسيط ", "حسنا");
            }
            else
            {
                msg.Text = Pons_installment.ToString();
            }
        }


    }
}