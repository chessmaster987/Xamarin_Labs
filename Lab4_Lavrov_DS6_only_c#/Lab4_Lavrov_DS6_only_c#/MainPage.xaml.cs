using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Lab4_Lavrov_DS6_only_c_
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

        private RelativeLayout InitInterface()
        {
            RelativeLayout layout = new RelativeLayout() { BackgroundColor = Color.LightGray };

            layout.Children.Add(
                new Label
                {
                    TextColor = Color.Blue,
                    Text = "Calculator",
                    FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
                },
                Constraint.RelativeToParent((parent) =>
                {
                    return parent.Width * 0.5 - 50;
                }
            ));
            Label lblF = new Label
            {
                TextColor = Color.Blue,
                Text = "First Operand",
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))
            };
            layout.Children.Add(
                lblF,
                null,
                Constraint.RelativeToParent((parent) =>
                {
                    return parent.Height * 0.1;
                }),
                Constraint.RelativeToParent((parent) =>
                {
                    return parent.Width * 0.4;
                }),
                Constraint.RelativeToParent((parent) =>
                {
                    return parent.Height * 0.05;
                })
                );
            parameter1Entry = new Entry()
            {
                Placeholder = "Enter first operand",
                Keyboard = Keyboard.Numeric
            };
            parameter1Entry.TextChanged += Parameter1Entry_TextChanged;

            layout.Children.Add(
                parameter1Entry,
                Constraint.RelativeToView(lblF, (parent, sibling) =>
                {
                    return sibling.X + 140;
                }),
                Constraint.RelativeToView(lblF, (parent, sibling) =>
                {
                    return sibling.Y - 20;
                }),
                Constraint.RelativeToParent((parent) =>
                {
                    return parent.Width * 0.5;
                }),
                Constraint.RelativeToParent((parent) =>
                {
                    return parent.Height * 0.06;
                })
            );

            Label lblS = new Label
            {
                TextColor = Color.Blue,
                Text = "Second Operand",
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))
            };
            layout.Children.Add(
                lblS,
                null,
                Constraint.RelativeToParent((parent) =>
                {
                    return parent.Height * 0.1 + 50;
                }),
                Constraint.RelativeToParent((parent) =>
                {
                    return parent.Width * 0.4;
                }),
                Constraint.RelativeToParent((parent) =>
                {
                    return parent.Height * 0.1;
                })
                );

            parameter2Entry = new Entry()
            {
                Placeholder = "Enter second operand",
                Keyboard = Keyboard.Numeric,
            };
            parameter2Entry.TextChanged += Parameter2Entry_TextChanged;

            layout.Children.Add(
                parameter2Entry,
                Constraint.RelativeToView(lblS, (parent, sibling) =>
                {
                    return sibling.X + 140;
                }),
                Constraint.RelativeToView(lblS, (parent, sibling) =>
                {
                    return sibling.Y - 20;
                }),
                Constraint.RelativeToParent((parent) =>
                {
                    return parent.Width * 0.5;
                }),
                Constraint.RelativeToParent((parent) =>
                {
                    return parent.Height * 0.06;
                })
            );

            Label lblOp = new Label
            {
                TextColor = Color.Blue,
                Text = "Operation",
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))
            };

            layout.Children.Add(
                lblOp,
                null,
                Constraint.RelativeToParent((parent) =>
                {
                    return parent.Height * 0.1 + 100;
                }),
                Constraint.RelativeToParent((parent) =>
                {
                    return parent.Width * 0.4;
                }),
                Constraint.RelativeToParent((parent) =>
                {
                    return parent.Height * 0.1;
                })
            );

            summ = new Button()
            {
                Text = "+"
            };
            summ.Clicked += OnSummClicked;

            sub = new Button()
            {
                Text = "-"
            };
            sub.Clicked += OnSubractionClicked;

            multy = new Button()
            {
                Text = "*"
            };
            multy.Clicked += OnMultiplicationClicked;

            div = new Button()
            {
                Text = "/"
            };
            div.Clicked += OnDivisionClicked;

            layout.Children.Add(
                summ,
                Constraint.RelativeToView(lblOp, (parent, sibling) =>
                {
                    return sibling.X + 140;
                }
                ),
                Constraint.RelativeToView(lblOp, (parent, sibling) =>
                {
                    return sibling.Y - 12.5;
                }),
                Constraint.RelativeToParent((parent) =>
                {
                    return parent.Width * 0.12;
                })
            );

            layout.Children.Add(
                sub,
                Constraint.RelativeToView(summ, (parent, sibling) =>
                {
                    return sibling.X + 50;
                }
                ),
                Constraint.RelativeToView(summ, (parent, sibling) =>
                {
                    return sibling.Y;
                }),
                Constraint.RelativeToParent((parent) =>
                {
                    return parent.Width * 0.12;
                })
            );

            layout.Children.Add(
                multy,
                Constraint.RelativeToView(summ, (parent, sibling) =>
                {
                    return sibling.X + 100;
                }
                ),
                Constraint.RelativeToView(summ, (parent, sibling) =>
                {
                    return sibling.Y;
                }),
                Constraint.RelativeToParent((parent) =>
                {
                    return parent.Width * 0.12;
                })
            );

            layout.Children.Add(
                div,
                Constraint.RelativeToView(summ, (parent, sibling) =>
                {
                    return sibling.X + 150;
                }
                ),
                Constraint.RelativeToView(summ, (parent, sibling) =>
                {
                    return sibling.Y;
                }),
                Constraint.RelativeToParent((parent) =>
                {
                    return parent.Width * 0.12;
                })
            );

            Label lblRes = new Label
            {
                TextColor = Color.Blue,
                Text = "Result",
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))
            };

            layout.Children.Add(
                lblRes,
                null,
                Constraint.RelativeToParent((parent) =>
                {
                    return parent.Height * 0.1 + 150;
                }),
                Constraint.RelativeToParent((parent) =>
                {
                    return parent.Width * 0.4;
                }),
                Constraint.RelativeToParent((parent) =>
                {
                    return parent.Height * 0.1;
                })
            );

            textLabel1 = new Label
            {
                TextColor = Color.Red,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
            };

            layout.Children.Add(
                textLabel1,
                Constraint.RelativeToView(lblRes, (parent, sibling) =>
                {
                    return sibling.X + 120;
                }),
                Constraint.RelativeToView(lblRes, (parent, sibling) =>
                {
                    return sibling.Y - 2;
                }),
                Constraint.RelativeToParent((parent) =>
                {
                    return parent.Width * 0.4;
                }),
                Constraint.RelativeToParent((parent) =>
                {
                    return parent.Height * 0.1;
                })
            );
            return layout;
        }
    }

}
