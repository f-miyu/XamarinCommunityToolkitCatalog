using System;
using System.Windows.Input;
using Prism.Commands;

namespace XamarinCommunityToolkitCatalog.ViewModels
{
    public class ItemTappedEventArgsConverterPageViewModel
    {
        private ICommand _itemTappedCommand;
        public ICommand ItemTappedCommand => _itemTappedCommand ??=
            new DelegateCommand<string>(item => System.Diagnostics.Debug.WriteLine(item));
    }
}
