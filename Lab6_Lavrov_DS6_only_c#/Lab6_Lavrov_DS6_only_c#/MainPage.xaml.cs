using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Lab6_Lavrov_DS6_only_c_
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            CreateTable();
        }

        private void CreateTable()
        {
            var tableView = new TableView
            {
                BackgroundColor = Color.LightGray,
                HasUnevenRows = true
            };

            var tableRoot = new TableRoot();
            var tableSection = new TableSection("Top 3 CHESS players");

            tableSection.Add(CreateViewCell("magnus.jpg", "Magnus Carlsen", 200));
            tableSection.Add(CreateViewCell("fabi.jpg", "Fabiano Caruana", 200, 200));
            tableSection.Add(CreateViewCell("https://networthplanet.com/wp-content/uploads/2022/05/277836976_1297655740645156_195515336665309223_n-728x910.jpg", "Hikaru Nakamura", 200, 200));

            tableRoot.Add(tableSection);
            tableView.Root = tableRoot;

            Content = tableView;
        }

        private ViewCell CreateViewCell(string imagePath, string labelText, double cellHeight, double cellWidth = -1)
        {
            var image = new Image
            {
                Source = imagePath,
                Aspect = Aspect.AspectFill,
                HeightRequest = cellHeight,
                WidthRequest = cellWidth, 
                HorizontalOptions = LayoutOptions.StartAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            var label = new Label
            {
                Text = labelText,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
            };

            var stackLayout = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children = { image, label }
            };

            return new ViewCell { View = stackLayout, Height = cellHeight };
        }
    }
}
