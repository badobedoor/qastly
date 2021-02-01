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
    public partial class CreateDebt 
    {
        public CreateDebt()
        {
            InitializeComponent();
            var dt = DateTime.Now;
            DateePickerbtn.Text = String.Format("{0:yyyy/MM/dd}", dt);
        }
        private void ListdebtSum_picker_Btn_Clicked(object sender, EventArgs e)
        {
            ListdebtSum_picker.Focus();

        }

        private void ListdebtSum_picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ListdebtSum_picker_Btn_text = ListdebtSum_picker.Items[ListdebtSum_picker.SelectedIndex];
            ListdebtSum_picker_Btn.Text = ListdebtSum_picker_Btn_text;
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