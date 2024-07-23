namespace Wingspan.ViewModels
{
    internal class MainPageViewModel : ObservableObject, IHollowConstructible<MainPageViewModel>
    {
        public MainPageViewModel() { }
        private MainPageViewModel(HollowConstructType _) { } // Part of IHollowConstructible interface implementation.

        bool _isUnsupported = false;

        public bool IsUnsupported
        {
            get => _isUnsupported;
            set
            {
                _isUnsupported = value;
                OnPropertyChanged();
            }
        }

        public static MainPageViewModel HollowConstruct() => new(ViewManager.Hollow);
	}
}
