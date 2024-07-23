using System.Configuration;
using System.Data;
using System.Windows;

namespace Wingspan
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            Thread t = new Thread(() =>
            {
                Thread.Sleep(5000);
                View.SetCurrent(new AttributeTargets());
            });
            t.Start();
        }
    }
}
