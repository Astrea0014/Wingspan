using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Animation;

namespace Wingspan
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Storyboard FadeOutAnimation { get; }
        public Storyboard FadeInAnimation { get; }

        private MainViewModel CastDataContext => DataContext as MainViewModel ?? throw new InvalidOperationException();

        public MainWindow()
        {
            InitializeComponent();

            FadeOutAnimation = (Storyboard)FindResource("FadeOutAnimation");
            FadeInAnimation = (Storyboard)FindResource("FadeInAnimation");
        }

        private void TopBorder_OnMouseDown(object sender, MouseButtonEventArgs e) => DragMove();
        private void MinimizeButton_OnClick(object sender, RoutedEventArgs e) => WindowState = WindowState.Minimized;
        private void ExitButton_OnClick(object sender, RoutedEventArgs e) => Application.Current.Shutdown(0);

        public void SetCurrentView(object viewModel)
        {
            EventHandler? handler = null;
            handler = (o, e) =>
            {
                FadeOutAnimation.Completed -= handler;
                CastDataContext.CurrentView = viewModel;
                FadeInAnimation.Begin();
            };
            FadeOutAnimation.Completed += handler;
            FadeOutAnimation.Begin();
        }
    }
}