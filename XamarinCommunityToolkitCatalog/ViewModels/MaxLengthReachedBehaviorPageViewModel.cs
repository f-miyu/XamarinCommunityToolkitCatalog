using System;
using System.Windows.Input;
using Prism.Commands;

namespace XamarinCommunityToolkitCatalog.ViewModels
{
    public class MaxLengthReachedBehaviorPageViewModel
    {
        private ICommand _maxLengthReachedCommand;
        public ICommand MaxLengthReachedCommand => _maxLengthReachedCommand ??=
            new DelegateCommand<string>(text => System.Diagnostics.Debug.WriteLine(text));
    }
}
