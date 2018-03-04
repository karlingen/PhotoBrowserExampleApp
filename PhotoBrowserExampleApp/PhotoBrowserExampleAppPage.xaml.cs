using System;
using Xamarin.Forms;

namespace PhotoBrowserExampleApp
{
    public partial class PhotoBrowserExampleAppPage : ContentPage
    {
        public static int currentImageId { get; set; } = 50;

        public PhotoBrowserExampleAppPage()
        {
            InitializeComponent();

            updateImage();
        }

        void HandleLeftButtonClicked(object sender, System.EventArgs e)
        {
            currentImageId--;
            updateImage();
        }

        void HandleRightButtonClicked(object sender, System.EventArgs e)
        {
            currentImageId++;
            updateImage();
        }

        private void updateImage()
        {
            image.Source = new UriImageSource
            {
                Uri = new Uri($"https://picsum.photos/1920/1080?image={currentImageId}"),
                CachingEnabled = true
            };
        }
    }
}
