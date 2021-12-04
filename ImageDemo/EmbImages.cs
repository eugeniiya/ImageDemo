using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Reflection;


namespace ImageDemo
{
    public class EmbImages : ContentPage
    {
        public EmbImages()
        {
            var EmbedImage = new Image { Aspect = Aspect.Fill };
            EmbedImage.Source = ImageSource.FromResource(
            "ImageDemo.MyImages.beach.jpg",
            typeof(EmbImages).GetTypeInfo().Assembly);
            EmbedImage.HeightRequest = 350;
            BackgroundColor = Color.Gold;
            Content = new StackLayout
            {
                Children = {
new Label {
 Text = "Изображение как присоединенный ресурс",
FontSize = 40,
TextColor=Color.Black,
FontAttributes = FontAttributes.Bold,
HorizontalOptions = LayoutOptions.Center,
 HorizontalTextAlignment=TextAlignment.Center
},
EmbedImage
},
                Margin = new Thickness(20, 50, 20, 20),
                VerticalOptions = LayoutOptions.StartAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };
        }
    }
}