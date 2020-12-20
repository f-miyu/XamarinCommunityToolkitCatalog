using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Prism.Commands;
using Prism.Mvvm;
using Xamarin.CommunityToolkit.UI.Views;

namespace XamarinCommunityToolkitCatalog.ViewModels
{
    public class StateLayoutPageViewModel : BindableBase
    {
        private LayoutState _currentState;
        public LayoutState CurrentState
        {
            get => _currentState;
            set => SetProperty(ref _currentState, value);
        }

        private string _customState;
        public string CustomState
        {
            get => _customState;
            set => SetProperty(ref _customState, value);
        }

        private ICommand _cycleStatesCommand;
        public ICommand CycleStatesCommand => _cycleStatesCommand ??=
            new DelegateCommand(async () =>
            {
                CurrentState = LayoutState.Loading;
                await Task.Delay(TimeSpan.FromSeconds(1));

                CurrentState = LayoutState.Saving;
                await Task.Delay(TimeSpan.FromSeconds(1));

                CurrentState = LayoutState.Success;
                await Task.Delay(TimeSpan.FromSeconds(1));

                CurrentState = LayoutState.Error;
                await Task.Delay(TimeSpan.FromSeconds(1));

                CurrentState = LayoutState.Empty;
                await Task.Delay(TimeSpan.FromSeconds(1));

                CurrentState = LayoutState.Custom;
                CustomState = "CustomState";
                await Task.Delay(TimeSpan.FromSeconds(1));

                CurrentState = LayoutState.None;
                CustomState = null;
            });
    }
}
