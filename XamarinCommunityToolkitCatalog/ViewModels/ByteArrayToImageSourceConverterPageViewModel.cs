using System;
using System.IO;

namespace XamarinCommunityToolkitCatalog.ViewModels
{
    public class ByteArrayToImageSourceConverterPageViewModel
    {
        public ByteArrayToImageSourceConverterPageViewModel()
        {
            using var image = GetType().Assembly.GetManifestResourceStream("XamarinCommunityToolkitCatalog.Images.icon.png");
            using var ms = new MemoryStream();
            image.CopyTo(ms);
            ImageBytes = ms.ToArray();
        }

        public byte[] ImageBytes { get; }
    }
}
