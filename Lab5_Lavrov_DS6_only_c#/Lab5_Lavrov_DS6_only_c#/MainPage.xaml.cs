using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Lab5_Lavrov_DS6_only_c_
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            Grid grid = new Grid
            {
                RowDefinitions =
            {
                new RowDefinition(),
                new RowDefinition(),
                new RowDefinition(),
                new RowDefinition(),
                new RowDefinition(),
                new RowDefinition(),
                new RowDefinition(),
                new RowDefinition(),
                new RowDefinition()
            },
                ColumnDefinitions =
            {
                new ColumnDefinition(),
                new ColumnDefinition(),
                new ColumnDefinition()
            }
            };

            BoxView greenBox = new BoxView
            {
                Color = Color.Green
            };
            Grid.SetRowSpan(greenBox, 2);
            Grid.SetColumnSpan(greenBox, 2);
            grid.Children.Add(greenBox);

            BoxView blueBox = new BoxView
            {
                Color = Color.Blue
            };
            Grid.SetColumn(blueBox, 2);
            Grid.SetRowSpan(blueBox, 2);
            grid.Children.Add(blueBox);

            BoxView tealBox = new BoxView
            {
                Color = Color.Teal
            };
            Grid.SetRow(tealBox, 2);
            Grid.SetRowSpan(tealBox, 2);
            grid.Children.Add(tealBox);

            BoxView purpleBox = new BoxView
            {
                Color = Color.Purple
            };
            Grid.SetRow(purpleBox, 4);
            Grid.SetRowSpan(purpleBox, 2);
            grid.Children.Add(purpleBox);

            BoxView redBox = new BoxView
            {
                Color = Color.Red
            };
            Grid.SetColumn(redBox, 1);
            Grid.SetRow(redBox, 2);
            Grid.SetRowSpan(redBox, 4);
            grid.Children.Add(redBox);

            BoxView pinkBox = new BoxView
            {
                Color = Color.Pink
            };
            Grid.SetColumn(pinkBox, 2);
            Grid.SetRow(pinkBox, 2);
            Grid.SetRowSpan(pinkBox, 4);
            grid.Children.Add(pinkBox);

            BoxView yellowGreenBox = new BoxView
            {
                Color = Color.YellowGreen
            };
            Grid.SetRow(yellowGreenBox, 6);
            Grid.SetColumnSpan(yellowGreenBox, 3);
            grid.Children.Add(yellowGreenBox);

            BoxView lightCoralBox = new BoxView
            {
                Color = Color.LightCoral
            };
            Grid.SetRow(lightCoralBox, 7);
            Grid.SetColumnSpan(lightCoralBox, 3);
            grid.Children.Add(lightCoralBox);

            grid.Children.Add(new BoxView
            {
                Color = Color.Goldenrod
            }, 0, 8);
            grid.Children.Add(new BoxView
            {
                Color = Color.MediumPurple
            }, 1, 8);
            grid.Children.Add(new BoxView
            {
                Color = Color.LightGoldenrodYellow
            }, 2, 8);

            Content = grid;
        }
    }
}
