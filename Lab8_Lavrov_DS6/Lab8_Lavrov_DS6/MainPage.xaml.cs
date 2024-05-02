using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Lab8_Lavrov_DS6
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void Image1Details_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DetailsPage("Magnus Carlsen", "Магнус Карлсен - норвезький шахіст, який є одним з найвидатніших гросмейстерів в історії шахів. Він народився 30 квітня 1990 року в Тёнсбергу, Норвегія. Карлсен виявив свій шаховий талант у дуже молодому віці і став міжнародним майстром у 13 років.\r\n\r\nОдним з найважливіших моментів у кар'єрі Магнуса було його перемога на чемпіонаті світу з шахів у 2013 році, коли він здобув титул у матчі проти індійського гросмейстера Вішванатана Ананда. Карлсен став 16-м чемпіоном світу з шахів у історії.", "https://images.chesscomfiles.com/uploads/v1/master_player/3b0ddf4e-bd82-11e8-9421-af517c2ebfed.23bcb9e8.250x250o.fe16f88558e7.jpg"));
        }
        private async void Image2Details_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DetailsPage("Fabiano Caruana", "Фабіано Каруана - шахіст, народився 30 липня 1992 року в США. Він має італійське походження і відомий своїм високим рівнем шахового майстерності. Каруана був учасником багатьох великих шахових змагань і турнірів, в тому числі чемпіонатів світу. У 2018 році він був фіналістом чемпіонату світу з шахів, де програв норвезькому гросмейстеру Магнусу Карлсену. Каруана також відомий своєю активною участю в шахових турнірах та своїми високими рейтинговими показниками.", "https://images.chesscomfiles.com/uploads/v1/master_player/c66cb17a-c005-11e8-886b-692f3468f8e7.b4d2d0e5.250x250o.0909ac90973d.jpg"));
        }
        private async void Image3Details_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DetailsPage("Hikaru Nakamura", "Хікару Накамура - американський шахіст, народився 9 грудня 1987 року. Він є одним з найвидатніших гросмейстерів світу і відомий своїм високим рівнем швидкісних і бліц-шахів. Накамура виступає в численних міжнародних турнірах і був учасником багатьох престижних змагань. Його шахові досягнення включають перемоги на кількох великих турнірах і високий рейтинговий рівень.", "https://images.chesscomfiles.com/uploads/v1/master_player/5c8147c2-bd7f-11e8-863f-15ded6970bf6.e234e103.250x250o.70ca1cbc7be1.jpg"));
        }
    }
}
