using System;
using System.Linq;
using Prism;
using Prism.DryIoc;
using Prism.Ioc;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinCommunityToolkitCatalog
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer) : base(initializer)
        {
        }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("NavigationPage/MainPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            var viewTypes = GetType().Assembly.DefinedTypes.Where(t => t.IsSubclassOf(typeof(Page)));
            foreach (var viewType in viewTypes)
            {
                containerRegistry.RegisterForNavigation(viewType, viewType.Name);
            }

            containerRegistry.RegisterForNavigation<NavigationPage>();
        }
    }
}
