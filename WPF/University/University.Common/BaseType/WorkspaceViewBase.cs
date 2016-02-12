using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Prism.Regions;

namespace University.Common.BaseType
{
    public class WorkspaceViewBase : UserControl, IRegionMemberLifetime
    {
        protected bool _KeepAlive = true;
        public bool KeepAlive
        {
            get { return _KeepAlive; }
        }

        protected string _ViewName = "";
        public string ViewName
        {
            get { return _ViewName; }
        }
    }
}
