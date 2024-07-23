using System.Windows;

using Wingspan.ViewModels;

namespace Wingspan
{
    internal class HollowConstructType { }

    internal class ViewManager
    {
        public static readonly HollowConstructType Hollow = new();
    }

    interface IHollowConstructible<T> where T : IHollowConstructible<T>
    {
        public static abstract T HollowConstruct();
    }

    internal static class View
    {
        public static readonly MainPageViewModel MainPage = MainPageViewModel.HollowConstruct();

        public static void SetCurrent(object viewModel)
        {
            Application app = Application.Current;
            app.Dispatcher.BeginInvoke(() => ((MainWindow)app.MainWindow).SetCurrentView(viewModel));
        }
    }
}
