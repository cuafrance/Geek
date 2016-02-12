using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Ribbon;

namespace University.Common.BaseType
{
    public abstract class RibbonTabViewBase:RibbonTab
    {
        protected string _ViewName = "";
        public string ViewName
        {
            get { return _ViewName; }
        }

        protected string _PairedWorkspaceViewName = "";
        public string PairedWorkspaceViewName
        {
            get { return _PairedWorkspaceViewName; }
        }
    }
}
