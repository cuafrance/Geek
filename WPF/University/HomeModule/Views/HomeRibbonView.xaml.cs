using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Controls.Ribbon;
using Prism.Regions;
using University.Common.BaseType;

namespace HomeModule.Views
{
    /// <summary>
    /// Interaction logic for HomeRibbonView.xaml
    /// </summary>
    [ViewSortHint("0")]
    public partial class HomeRibbonView: RibbonTabViewBase
    {
        public HomeRibbonView()
        {
            InitializeComponent();
            this._ViewName = "HomeRibbonView";
            this._PairedWorkspaceViewName = "HomeWorkspaceView";

        }
    }
}
