namespace Wingspan
{
    internal class MainViewModel : ObservableObject // Does not implement INoActionConstructible as it is not a ViewModel associated with a DataTemplate, but only used as a DataContext for MainWindow.
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
