using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Lab2_Lavrov_DS6
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var stackLayout = new StackLayout
            {
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            // Додавання горизонтальних StackLayout з Frame, які містять BoxView з різними кольорами
            var colors = new Color[] { Color.Red, Color.Blue, Color.Green, Color.Yellow, Color.Orange, Color.Purple, Color.Pink, Color.Teal, Color.Gray };
            string[] messages = { "Red", "Blue", "Green", "Yellow", "Orange", "Purple", "Pink", "Teal", "Gray" };
            int index = 0;
            for (int row = 0; row < 3; row++)
            {
                var horizontalStackLayout = new StackLayout { Orientation = StackOrientation.Horizontal };

                for (int column = 0; column < 3; column++)
                {
                    var frame = new Frame
                    {
                        BorderColor = Color.Black,
                        CornerRadius = 10,
                        Padding = 10,
                        Margin = new Thickness(10),
                        VerticalOptions = LayoutOptions.CenterAndExpand,
                        HorizontalOptions = LayoutOptions.CenterAndExpand
                    };

                    var boxView = new BoxView
                    {
                        BackgroundColor = colors[index],
                        WidthRequest = 80,
                        HeightRequest = 80
                    };

                    var label = new Label
                    {
                        Text = messages[index],
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.Center
                    };

                    var innerStackLayout = new StackLayout();
                    innerStackLayout.Children.Add(boxView);
                    innerStackLayout.Children.Add(label);
                    frame.Content = innerStackLayout;

                    horizontalStackLayout.Children.Add(frame);
                    index++;
                }

                stackLayout.Children.Add(horizontalStackLayout);
            }

            Content = stackLayout;
        }
    }
}
