using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab8_Lavrov_DS6
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailsPage : ContentPage
    {
        private Image image;
        public DetailsPage(string title, string description, string imageUrl)
        {
            InitializeComponent();
            DescriptionLabel.Text = description;
            Title = title; // Установка заголовка страницы
                           // Получение ссылки на объект Image из XAML по имени
            DescriptionLabel = (Label)FindByName("DescriptionLabel");
            // Установка источника изображения
            Image.Source = new UriImageSource { Uri = new Uri(imageUrl) };
        }
    }
}