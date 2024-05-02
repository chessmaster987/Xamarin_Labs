using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Lab8_Lavrov_DS6_only
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            Title = "Top 3 CHESS players";

            var scrollView = new ScrollView();
            var stackLayout = new StackLayout();
            scrollView.Content = stackLayout;
            Content = scrollView;

            var players = new[]
            {
                new { Name = "Magnus Carlsen", Description = "Магнус Карлсен...", ImageUrl = "https://images.chesscomfiles.com/uploads/v1/master_player/3b0ddf4e-bd82-11e8-9421-af517c2ebfed.23bcb9e8.160x160o.827f073930a6.jpg" },
                new { Name = "Fabiano Caruana", Description = "Фабіано Каруана...", ImageUrl = "https://images.chesscomfiles.com/uploads/v1/master_player/c66cb17a-c005-11e8-886b-692f3468f8e7.b4d2d0e5.160x160o.a7fdc9487714.jpg" },
                new { Name = "Hikaru Nakamura", Description = "Хікару Накамура...", ImageUrl = "https://images.chesscomfiles.com/uploads/v1/master_player/5c8147c2-bd7f-11e8-863f-15ded6970bf6.e234e103.250x250o.70ca1cbc7be1.jpg" }
            };

            foreach (var player in players)
            {
                var frame = new Frame { Margin = new Thickness(0, 0, 0, 10) };

                var grid = new Grid();
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(100, GridUnitType.Auto) });
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

                var image = new Image { Source = player.ImageUrl, WidthRequest = 100, HeightRequest = 100, Aspect = Aspect.AspectFill, VerticalOptions = LayoutOptions.Center };
                Grid.SetColumn(image, 0);

                var stack = new StackLayout { VerticalOptions = LayoutOptions.Center, HorizontalOptions = LayoutOptions.Start };
                stack.Children.Add(new Label { Text = player.Name });
                stack.Children.Add(new Button { Text = "DETAILS", Command = new Command(() => ShowDetails(player.Name, player.Description, player.ImageUrl)) });
                Grid.SetColumn(stack, 1);

                grid.Children.Add(image);
                grid.Children.Add(stack);

                frame.Content = grid;
                stackLayout.Children.Add(frame);
            }
        }

        async void ShowDetails(string title, string description, string imageUrl)
        {
            await Navigation.PushAsync(new DetailsPage(title, description, imageUrl));
        }
    }
}
