using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Modularity;

namespace University.Common.Module
{
    [Module(ModuleName = "ModuleBase", OnDemand = false)]
    public class ModuleBase : IModule
    {
        public void Initialize()
        {

        }
    }
}
