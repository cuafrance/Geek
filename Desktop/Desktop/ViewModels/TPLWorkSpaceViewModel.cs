using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;

namespace Desktop.Main.ViewModels
{
    public class TPLWorkSpaceViewModel:BindableBase
    {
        private readonly IEventAggregator _eventAggregator;
        string _log;
        public string Log
        {
            get { return _log; }
            set
            {
                SetProperty(ref _log ,value);
                _eventAggregator.GetEvent<PubSubEvent<string>>().Publish(_log);
            }
        }

        public ICommand ThreadSleepCommand { get; set; }
        public ICommand TaskDelayCommand { get; set; }
        public ICommand CancelTaskDelayCommand { get; set; }

        public TPLWorkSpaceViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
            ThreadSleepCommand = new DelegateCommand(ThreadSleep);
        }

        private void ThreadSleep()
        {
            Log = "";
            TaskA();
            Log += String.Format("{0} Begin sleep",DateTime.Now.ToLongTimeString()) + Environment.NewLine;
            Thread.Sleep(1500);
            Log += String.Format("{0} End sleep", DateTime.Now.ToLongTimeString()) + Environment.NewLine;
        }


        void TaskA()
        {
            Log += String.Format("{0} Task A executed", DateTime.Now.ToLongTimeString()) +Environment.NewLine;
        }

        void TaskB()
        {
            Log += String.Format("{0} Task B executed", DateTime.Now.ToLongTimeString()) + Environment.NewLine;
        }

        void TaskC()
        {
            Log += String.Format("{0} Task B executed", DateTime.Now.ToLongTimeString()) + Environment.NewLine;
        }
    }
}
