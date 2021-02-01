﻿using qastly.ViewModels;
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
    public partial class testselcteditem : ContentPage
    {
        public testselcteditem()
        {
            InitializeComponent();
            this.BindingContext = new TestListViewMultiSelectItemsViewModel();
        }
    }
}