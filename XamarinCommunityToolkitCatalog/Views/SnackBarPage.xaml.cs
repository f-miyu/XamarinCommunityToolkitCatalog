using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.Forms;

namespace XamarinCommunityToolkitCatalog.Views
{
    public partial class SnackBarPage : ContentPage
    {
        public SnackBarPage()
        {
            InitializeComponent();
        }

        void SnackBarClicked(System.Object sender, System.EventArgs e)
        {
            this.DisplaySnackBarAsync("SnackBar", "Action", () => Task.CompletedTask);
        }
    }
}
