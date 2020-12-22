using System;
using System.Linq;
using System.Windows.Input;
using Prism.Commands;
using Xamarin.CommunityToolkit.ObjectModel;

namespace XamarinCommunityToolkitCatalog.ViewModels
{
    public class ObservableRangeCollectionPageViewModel
    {
        public ObservableRangeCollection<int> Items { get; } =
            new ObservableRangeCollection<int>();

        private ICommand _addRangeCommand;
        public ICommand AddRangeCommand => _addRangeCommand ??=
            new DelegateCommand(() =>
            {
                Items.AddRange(Enumerable.Range(Items.Count, 5));
            });

        private ICommand _removeRangeCommand;
        public ICommand RemoveRangeCommand => _removeRangeCommand ??=
            new DelegateCommand(() =>
            {
                Items.RemoveRange(Items.TakeLast(5));
            });

        private ICommand _replaceRangeCommand;
        public ICommand ReplaceRangeCommand => _replaceRangeCommand ??=
            new DelegateCommand(() =>
            {
                Items.ReplaceRange(Enumerable.Range(0, 5));
            });
    }
}
