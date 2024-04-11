using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        private String firstParam;
        private String secondParam;

        private String result;

        private Entry parameter1Entry;
        private Entry parameter2Entry;

        private Button summ;
        private Button div;
        private Button multy;
        private Button sub;

        private Label textLabel1;

        public MainPage()
        {
            //InitializeComponent();
            this.Content = InitInterface();
        }

        private void Parameter1Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            Entry parameter1Entry = (Entry)sender;
            firstParam = parameter1Entry.Text;
        }
        private void Parameter2Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            Entry parameter2Entry = (Entry)sender;
            secondParam = parameter2Entry.Text;
        }

        private void OnSummClicked(object sender, System.EventArgs e)
        {
            if (!IsValid())
                return;
            double res = Convert.ToDouble(firstParam) + Convert.ToDouble(secondParam);
            textLabel1.Text = res.ToString();
        }

        private void OnSubractionClicked(object sender, System.EventArgs e)
        {
            if (!IsValid())
                return;
            double res = Convert.ToDouble(firstParam) - Convert.ToDouble(secondParam);
            textLabel1.Text = res.ToString();
        }

        private void OnMultiplicationClicked(object sender, System.EventArgs e)
        {
            if (!IsValid())
                return;
            double res = Convert.ToDouble(firstParam) * Convert.ToDouble(secondParam);
            textLabel1.Text = res.ToString();
        }

        private void OnDivisionClicked(object sender, System.EventArgs e)
        {
            if (!IsValid())
                return;
            if (Convert.ToDouble(secondParam) == 0)
                textLabel1.Text = "Division by zero. Error";
            else
            {
                double res = Convert.ToDouble(firstParam) / Convert.ToDouble(secondParam);
                textLabel1.Text = res.ToString();
            }

        }

        private Boolean IsValid()
        {
            return firstParam != null && !firstParam.Equals("") && secondParam != null && !secondParam.Equals("");
        }

        private Grid InitInterface()
        {
            Grid grid = new Grid
            {
                RowDefinitions =
            {
                new RowDefinition {Height = GridLength.Auto},
                new RowDefinition {Height = GridLength.Auto},
                new RowDefinition {Height = GridLength.Auto},
                new RowDefinition {Height = GridLength.Auto},
                new RowDefinition {Height = GridLength.Auto}
            },
                ColumnDefinitions =
            {
                new ColumnDefinition {Width = GridLength.Auto},
                new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }
            }
            };



            Label lblLogo = new Label { Text = "Calculator", TextColor = Color.Blue, FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)), HorizontalOptions = LayoutOptions.Center };
            Grid.SetColumnSpan(lblLogo, 5);
            grid.Children.Add(lblLogo);

            Label lblF = new Label { Text = "First operand", TextColor = Color.Blue, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)), VerticalOptions = LayoutOptions.Center };
            Grid.SetRow(lblF, 1);
            grid.Children.Add(lblF);

            parameter1Entry = new Entry { Placeholder = "Enter first operand", Keyboard = Keyboard.Numeric, VerticalOptions = LayoutOptions.Center };
            parameter1Entry.TextChanged += Parameter1Entry_TextChanged;
            Grid.SetRow(parameter1Entry, 1);
            Grid.SetColumn(parameter1Entry, 1);
            Grid.SetColumnSpan(parameter1Entry, 3);
            grid.Children.Add(parameter1Entry);

            Label lblS = new Label { Text = "Second operand", TextColor = Color.Blue, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)), VerticalOptions = LayoutOptions.Center };
            Grid.SetRow(lblS, 2);
            grid.Children.Add(lblS);

            parameter2Entry = new Entry { Placeholder = "Enter second operand", Keyboard = Keyboard.Numeric, VerticalOptions = LayoutOptions.Center };
            parameter2Entry.TextChanged += Parameter2Entry_TextChanged;
            Grid.SetRow(parameter2Entry, 2);
            Grid.SetColumn(parameter2Entry, 1);
            Grid.SetColumnSpan(parameter2Entry, 3);
            grid.Children.Add(parameter2Entry);

            Label lblOp = new Label { Text = "Operation", TextColor = Color.Blue, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
            Grid.SetRow(lblOp, 3);
            grid.Children.Add(lblOp);

            summ = new Button { Text = "+", };
            summ.Clicked += OnSummClicked;
            Grid.SetRow(summ, 3);
            Grid.SetColumn(summ, 1);
            grid.Children.Add(summ);

            sub = new Button { Text = "-" };
            sub.Clicked += OnSubractionClicked;
            Grid.SetRow(sub, 3);
            Grid.SetColumn(sub, 2);
            grid.Children.Add(sub);

            multy = new Button { Text = "*" };
            multy.Clicked += OnMultiplicationClicked;
            Grid.SetRow(multy, 3);
            Grid.SetColumn(multy, 3);
            grid.Children.Add(multy);

            div = new Button { Text = "/" };
            div.Clicked += OnDivisionClicked;
            Grid.SetRow(div, 3);
            Grid.SetColumn(div, 4);
            grid.Children.Add(div);

            Label lblRes = new Label { Text = "Result", TextColor = Color.Blue, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
            Grid.SetRow(lblRes, 4);
            grid.Children.Add(lblRes);

            textLabel1 = new Label { FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)), TextColor = Color.Red };
            Grid.SetRow(textLabel1, 4);
            Grid.SetColumn(textLabel1, 1);
            Grid.SetColumnSpan(textLabel1, 4);
            grid.Children.Add(textLabel1);

            return grid;
        }
    }
}
