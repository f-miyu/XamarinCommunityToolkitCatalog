using System;
using System.Windows.Input;
using Prism.Commands;

namespace XamarinCommunityToolkitCatalog.ViewModels
{
    public class EventToCommandBehaviorPageViewModel
    {
        private ICommand _clickedCommand;
        public ICommand ClickedCommand => _clickedCommand ??=
            new DelegateCommand(() => System.Diagnostics.Debug.WriteLine("clicked"));
    }
}
