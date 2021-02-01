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
    public partial class PayDebt
    { 
        public PayDebt()
        {
            InitializeComponent();
            var dt = DateTime.Now;
            DateePickerbtn.Text = String.Format("{0:yyyy/MM/dd}", dt);
        }



        private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            var dt = e.NewDate;
            DateePickerbtn.Text = String.Format("{0:yyyy/MM/dd}", dt);
        }

        private void DateePickerbtn_Clicked(object sender, EventArgs e)
        {
            DateePicker.Focus();
        }
    }
}