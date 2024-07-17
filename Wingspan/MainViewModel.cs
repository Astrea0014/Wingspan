using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wingspan.ViewModels;

namespace Wingspan
{
	internal static class View
	{
        public static readonly MainPageViewModel MainPage = new();
    }

    internal class MainViewModel : ObservableObject
    {
		private object _currentView;
		public object CurrentView // The ContentControl displays the View associated with the ViewModel given to this property.
		{
			get => _currentView;
			set
			{
				_currentView = value;
				OnPropertyChanged();
			}
		}

		public MainViewModel() => _currentView = View.MainPage; // During DataContext construction you can set _currentView directly, without calling OnPropertyChanged.
    }
}
