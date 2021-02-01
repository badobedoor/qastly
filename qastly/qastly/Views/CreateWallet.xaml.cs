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
    public partial class CreateWallet
    {
        public CreateWallet()
        {
            InitializeComponent();
        }

        private void Check_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if(main_funds_lab.Text == "" || main_funds_lab.Text == null || main_funds_lab.Text =="0")
            {
                main_funds_lab.Text = "1";
                //true

            }else if (main_funds_lab.Text == "1")
            {
                main_funds_lab.Text = "0";
                //false
            }

        }
    }
}