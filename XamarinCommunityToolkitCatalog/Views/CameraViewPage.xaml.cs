using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinCommunityToolkitCatalog.Views
{
    public partial class CameraViewPage : ContentPage
    {
        public CameraViewPage()
        {
            InitializeComponent();
        }

        void CameraView_MediaCaptured(System.Object sender, Xamarin.CommunityToolkit.UI.Views.MediaCapturedEventArgs e)
        {
            image.Source = e.Image;
        }
    }
}
