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
    public partial class WelcomePage : ContentPage
    {
        public WelcomePage()
        {
            InitializeComponent();
        }
        private void OnSignIn(object sender, EventArgs e)
        {

            var s = App.Current.MainPage as MasterDetailPage;
            s.IsPresented = true;
        }
    }
}
