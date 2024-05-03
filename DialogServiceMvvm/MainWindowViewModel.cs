using Prism.Commands;


namespace DialogServiceMvvm
{
    public class MainWindowViewModel : Prism.Mvvm.BindableBase
    {
        // in reality is injected in a class constructor
        IDialogService _dialogService = new DialogService();
        private DelegateCommand _showDialog;
        public DelegateCommand ShowDialog => _showDialog ?? (_showDialog = new DelegateCommand(ExecuteShowDialog));
        private void ExecuteShowDialog()
        {
            //_dialogService.ShowDialog("Notification", result =>
            //{
            //    var test = result;
            //});
            _dialogService.ShowDialog<NotificationViewModel>( result =>
            {
                var test = result;
            });

        }
    }
}
