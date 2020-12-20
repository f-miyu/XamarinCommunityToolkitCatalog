using System;
using System.Collections.Generic;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.Forms;

namespace XamarinCommunityToolkitCatalog.Views
{
    public partial class ToastPage : ContentPage
    {
        public ToastPage()
        {
            InitializeComponent();
        }

        void ToastClicked(System.Object sender, System.EventArgs e)
        {
            this.DisplayToastAsync("Toast");
        }
    }
}
