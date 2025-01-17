﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using qastly.Models;
using Xamarin.Forms;
using PropertyChanged;

namespace qastly.ViewModels
{
	[AddINotifyPropertyChangedInterfaceAttribute]
	public class TestListViewMultiSelectItemsViewModel
    {
		public ObservableCollection<Model> Items { get; set; }
		public int SelectedItemsCounter { get; set; } = 0;

		public TestListViewMultiSelectItemsViewModel()
		{

			Items = new ObservableCollection<Model>();
			Items.Add(new Model() { DisplayName = "AAA", Selected = false });
			Items.Add(new Model() { DisplayName = "BBB", Selected = false });
			Items.Add(new Model() { DisplayName = "CCC", Selected = false });
			Items.Add(new Model() { DisplayName = "DDD", Selected = false });
			Items.Add(new Model() { DisplayName = "EEE", Selected = false });

			ItemTappedCommand = new Command((object model) => {

				if (model != null && model is ItemTappedEventArgs)
				{
					if (!((Model)((ItemTappedEventArgs)model).Item).Selected)
						SelectedItemsCounter++;
					else
						SelectedItemsCounter--;

					((Model)((ItemTappedEventArgs)model).Item).Selected = !((Model)((ItemTappedEventArgs)model).Item).Selected;
				}
			});
		}

		public ICommand ItemTappedCommand { get; protected set; }

	}
}
