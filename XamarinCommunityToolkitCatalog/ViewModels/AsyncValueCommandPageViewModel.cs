using System;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.ObjectModel;

namespace XamarinCommunityToolkitCatalog.ViewModels
{
    public class AsyncValueCommandPageViewModel
    {
        private IAsyncValueCommand<bool> _asyncValueCommand;
        public IAsyncValueCommand<bool> AsyncValueCommand => _asyncValueCommand ??=
            new AsyncValueCommand<bool>(async shouldDelay =>
            {
                if (shouldDelay)
                {
                    await Task.Delay(1000);
                }
            }, allowsMultipleExecutions: false);
    }
}
