using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using qastly.Helpers;
using qastly.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace qastly.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailReport : ContentPage
    {
        
        public DetailReport()
        {
            InitializeComponent();
            if(MSG_lable.Text != "")
            {
                MSG_lable.IsVisible = true;
            }
        }

        //private async void update_deal_in_date_now_Clicked(object sender, EventArgs e)
        //{

        //    //remainder = pricee - given;
        //    var O_DataServices = new GroupService();
        //    int O_remainder = Convert.ToInt32(remainder_lable.Text);
        //    int O_group_id = Convert.ToInt32(group_id_lable.Text);
        //    var o_V_Group_month_Lisst = O_DataServices.getGroup_by_Id(O_group_id).Result;
        //    int O_selcet_month = Convert.ToInt32(selcet_month_lable.Text);
        //    var f = ((o_V_Group_month_Lisst.MonthlyProfitRate.Value * O_selcet_month) + 100) / 1000;
        //    //هنا الاصول اشوف عدد الاقساط المدفوعه والمتبقيه واعمل كام حاجه كده 
        //    int o_paid_installments = Convert.ToInt32(paid_installments_lable.Text) + 1;
        //    var total = Math.Round((O_remainder * f) / o_paid_installments);
        //    var t = O_remainder * f;
        //    var x = total * 10;
        //    int int_total = Convert.ToInt32(Math.Round((O_remainder * f) * o_paid_installments) * 10);
        //    int O_Total_Paid = Convert.ToInt32(Total_Paid_lable.Text);




        //    int total_remaing_quast = int_total - O_Total_Paid;

        //    await DisplayAlert("تنبيه", total_remaing_quast.ToString(), "حسنا");
        //    //الاصول هنا بقى اطلع اليرت فيها القيمه ولو تمام هو عاوز يعمل جدوله اجيب الحجات الى هعملها فى زرار الدفع لما يتعمل واحطها هنا 
        //}
        private async void update_deal_in_date_now_Clicked(object sender, EventArgs e)
        {

            //remainder = pricee - given;
            var O_DataServices = new GroupService();
            int O_remainder =  Convert.ToInt32(remainder_lable.Text);
            int O_group_id = Convert.ToInt32(group_id_lable.Text);
            var o_V_Group_month_Lisst = O_DataServices.getGroup_by_Id(O_group_id).Result;
            int O_selcet_month = Convert.ToInt32(selcet_month_lable.Text);
            int o_paid_installments = Convert.ToInt32(paid_installments_lable.Text) + 1;
            var f = ((o_V_Group_month_Lisst.MonthlyProfitRate.Value * o_paid_installments) + 100) / 1000;
            int qast = Convert.ToInt32(Math.Round((O_remainder * f) / o_paid_installments) * 10);
            int new_Total_qast = qast * o_paid_installments;            
            int O_Total_Paid = Convert.ToInt32(Total_Paid_lable.Text);
            int total_remaing_quast = new_Total_qast - O_Total_Paid;

            var saved = O_remainder - (  new_Total_qast + O_Total_Paid);
            var saved_Msg = "تم خصم مبلغ " + saved.ToString() + "@";
            saved_Msg = saved_Msg.Replace("@", System.Environment.NewLine);
            var Msg = saved_Msg +  "المبلغ الكلي المطلوب دفعه   " + total_remaing_quast.ToString()  + "@"  + " هل تريد دفع الملبغ ؟" ;
            Msg = Msg.Replace("@", System.Environment.NewLine);            
            
            var s = await DisplayAlert("تنبيه", Msg , "حسنا" ," الغاء");
            if (s == true)
            {
                // تعديل بينات القسط
                var O_deal_id = Convert.ToInt32(deal_id_lable.Text);
                var O_DealServices = new DealService();
                var o_res =  O_DealServices.Get_Unpayed_installment_by_Deal_id(O_deal_id);
                if(o_res != null)
                {
                    var O_Unpayed_installment = o_res.Result;
                    O_Unpayed_installment.Collectedvalue = total_remaing_quast;
                    O_Unpayed_installment.installmedntColor = "#6A6AFF";
                    O_Unpayed_installment.InstallmentPaymentDate = DateTime.Now;
                    O_Unpayed_installment.installment_condition = true;

                    var update_res = await O_DealServices.Update_installment(O_Unpayed_installment);
                    var O_deal =  await O_DealServices.GetdealDital(O_deal_id);
                    if (O_deal != null)
                    {
                        O_deal.Total_Saved = saved.ToString();
                        O_deal.Deal_condition  = true;
                        var update_deal = await O_DealServices.Update_Deal(O_deal);



                        if (update_deal != 0)
                        {
                            int Total_Paid_and_given = new_Total_qast + Convert.ToInt32(product_given_Lable.Text);
                            if (Total_Paid_and_given > Convert.ToInt32(product_Price_Lable.Text))
                            {
                                int o_amount = Total_Paid_and_given - Convert.ToInt32(product_Price_Lable.Text);
                                //ابحث عن الاي دي لو مش لقيت  هعمل انشاء واحد جديد لو لقيت اعمل تحديث
                                var o_dataservices_smallEarnings = new smallEarningsService();
                                var existing_smallEarnings = o_dataservices_smallEarnings.Get_smallEarnings(O_deal_id).Result;
                                if (existing_smallEarnings != null)
                                {
                                    //تحديث
                                    existing_smallEarnings.amount = o_amount;
                                    existing_smallEarnings.date = DateTime.Now;

                                    var smallEarnings_Update_res = o_dataservices_smallEarnings.Update_smallEarnings(existing_smallEarnings);
                                }
                                else
                                {
                                    //انشاء جديد
                                    var note_msg = " ";
                                    var New_smallEarnings = new Data.smallEarnings
                                    {
                                        amount = o_amount,
                                        date = DateTime.Now,
                                        note = note_msg,
                                        deal_id = O_deal_id,
                                    };

                                    var smallEarnings_Create_res = o_dataservices_smallEarnings.Create_smallEarnings(New_smallEarnings);

                                }

                            }

                            MessagingCenter.Send("Ubdate", "UbdateListView", "Success");

                            DependencyService.Get<IMessage>().LongAlert("أنتهت الصفقة وتم أرشفتها");
                            Navigation.PushAsync(new Views.installment());
                        }
                    }
                }
            }



            
            //الاصول هنا بقى اطلع اليرت فيها القيمه ولو تمام هو عاوز يعمل جدوله اجيب الحجات الى هعملها فى زرار الدفع لما يتعمل واحطها هنا 
            //فى الجدوبة الى انا فهمه ان الى هيتم كالتالى .... اولا دى اسمها جدولة يعنى مافيش حاجه اسمها انى اخد منه قيمه المبلغ 
            //لا المبلغ المطلوب لاما يدفع لاما شكرا ... 
            //ثانيا لو هو خلاص هيدفع فا لو في قسط مطلوب منه 
            //فى عندى كذه حاجه 
            // ممكن اضيف فى بينات الصفقة تمت الجدولة او لا ... او ممكن اعمل ان القيمه المدفوعه فى القسط هي كذة وخلاص واعدل فى باقى بينات الصفقه الى هو المبلغ المدفوع والمتبقى 
        }

        private async void shareBtn_Clicked(object sender, EventArgs e)
        {
            var msg =
                "تقرير مفصل للعميل " + "@"
                +"أسم العميل  / " + name_Lable.Text + "@"
                + "رقم هاتف  / " + phone1_Lable.Text + "@" +
                "رقم البطاقة  / " + IDnum_Lable.Text + "@" +                
                "أسم المنتج  / " + product_Name_Lable.Text + "@" +
                "سعر المنتج  / " + product_Price_Lable.Text + "@" +
                " المقدم   / " + product_given_Lable.Text + "@" +
                "تاريخ بداية التقسيط  / " + Start_Date_Lable.Text + "@" +
                "مدة التقسيط  / " + selcet_month_lable.Text + "@" +
                "القسط الشهري  / " + installment_amount_Lable.Text + "@" +
                "عدد الاقساط المدفوعة  / " + paid_installments_lable.Text + "@" +
                "عدد الاقساط المتبقية  / " + remaining_installments_Lable.Text + "@" +
                "المبلغ المدفوع  / " + Total_Paid_lable.Text + "@" +
                "المبلغ المتبقى  / " + Total_Remaining_Lable.Text + "@" +
                "المبلغ المقسط  / " + remainder_lable.Text + "@" +
                "الاجمالى   / " + Total_installment_Lable.Text + "@";


            msg = msg.Replace("@", System.Environment.NewLine);
            await Share.RequestAsync(new ShareTextRequest
            {
                Text = msg ,
                Title = "تقرير مفصل ",
            }).ConfigureAwait(true);
        }
    }
}