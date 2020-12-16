using System;
using System.Windows.Input;
using Prism.Commands;

namespace XamarinCommunityToolkitCatalog.ViewModels
{
    public class ItemSelectedEventArgsConverterPageViewModel
    {
        private ICommand _itemSelectedCommand;
        public ICommand ItemSelectedCommand => _itemSelectedCommand ??=
            new DelegateCommand<string>(item => System.Diagnostics.Debug.WriteLine(item));
    }
}
