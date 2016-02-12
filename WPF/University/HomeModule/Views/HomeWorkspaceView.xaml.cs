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
using University.Common.BaseType;

namespace HomeModule.Views
{
    /// <summary>
    /// Interaction logic for HomeWorkspaceView.xaml
    /// </summary>
    public partial class HomeWorkspaceView : WorkspaceViewBase
    {
        public HomeWorkspaceView()
        {
            InitializeComponent();
            this._ViewName = "HomeWorkspaceView";
        }
    }
}
