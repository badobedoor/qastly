using qastly.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using qastly.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace qastly.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CostomarDetailPhoto : ContentPage
    {
        public CostomarDetailPhoto()
        {
            InitializeComponent();
            //BindingContext = new MainViewModel();
            //Costomar_photo.Source = ImageSource.FromFile(l.Text);
        }

        private void CarouselView_CurrentItemChanged(object sender, CurrentItemChangedEventArgs e)
        {
            var s = e.CurrentItem as Data.V_photo_costomar;
            var i = s.photo_id;
            photo_id_Lable.Text = i.ToString();
            Path_Lable.Text = e.CurrentItem.ToString();
            

        }
    }
}