using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Lab8_Lavrov_DS6_only
{
    public partial class MainPage : ContentPage // Клас сторінки MainPage, що відображає топ-3 шахістів
    {
        public MainPage() // Конструктор класу MainPage
        {
            Title = "Top 3 CHESS players"; // Встановлення заголовка сторінки

            var scrollView = new ScrollView(); // Створення об'єкту прокрутки
            var stackLayout = new StackLayout(); // Створення вертикального розміщення
            scrollView.Content = stackLayout; // Встановлення вертикального розміщення як вмісту прокрутки
            Content = scrollView; // Встановлення прокрутки як вмісту сторінки

            var players = new[] // Масив даних про гравців (ім'я, опис, URL зображення)
            {
                new { Name = "Magnus Carlsen", Description = "Магнус Карлсен...", ImageUrl = "https://images.chesscomfiles.com/uploads/v1/master_player/3b0ddf4e-bd82-11e8-9421-af517c2ebfed.23bcb9e8.160x160o.827f073930a6.jpg" },
                new { Name = "Fabiano Caruana", Description = "Фабіано Каруана...", ImageUrl = "https://images.chesscomfiles.com/uploads/v1/master_player/c66cb17a-c005-11e8-886b-692f3468f8e7.b4d2d0e5.160x160o.a7fdc9487714.jpg" },
                new { Name = "Hikaru Nakamura", Description = "Хікару Накамура...", ImageUrl = "https://images.chesscomfiles.com/uploads/v1/master_player/5c8147c2-bd7f-11e8-863f-15ded6970bf6.e234e103.250x250o.70ca1cbc7be1.jpg" }
            };

            foreach (var player in players) // Перебір кожного гравця у масиві
            {
                var frame = new Frame { Margin = new Thickness(0, 0, 0, 10) }; // Створення рамки для відображення кожного гравця

                var grid = new Grid(); // Створення сітки для розміщення зображення та кнопки
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(100, GridUnitType.Auto) }); // Додавання визначення стовпця для зображення, GridUnitType.Auto, означає, що ширина стовпця буде автоматично регулюватись відповідно до вмісту.
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }); // Додавання визначення стовпця для решти вмісту

                var image = new Image { Source = player.ImageUrl, WidthRequest = 100, HeightRequest = 100, Aspect = Aspect.AspectFill, VerticalOptions = LayoutOptions.Center }; // Створення зображення гравця
                Grid.SetColumn(image, 0); // Встановлення позиції зображення у сітці

                var stack = new StackLayout { VerticalOptions = LayoutOptions.Center, HorizontalOptions = LayoutOptions.Start }; // Створення вертикального розміщення для тексту та кнопки
                stack.Children.Add(new Label { Text = player.Name }); // Додавання тексту з ім'ям гравця
                stack.Children.Add(new Button { Text = "DETAILS", Command = new Command(() => ShowDetails(player.Name, player.Description, player.ImageUrl)) }); // Додавання кнопки "DETAILS" з обробником кліків
                Grid.SetColumn(stack, 1); // Встановлення позиції вертикального розміщення у сітці

                grid.Children.Add(image); // Додавання зображення до сітки
                grid.Children.Add(stack); // Додавання вертикального розміщення до сітки

                frame.Content = grid; // Встановлення сітки як вмісту рамки
                stackLayout.Children.Add(frame); // Додавання рамки до вертикального розміщення
            }
        }

        async void ShowDetails(string title, string description, string imageUrl) // Метод для показу докладної інформації про гравця
        {
            await Navigation.PushAsync(new DetailsPage(title, description, imageUrl)); // Відкриття нової сторінки з даними гравця
        }
    }
}
