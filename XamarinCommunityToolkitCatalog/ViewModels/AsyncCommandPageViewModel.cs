using System;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.ObjectModel;

namespace XamarinCommunityToolkitCatalog.ViewModels
{
    public class AsyncCommandPageViewModel
    {
        private IAsyncCommand _asyncCommand;
        public IAsyncCommand AsyncCommand => _asyncCommand ??=
            new AsyncCommand(async () =>
            {
                await Task.Delay(1000);
            }, allowsMultipleExecutions: false);
    }
}
