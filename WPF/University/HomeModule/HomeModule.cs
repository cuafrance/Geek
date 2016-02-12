using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeModule.Views;
using Microsoft.Practices.Unity;
using Prism.Events;
using Prism.Modularity;
using Prism.Regions;
using University.Common;

namespace HomeModule
{
    [Module(ModuleName = "HomeModule",OnDemand = false)]
    [ModuleDependency("StudentModule")]
    [ModuleDependency("CourseModule")]
    public class HomeModule:IModule
    {
        private IUnityContainer _container;
        private IRegionManager _regionManager;
        private IEventAggregator _eventAggregator;
        public HomeModule(IRegionManager regionManager, IUnityContainer container, IEventAggregator eventAggregator)
        {
            _regionManager = regionManager;
            _container = container;
            _eventAggregator = eventAggregator;
        }

        public void Initialize()
        {
            _regionManager.RegisterViewWithRegion(KnownRegionNames.HeaderRegionName, typeof(HomeRibbonView));
            _regionManager.Regions[KnownRegionNames.ContentRegionName].Add(new HomeWorkspaceView(), "HomeWorkspaceView");
            _regionManager.RequestNavigate(KnownRegionNames.ContentRegionName, "HomeWorkspaceView");
        }
    }
}
