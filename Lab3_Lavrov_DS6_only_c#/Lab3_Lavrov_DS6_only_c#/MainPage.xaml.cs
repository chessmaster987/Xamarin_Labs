using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Lab3_Lavrov_DS6_only_c_
{
    public partial class MainPage : ContentPage
    {
        private string firstParam;
        private string secondParam;
        private string result;

        private Entry parameter1Entry;
        private Entry parameter2Entry;

        private Button summ;
        private Button div;
        private Button multy;
        private Button sub;

        private Label textLabel1;

        public MainPage()
        {
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

        private void OnSummClicked(object sender, EventArgs e)
        {
            if (!IsValid())
                return;
            double res = Convert.ToDouble(firstParam) + Convert.ToDouble(secondParam);
            textLabel1.Text = res.ToString();
        }

        private void OnSubractionClicked(object sender, EventArgs e)
        {
            if (!IsValid())
                return;
            double res = Convert.ToDouble(firstParam) - Convert.ToDouble(secondParam);
            textLabel1.Text = res.ToString();
        }

        private void OnMultiplicationClicked(object sender, EventArgs e)
        {
            if (!IsValid())
                return;
            double res = Convert.ToDouble(firstParam) * Convert.ToDouble(secondParam);
            textLabel1.Text = res.ToString();
        }

        private void OnDivisionClicked(object sender, EventArgs e)
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

        private bool IsValid()
        {
            return !string.IsNullOrEmpty(firstParam) && !string.IsNullOrEmpty(secondParam);
        }

        private StackLayout InitInterface()
        {
            StackLayout layout = new StackLayout() { BackgroundColor = Color.LightGray };

            // Add labels, entries, buttons, and event handlers programmatically here
            layout.Children.Add(
                new Label
                {
                    TextColor = Color.Blue,
                    Text = "Calculator",
                    FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
                });

            // First operand label and entry
            Label lblF = new Label
            {
                TextColor = Color.Blue,
                Text = "First Operand",
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))
            };
            parameter1Entry = new Entry()
            {
                Placeholder = "Enter first operand",
                Keyboard = Keyboard.Numeric
            };
            parameter1Entry.TextChanged += Parameter1Entry_TextChanged;
            layout.Children.Add(lblF);
            layout.Children.Add(parameter1Entry);

            // Second operand label and entry
            Label lblS = new Label
            {
                TextColor = Color.Blue,
                Text = "Second Operand",
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))
            };
            parameter2Entry = new Entry()
            {
                Placeholder = "Enter second operand",
                Keyboard = Keyboard.Numeric,
            };
            parameter2Entry.TextChanged += Parameter2Entry_TextChanged;
            layout.Children.Add(lblS);
            layout.Children.Add(parameter2Entry);

            // Operation label and buttons
            Label lblOp = new Label
            {
                TextColor = Color.Blue,
                Text = "Operation",
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))
            };
            summ = new Button() { Text = "+" };
            summ.Clicked += OnSummClicked;
            sub = new Button() { Text = "-" };
            sub.Clicked += OnSubractionClicked;
            multy = new Button() { Text = "*" };
            multy.Clicked += OnMultiplicationClicked;
            div = new Button() { Text = "/" };
            div.Clicked += OnDivisionClicked;

            layout.Children.Add(lblOp);
            layout.Children.Add(summ); 
            layout.Children.Add(sub);
            layout.Children.Add(multy);
            layout.Children.Add(div);

            // Result label
            Label lblRes = new Label
            {
                TextColor = Color.Blue,
                Text = "Result",
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))
            };
            textLabel1 = new Label
            {
                TextColor = Color.Red,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
            };

            layout.Children.Add(lblRes);
            layout.Children.Add(textLabel1);

            return layout;
        }
    }
}
