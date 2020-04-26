using AppNBAFreeAgency.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppNBAFreeAgency.Database;

namespace AppNBAFreeAgency.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SelectPlayerPage : ContentPage
    {
        public SelectPlayerPage()
        {
            InitializeComponent();

            AccessDatabase db = new AccessDatabase();
            listPlayers.ItemsSource = db.SelectAllPlayers();
            var varvar = db.SearchPlayer("Kahwi Leonard");            
            var count = db.SelectAllPlayers();
            lblCountPlayers.Text = count.Count.ToString();

        }
        public void GoRegisterPage (object sender, EventArgs args)
        {
            Navigation.PushAsync(new RegisterPlayer());
        }
        public void GoPlayerInformation (object sender, EventArgs args)
        {
            Navigation.PushAsync(new PlayersPage());
        }
        public void MoreDetails (object sender, EventArgs args)
        {
            // label --> GestureRecognized --> CommandParameter
            Label lblDetail = (Label)sender;
            TapGestureRecognizer tapGest = (TapGestureRecognizer)lblDetail.GestureRecognizers[0];
            var player = tapGest.CommandParameter as Player;

            //var player = ((TapGestureRecognizer)lblDetail.GestureRecognizers[0]).CommandParameter as Player; //Poderia ter sido feito assim também
            Navigation.PushAsync(new PlayerInformation(player));
        }
    }
}