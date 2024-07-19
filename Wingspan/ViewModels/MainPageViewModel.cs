using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Wingspan.ViewModels
{
    internal class MainPageViewModel : ObservableObject
    {
        bool _isUnsupported = true;

        public bool IsUnsupported
        {
            get => _isUnsupported;
            set
            {
                _isUnsupported = value;
                OnPropertyChanged();
            }
        }
	}
}
