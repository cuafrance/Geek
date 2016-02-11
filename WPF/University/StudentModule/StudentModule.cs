using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using Prism.Modularity;
using Prism.Regions;
namespace StudentModule
{
        
    [Module(ModuleName = "StudentModule", OnDemand = false)]
    public class StudentModule:IModule
    {
        private IUnityContainer _container;
        private IRegionManager _regionManager;

        public StudentModule(IUnityContainer container, IRegionManager regionManager)
        {
            _container = container;
            _regionManager = regionManager;
        }

        public void Initialize()
        {
            throw new NotImplementedException();
        }
    }
}
