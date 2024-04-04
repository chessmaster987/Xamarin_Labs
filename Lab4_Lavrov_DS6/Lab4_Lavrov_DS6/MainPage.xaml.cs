using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Lab4_Lavrov_DS6
{
    public partial class MainPage : ContentPage
    {
        private String firstParam;
        private String secondParam;

        public MainPage()
        {
            InitializeComponent();
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
    }

}
