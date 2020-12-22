using System;
using System.Windows.Input;
using Prism.Commands;
using Xamarin.CommunityToolkit.ObjectModel;

namespace XamarinCommunityToolkitCatalog.ViewModels
{
    public class ObservableObjectPageViewModel : ObservableObject
    {
        private int _count;
        public int Count
        {
            get => _count;
            set => SetProperty(ref _count, value);
        }

        private ICommand _countCommand;
        public ICommand CountCommand => _countCommand ??=
            new DelegateCommand(() => Count++);
    }
}
