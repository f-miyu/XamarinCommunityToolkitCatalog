using System;
using System.Windows.Input;
using Prism.Commands;

namespace XamarinCommunityToolkitCatalog.ViewModels
{
    public class UserStoppedTypingBehaviorPageViewModel
    {
        private ICommand _userStoppedTypingCommand;
        public ICommand UserStoppedTypingCommand => _userStoppedTypingCommand ??=
            new DelegateCommand<string>(text => System.Diagnostics.Debug.WriteLine(text));
    }
}
