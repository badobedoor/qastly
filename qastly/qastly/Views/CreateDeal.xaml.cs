using qastly.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using qastly.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using qastly.ViewModels;

namespace qastly.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreateDeal : ContentPage
    {
        Data.V_Group_month_Lisst o_Group;
        public CreateDeal()
        {
            
            InitializeComponent();

            
            var o_GroupService = new GroupService();
             var res  = o_GroupService.getGroup_by_Id(Settings.GroupID).Result;
            if (res != null)
            {
                o_Group = res;
                Group_id_lable.Text = o_Group.group_id.ToString();
            }

           // group_name_Entry.Text = group_name;
            #region DayDatePicker Items
            DayDatePicker.Items.Add("1");
            DayDatePicker.Items.Add("2");
            DayDatePicker.Items.Add("3");
            DayDatePicker.Items.Add("4");
            DayDatePicker.Items.Add("5");
            DayDatePicker.Items.Add("6");
            DayDatePicker.Items.Add("7");
            DayDatePicker.Items.Add("8");
            DayDatePicker.Items.Add("9");
            DayDatePicker.Items.Add("10");
            DayDatePicker.Items.Add("11");
            DayDatePicker.Items.Add("12");
            DayDatePicker.Items.Add("13");
            DayDatePicker.Items.Add("14");
            DayDatePicker.Items.Add("15");
            DayDatePicker.Items.Add("16");
            DayDatePicker.Items.Add("17");
            DayDatePicker.Items.Add("18");
            DayDatePicker.Items.Add("19");
            DayDatePicker.Items.Add("20");
            DayDatePicker.Items.Add("21");
            DayDatePicker.Items.Add("22");
            DayDatePicker.Items.Add("23");
            DayDatePicker.Items.Add("24");
            DayDatePicker.Items.Add("25");
            DayDatePicker.Items.Add("26");
            DayDatePicker.Items.Add("27");
            DayDatePicker.Items.Add("28");
            DayDatePicker.Items.Add("29");
            DayDatePicker.Items.Add("30");
            #endregion

        }



        private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            var dt = e.NewDate;
            DateePickerbtn.Text = String.Format("{0:yyyy/MM/dd}", dt);
            Settings.Creat_Deal_Start_Date = DateePickerbtn.Text;
            
        }

        private void DateePickerbtn_Clicked(object sender, EventArgs e)
        {
            DateePicker.Focus();
        }

        private void DayDatePickerbtn_Clicked(object sender, EventArgs e)
        {
            DayDatePicker.Focus();
        }

        private async void DayDatePicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var res = DayDatePicker.Items[DayDatePicker.SelectedIndex];
            
            DateTime start_date =  Convert.ToDateTime(DateePickerbtn.Text);
            DateTime pay_day_date = new DateTime(start_date.Year, start_date.Month, Convert.ToInt32(res) );
            double remind_date = (pay_day_date - start_date).TotalDays;
            if(remind_date < 30)
            {
                var Msg = "استحقاق اول ثسط بعد اقل من شهر  " + "@" + " هل تريد اضافه شهر على تاريخ استحقاق اول قسط ؟";
                Msg = Msg.Replace("@", System.Environment.NewLine);
                var Alert_res = await DisplayAlert("تنبيه", Msg, "حسنا أضف شهر", "لا دع التاريخ كما هو ");
                if(Alert_res == true)
                {
                    if(remind_date > 0)
                    {
                        pay_day_date = new DateTime(start_date.Year, start_date.Month, Convert.ToInt32(res)).AddMonths(1);
                        var r = (pay_day_date - start_date).TotalDays;
                        
                        
                        Day_DatePickerbtn.Text = String.Format("{0:yyyy/MM/dd}", pay_day_date);
                        Settings.Creat_Deal_paymentDay = Day_DatePickerbtn.Text;
                    }
                    else
                    {
                        if (remind_date > -13)
                        {
                            pay_day_date = new DateTime(start_date.Year, start_date.Month, Convert.ToInt32(res)).AddMonths(1);
                           var r = (pay_day_date - start_date).TotalDays;
                            
                            Day_DatePickerbtn.Text = String.Format("{0:yyyy/MM/dd}", pay_day_date);
                            Settings.Creat_Deal_paymentDay = Day_DatePickerbtn.Text;

                        }
                        else
                        {
                            pay_day_date = new DateTime(start_date.Year, start_date.Month, Convert.ToInt32(res)).AddMonths(2);
                            var r = (pay_day_date - start_date).TotalDays;
                            
                            Day_DatePickerbtn.Text = String.Format("{0:yyyy/MM/dd}", pay_day_date);
                            Settings.Creat_Deal_paymentDay = Day_DatePickerbtn.Text;
                        }
                        
                    }

                }
                else
                {
                     pay_day_date = new DateTime(start_date.Year, start_date.Month, Convert.ToInt32(res));
                    var r = (pay_day_date - start_date).TotalDays;
                    
                    Day_DatePickerbtn.Text = String.Format("{0:yyyy/MM/dd}", pay_day_date);
                    Settings.Creat_Deal_paymentDay = Day_DatePickerbtn.Text;
                }
            }            
        }

        private void Fundspickerbtn_Clicked(object sender, EventArgs e)
        {
            if (Fundspicker.Items.Count != 0)
            {
                Fundspicker.Focus();
            }
            else
            {
                DisplayAlert("تنبية", "لم يتم إضافه اي خزنه بعد", "حسنا");
            }

        }

        private void Fundspicker_SelectedIndexChanged(object sender, EventArgs e)
        {

            var Funds = Fundspicker.Items[Fundspicker.SelectedIndex];
            var o_fundsService = new fundsService();
            var o_fund = o_fundsService.GetFundsbyname(Funds).Result;
            if (o_fund != null)
            {
                if (o_fund.fundsBalance >= Settings.Creat_Deal_price)
                {
                    Fundspickerbtn.Text = Funds;
                }
                else
                {
                    DisplayAlert("تنبية", "لا يوجد رصيد كافى فى الخزنه المختارة ", "حسنا");
                }
            }


           
            

        }

        private async void cash_lable_Clicked(object sender, EventArgs e)
        {
            if (cash_lable.TextColor != Color.FromHex("#fff"))
            {
                if (ListdebtSum_picker_Btn.Text != "أختر الدائن" && pic_Debt_Name.IsVisible == true && Debt_Name.IsVisible == false) 
                
                {
                    var Alert_res = await DisplayAlert("تنبية", "لا يمكن اختيار نظامين دفع , هل تريد إلغاء الدين الذى أنشاته ؟", "حسنا", "إلغاء");
                    if (Alert_res != false)
                    {
                        ListdebtSum_picker_Btn.Text = "أختر الدائن";
                        cash_lable.TextColor = Color.FromHex("#fff");
                        cash_lable.BackgroundColor = Color.FromHex("#3D72FF");

                        Debt_lable.TextColor = Color.FromHex("#3D72FF");
                        Debt_lable.BackgroundColor = Color.Transparent;
                        Fundspickerbtn.IsVisible = true;
                        pic_Debt_Name.IsVisible = false;
                        Debt_Name.IsVisible = false;
                    }

                }else if(  pic_Debt_Name.IsVisible == false && Debt_Name.IsVisible == true)
                {
                    if(new_Dept_name.Text != "" ||  new_Dept_name.Text != null)
                    {
                        var Alert_res = await DisplayAlert("تنبية", "لا يمكن اختيار نظامين دفع , هل تريد إلغاء الدين الذى أنشاته ؟", "حسنا", "إلغاء");
                        if (Alert_res != false)
                        {
                            new_Dept_name.Text = "";
                            cash_lable.TextColor = Color.FromHex("#fff");
                            cash_lable.BackgroundColor = Color.FromHex("#3D72FF");

                            Debt_lable.TextColor = Color.FromHex("#3D72FF");
                            Debt_lable.BackgroundColor = Color.Transparent;
                            Fundspickerbtn.IsVisible = true;
                            pic_Debt_Name.IsVisible = false;
                            Debt_Name.IsVisible = false;
                        }
                    }
                }
                else
                {
                    cash_lable.TextColor = Color.FromHex("#fff");
                    cash_lable.BackgroundColor = Color.FromHex("#3D72FF");

                    Debt_lable.TextColor = Color.FromHex("#3D72FF");
                    Debt_lable.BackgroundColor = Color.Transparent;
                    Fundspickerbtn.IsVisible = true;
                    pic_Debt_Name.IsVisible = false;
                    Debt_Name.IsVisible = false;
                }
            }


        }

        private async void  Debt_lable_Clicked(object sender, EventArgs e)
        {
            if (cash_lable.TextColor != Color.FromHex("#3D72FF"))
            {
                if (Fundspickerbtn.Text != "أختر حساب")
                {
                  
                   var Alert_res = await DisplayAlert("تنبية", "لا يمكن اختيار نظامين دفع , هل تريد إلغاء السحب من الحزنه التى أخترتها ؟", "حسنا", "إلغاء");
                    if(Alert_res != false)
                    {
                        Fundspickerbtn.Text = "أختر حساب";
                        cash_lable.TextColor = Color.FromHex("#3D72FF");
                        cash_lable.BackgroundColor = Color.Transparent;

                        Debt_lable.TextColor = Color.FromHex("#fff");
                        Debt_lable.BackgroundColor = Color.FromHex("#3D72FF");
                        Fundspickerbtn.IsVisible = false;
                        pic_Debt_Name.IsVisible = true;
                        Debt_Name.IsVisible = false;
                    }

                }
                else
                {
                    cash_lable.TextColor = Color.FromHex("#3D72FF");
                    cash_lable.BackgroundColor = Color.Transparent;

                    Debt_lable.TextColor = Color.FromHex("#fff");
                    Debt_lable.BackgroundColor = Color.FromHex("#3D72FF");
                    Fundspickerbtn.IsVisible = false;
                    pic_Debt_Name.IsVisible = true;
                    Debt_Name.IsVisible = false;
                }

            }


        }

        private void ListdebtSum_picker_Btn_Clicked(object sender, EventArgs e)
        {
            if (ListdebtSum_picker.Items.Count != 0)
            {
                ListdebtSum_picker.Focus();
            }
            else
            {
                DisplayAlert("تنبيه", "لم يتم إضافه اي دائن بعد", "حسنا");
            }

        }

        private void ListdebtSum_picker_SelectedIndexChanged(object sender, EventArgs e)
        {

                var ListdebtSum_picker_Btn_text = ListdebtSum_picker.Items[ListdebtSum_picker.SelectedIndex];
                ListdebtSum_picker_Btn.Text = ListdebtSum_picker_Btn_text;


        }
        private void Add_Debt_Name_Clicked(object sender, EventArgs e)
        {
            if(ListdebtSum_picker_Btn.Text == "أختر الدائن")
            {
                pic_Debt_Name.IsVisible = false;
                Debt_Name.IsVisible = true;
            }
            else
            {
                DisplayAlert("تنبيه", "لا يمكن انشاء دين جديد", "حسنا");
            }

        }
        private void pic_Debt_Name_Clicked(object sender, EventArgs e)
        {
            if (new_Dept_name.Text == "" || new_Dept_name.Text == null)
            {
                pic_Debt_Name.IsVisible = true;
                Debt_Name.IsVisible = false;
            }
            else
            {
                DisplayAlert("تنبيه", "لا يمكن اختيار دائن", "حسنا");
            }

        }
        

        //private void Nav_To_CostomarSearch_Clicked(object sender, EventArgs e)
        //{
        //    Navigation.PushModalAsync(new Views.CostomarSearch());
        //}
    }
}