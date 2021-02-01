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
    public partial class PayInstalment 
    {
        public PayInstalment()
        {
            InitializeComponent();
            
           DateePickerbtn.Text = String.Format("{0:yyyy/MM/dd}", DateTime.Now);
        }


        private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            DateePickerbtn.Text = String.Format("{0:yyyy/MM/dd}", e.NewDate);

        }

        private void DateePickerbtn_Clicked(object sender, EventArgs e)
        {
            DateePicker.Focus();

        }

        private void pay_full_installment_BTN_Clicked(object sender, EventArgs e)
        {
            pay_installment_BTN_Frame.IsVisible = false;
            pay_installment_Entry_Frame.IsVisible = true;

            pay_full_installment_Entry.IsVisible = true;
            pay_part_installment_Entry.IsVisible = false;


        }

        private void pay_part_installment_BTN_Clicked(object sender, EventArgs e)
        {
            pay_installment_BTN_Frame.IsVisible = false;
            pay_installment_Entry_Frame.IsVisible = true;

            pay_full_installment_Entry.IsVisible = false;
            pay_part_installment_Entry.IsVisible = true;

        }

        private void Back_BTN_Clicked(object sender, EventArgs e)
        {
            pay_installment_Entry_Frame.IsVisible = false;
            pay_installment_BTN_Frame.IsVisible = true;


            pay_full_installment_Entry.IsVisible = false;
            pay_part_installment_Entry.IsVisible = false;

        }
    }
}