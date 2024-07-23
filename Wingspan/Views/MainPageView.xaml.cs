using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Wingspan.ViewModels;

namespace Wingspan.Views
{
    /// <summary>
    /// Interaction logic for MainPageView.xaml
    /// </summary>
    public partial class MainPageView : UserControl
    {
        new MainPageViewModel DataContext { get => (MainPageViewModel)((UserControl)this).DataContext; }

        public MainPageView()
        {
            InitializeComponent();
        }

        private void Hyperlink_OnClick(object sender, RoutedEventArgs e)
        {
            ProcessStartInfo startInfo = new("https://github.com/Astrea0014/Throwback-FAQ/wiki") // Temporary link.
            {
                UseShellExecute = true
            };
            Process.Start(startInfo);
        }
    }
}
