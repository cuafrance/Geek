using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;

namespace University.Desktop.ViewModels
{
    public class MainRibbonWindowViewModel:BindableBase
    {
        private string _title;

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private string _status;

        public string Status
        {
            get { return _status; }
            set { SetProperty(ref _status, value); }
        }

        public MainRibbonWindowViewModel()
        {
            _title = "Example Ribbon Window";
            _status = "Nothing";
        }
    }
}
