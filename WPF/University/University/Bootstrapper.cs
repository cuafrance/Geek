using System.Windows;
using Prism.Logging;
using Prism.Unity;
using University.Desktop.Logs;
using University.Desktop.Views;

namespace University.Desktop
{
    public class Bootstrapper:UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.TryResolve<MainWindow>();
        }

        protected override void InitializeShell()
        {
            base.InitializeShell();

            Application.Current.MainWindow = (Window)Shell;
            Application.Current.MainWindow.Show();

            RegisterTypeIfMissing(typeof(ILoggerFacade), typeof(FileLogger), true);
        }

        public override void Run(bool runWithDefaultConfiguration)
        {
            base.Run(runWithDefaultConfiguration);
        }

    }
}
