using System.Windows;
using System.Windows.Input;
using Prism.Commands;
using Prism.Interactivity.InteractionRequest;
using Prism.Mvvm;

namespace Desktop.Main.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
        string _status;
        public string Status
        {
            get { return _status; }
            set { SetProperty(ref _status, value); }
        }

        public InteractionRequest<INotification> NotificationRequest { get; set; }
        public ICommand NotificationCommand { get; set; }

        public InteractionRequest<IConfirmation> ConfirmationRequest { get; set; }
        public ICommand ConfirmationCommand { get; set; }

        public InteractionRequest<INotification> CustomPopupRequest { get; set; }
        public ICommand CustomPopupCommand { get; set; }
        public ICommand MessageBoxCommand { get; set; }

        public MainWindowViewModel()
        {
            _title = "Main window";
            _status = "Nothing";
            NotificationRequest = new InteractionRequest<INotification>();
            NotificationCommand = new DelegateCommand(ShowNotification);

            ConfirmationRequest = new InteractionRequest<IConfirmation>();
            ConfirmationCommand = new DelegateCommand(ShowConfirmation);

            CustomPopupRequest = new InteractionRequest<INotification>();
            CustomPopupCommand = new DelegateCommand(ShowCustomPopup);

            MessageBoxCommand = new DelegateCommand(ShowMessageBox);
        }

        private void ShowMessageBox()
        {
            var ret = MessageBox.Show("Are you content?", "Example of message box", MessageBoxButton.YesNo,
                MessageBoxImage.Question, MessageBoxResult.Yes);
            Status = ret == MessageBoxResult.Yes ? "Message box return: Yes" : "Message box return: No";
        }

        private void ShowCustomPopup()
        {
            CustomPopupRequest.Raise(new Notification() { Title = "Custom", Content = "This is an example of custom popup" }, r =>
            {
                Status = "Custom popup raised";
            });
        }

        private void ShowConfirmation()
        {
            ConfirmationRequest.Raise(new Confirmation() { Title = "Confirmation", Content = "This is an example of confirmation" }, r =>
            {
                Status = r.Confirmed ? "Confirmation raised" : "Cancellation raised";
            });
        }

        private void ShowNotification()
        {
            NotificationRequest.Raise(new Notification() { Title = "Notification", Content = "This is an example of notificaiton" }, r =>
            {
                Status = "Notification raised";
            });
        }
    }
}
