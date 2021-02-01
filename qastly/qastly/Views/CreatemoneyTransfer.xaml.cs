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
    public partial class CreatemoneyTransfer 
    {
        public CreatemoneyTransfer()
        {
            InitializeComponent();
            var dt = DateTime.Now;
            DateePickerbtn.Text = String.Format("{0:yyyy/MM/dd}", dt);                        
        }

        private void Fundspickerbtn_one_Clicked(object sender, EventArgs e)
        {
            Fundspicker_one.Focus();

        }

        private void Fundspicker_one_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Funds = Fundspicker_one.Items[Fundspicker_one.SelectedIndex];
            Fundspickerbtn_one.Text = Funds;            
        }

        private void Fundspickerbtn_Two_Clicked(object sender, EventArgs e)
        {
            Fundspicker_Two.Focus();

        }
        private void Fundspicker_Two_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Funds = Fundspicker_Two.Items[Fundspicker_Two.SelectedIndex];
            Fundspickerbtn_Two.Text = Funds;
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