using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using qastly.Models;
using qastly.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace qastly.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]    
    public partial class CreateGroup 
    {
        public ObservableCollection<string> group_month_Num_Items;
        public ObservableCollection<string> Items { get; set; }
        public CreateGroup()
        {
            InitializeComponent();
            //BindingContext = new MainViewModel();
            get_group_month_Num_data();
            Month_Num_listView.ItemsSource = Items;

        }


        private void Check_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (group_month_Num_Items != null)
            {
                var cbox = (CheckBox)sender;
                //var s = Month_Num_listView.SelectedItem;
                var BindContext = (string)cbox.BindingContext;

                var o_DisplaymonthNum = BindContext;
                var o_Items = group_month_Num_Items.FirstOrDefault(x => x == o_DisplaymonthNum);
                if (o_Items != null)
                {
                    var resIndex = group_month_Num_Items.IndexOf(o_Items);
                    group_month_Num_Items.RemoveAt(resIndex);
                    ListdebtSum_picker.ItemsSource = group_month_Num_Items;
                }
                else
                {
                    group_month_Num_Items.Add(o_DisplaymonthNum);
                    ListdebtSum_picker.ItemsSource = group_month_Num_Items;
                }
            }
            else
            {
                var cbox = (CheckBox)sender;
                var BindContext = (string)cbox.BindingContext;

                var o_DisplaymonthNum = BindContext;
                group_month_Num_Items = new ObservableCollection<string> { o_DisplaymonthNum };
                ListdebtSum_picker.ItemsSource = group_month_Num_Items;
            }
           

        }

        
        public void get_group_month_Num_data()
        {

            Items = new ObservableCollection<string>() 
            {
                "1",
                "2",
                "3",
                "4",
                "5",
                "6",
                "7",
                "8",
                "9",
                "10",
                "11",
                "12",
                "13",
                "14",
                "15",
                "16",
                "17",
                "18",
                "19",
                "20",
                "21",
                "22",
                "23",
                "24",
                "25",
                "26",
                "27",
                "28",
                "29",
                "30",
                "31",
                "32",
                "33",
                "34",
                "35",
                "36",
            };
            //Items.Add(new Data.group_month_Num() { DisplaymonthNum = "كل", Selected = true });
            //Items.Add(new Data.group_month_Num() { DisplaymonthNum = "1", Selected = false });
            //Items.Add(new Data.group_month_Num() { DisplaymonthNum = "2", Selected = false });
            //Items.Add(new Data.group_month_Num() { DisplaymonthNum = "3", Selected = false });
            //Items.Add(new Data.group_month_Num() { DisplaymonthNum = "4", Selected = false });
            //Items.Add(new Data.group_month_Num() { DisplaymonthNum = "5", Selected = false });
            //Items.Add(new Data.group_month_Num() { DisplaymonthNum = "6", Selected = false });
            //Items.Add(new Data.group_month_Num() { DisplaymonthNum = "7", Selected = false });
            //Items.Add(new Data.group_month_Num() { DisplaymonthNum = "8", Selected = false });
            //Items.Add(new Data.group_month_Num() { DisplaymonthNum = "9", Selected = false });
            //Items.Add(new Data.group_month_Num() { DisplaymonthNum = "10", Selected = false });
            //Items.Add(new Data.group_month_Num() { DisplaymonthNum = "11", Selected = false });
            //Items.Add(new Data.group_month_Num() { DisplaymonthNum = "12", Selected = false });
            //Items.Add(new Data.group_month_Num() { DisplaymonthNum = "13", Selected = false });
            //Items.Add(new Data.group_month_Num() { DisplaymonthNum = "14", Selected = false });
            //Items.Add(new Data.group_month_Num() { DisplaymonthNum = "15", Selected = false });
            //Items.Add(new Data.group_month_Num() { DisplaymonthNum = "16", Selected = false });
            //Items.Add(new Data.group_month_Num() { DisplaymonthNum = "17", Selected = false });
            //Items.Add(new Data.group_month_Num() { DisplaymonthNum = "18", Selected = false });
            //Items.Add(new Data.group_month_Num() { DisplaymonthNum = "19", Selected = false });
            //Items.Add(new Data.group_month_Num() { DisplaymonthNum = "20", Selected = false });
            //Items.Add(new Data.group_month_Num() { DisplaymonthNum = "21", Selected = false });
            //Items.Add(new Data.group_month_Num() { DisplaymonthNum = "22", Selected = false });
            //Items.Add(new Data.group_month_Num() { DisplaymonthNum = "23", Selected = false });
            //Items.Add(new Data.group_month_Num() { DisplaymonthNum = "24", Selected = false });
            //Items.Add(new Data.group_month_Num() { DisplaymonthNum = "25", Selected = false });
            //Items.Add(new Data.group_month_Num() { DisplaymonthNum = "26", Selected = false });
            //Items.Add(new Data.group_month_Num() { DisplaymonthNum = "27", Selected = false });
            //Items.Add(new Data.group_month_Num() { DisplaymonthNum = "28", Selected = false });
            //Items.Add(new Data.group_month_Num() { DisplaymonthNum = "29", Selected = false });
            //Items.Add(new Data.group_month_Num() { DisplaymonthNum = "30", Selected = false });
            //Items.Add(new Data.group_month_Num() { DisplaymonthNum = "31", Selected = false });
            //Items.Add(new Data.group_month_Num() { DisplaymonthNum = "32", Selected = false });
            //Items.Add(new Data.group_month_Num() { DisplaymonthNum = "33", Selected = false });
            //Items.Add(new Data.group_month_Num() { DisplaymonthNum = "34", Selected = false });
            //Items.Add(new Data.group_month_Num() { DisplaymonthNum = "35", Selected = false });
            //Items.Add(new Data.group_month_Num() { DisplaymonthNum = "36", Selected = false });



        }
    }
}