using System.Windows.Input;
using Microsoft.Practices.Prism.Mvvm;
using Prism.Commands;
using Prism.Interactivity.InteractionRequest;

namespace University.Desktop.ViewModels
{
    public class MainWindowViewModel:BindableBase
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

        public DelegateCommand HelpCommand { get; set; }
        public DelegateCommand OpenCommand { get; set; }

        public InteractionRequest<INotification> NotificationRequest { get; set; }
        public InteractionRequest<IConfirmation> ConfirmationRequest { get; set; }
        public InteractionRequest<INotification> CustomPopupRequest { get; set; }
        public ICommand NotificationCommand { get; set; }
        public ICommand ConfirmationCommand { get; set; }
        public ICommand CustomPopupCommand { get; set; }

        public MainWindowViewModel()
        {
            Title = "Hello World";
            Status = "Nothing";
            HelpCommand = new DelegateCommand(OpenHelpWindow);
            OpenCommand = new DelegateCommand(OpenDialog);

            NotificationRequest = new InteractionRequest<INotification>();

            NotificationCommand = new DelegateCommand(RaiseNotif);
            ConfirmationRequest = new InteractionRequest<IConfirmation>();
            ConfirmationCommand = new DelegateCommand(RaiseConfirm);

            CustomPopupRequest = new InteractionRequest<INotification>();
            CustomPopupCommand = new DelegateCommand(ShowCustomPopup);

        }

        private void ShowCustomPopup()
        {
            CustomPopupRequest.Raise(new Notification(){Title = "Custom Popup",Content = "This is an example of custom popup"},r=>Status="Good to go!");
        }

        private void RaiseConfirm()
        {
            ConfirmationRequest.Raise(new Confirmation(){Content = "This is an example of confirmation",Title = "Confirmation"},x=>Status=x.Confirmed? "Confirmation!":"Cancel!");
        }

        private void RaiseNotif()
        {
            NotificationRequest.Raise(new Notification(){Title = "Notification", Content = "This is an example of notification"},x=>Status= "Notification raised!");
        }

        private void OpenDialog()
        {
            throw new System.NotImplementedException();
        }

        private void OpenHelpWindow()
        {
            throw new System.NotImplementedException();
        }
    }
}
