using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
namespace ImageDemo
{
    public partial class App : Application
    {
        public App()
        {
            var xamlTab = new TabbedPage();
            xamlTab.Children.Add(new LocalImages { Title = "Local" });
            xamlTab.Children.Add(new DownloadImages
            { Title = "Downloaded" });
            xamlTab.Children.Add(new EmbImages
            { Title = "Embedded" });
            xamlTab.Children.Add(new GIFImages
            { Title = "GIF Files" });
            MainPage = xamlTab;
        }
    }
}