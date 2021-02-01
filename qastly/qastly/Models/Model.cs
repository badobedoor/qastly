using PropertyChanged;
using System;

namespace qastly.Models
{
	[AddINotifyPropertyChangedInterfaceAttribute]
	public class Model
	{
		public string DisplayName { get; set; }
		public bool Selected { get; set; }	
	}
}
