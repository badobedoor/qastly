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
    public partial class CreateCapitalAddition 
    {
        public CreateCapitalAddition()
        {
            InitializeComponent();
            DateePickerbtn.Text = DateTime.Now.ToString();

        }

        private void Fundspickerbtn_Clicked(object sender, EventArgs e)
        {
            Fundspicker.Focus();

        }

        private void Fundspicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Funds = Fundspicker.Items[Fundspicker.SelectedIndex];
            Fundspickerbtn.Text = Funds;
            //DisplayAlert("عدد الاشهر", "أنت أخترت عدد الاشهر  :-  " + month, "Ok");
        }

        private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            DateePickerbtn.Text = e.NewDate.ToString();

        }

        private void DateePickerbtn_Clicked(object sender, EventArgs e)
        {
            DateePicker.Focus();
        }

    }
}