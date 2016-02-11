using System.Windows;
using HomeModule.Views;
using Prism.Logging;
using Prism.Modularity;
using Prism.Regions;
using Prism.Unity;
using University.Common;
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

            //IRegionManager regionManager = this.Container.TryResolve<IRegionManager>();
            //regionManager.Regions[KnownRegionNames.ContentRegionName].Add(new HomeView(), typeof (HomeView).Name);
            //regionManager.Regions[KnownRegionNames.HeaderRegionName].Add(new RibbonTabView(), typeof(RibbonTabView).Name);

            //regionManager.RequestNavigate(KnownRegionNames.ContentRegionName,);
            
        }

        protected override void ConfigureModuleCatalog()
        {
            base.ConfigureModuleCatalog();
            ModuleCatalog catalog = (ModuleCatalog)this.ModuleCatalog;
            catalog.AddModule(typeof (HomeModule.HomeModule));
            catalog.AddModule(typeof(StudentModule.StudentModule));
        }
    }
}
