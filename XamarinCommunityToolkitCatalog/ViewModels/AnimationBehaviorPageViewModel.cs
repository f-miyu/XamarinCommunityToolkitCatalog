using System;
using System.Windows.Input;
using Prism.Commands;
using Xamarin.Forms;

namespace XamarinCommunityToolkitCatalog.ViewModels
{
    public class AnimationBehaviorPageViewModel
    {
        private ICommand _finishedCommand;
        public ICommand FinishedCommand => _finishedCommand ??=
            new DelegateCommand<object>(param =>
            {
                if (param == null)
                {
                    System.Diagnostics.Debug.WriteLine("finished");
                }
            });
    }
}
