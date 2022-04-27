using System;
using CommunityToolkit.Mvvm.ComponentModel;

namespace mvvmgen
{
	[INotifyPropertyChanged]
	public partial class SimpleViewModel
	{
		[ObservableProperty]
		[AlsoNotifyChangeFor(nameof(FullName))]
		string firstName;

		[ObservableProperty]
		[AlsoNotifyChangeFor(nameof(FullName))]
		string lastName;

		public string FullName => $"{firstName} {lastName}".Trim();
	}
}

