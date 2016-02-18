using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Events;
using Prism.Mvvm;

namespace Desktop.Main.ViewModels
{
    public class TPLDashBoardViewModel:BindableBase
    {
        private IEventAggregator _eventAggregator;
        string _log;

        public TPLDashBoardViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
            _eventAggregator.GetEvent<PubSubEvent<string>>().Subscribe((workspaceLog) => Log += workspaceLog,ThreadOption.UIThread,true);
        }

        public string Log
        {
            get { return _log; }
            set { SetProperty(ref _log,value); }
        }

    }
}
