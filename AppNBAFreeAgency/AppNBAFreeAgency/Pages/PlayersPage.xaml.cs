using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppNBAFreeAgency.Model;
using AppNBAFreeAgency.Database;

namespace AppNBAFreeAgency.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlayersPage : ContentPage
    {
        List<Player> list { get; set; }
        public PlayersPage()
        {
            InitializeComponent();
            UpdateScreen();
        }
        private void UpdateScreen()
        {
            AccessDatabase db = new AccessDatabase();
            listPlayers.ItemsSource = db.SelectAllPlayers();
            list = db.SelectAllPlayers();
            lblCountPlayers.Text = list.Count.ToString();
        }

        public void EditPlayer (object sender, EventArgs args)
        {
            // label --> GestureRecognized --> CommandParameter
            Label lblEdit = (Label)sender;
            TapGestureRecognizer tapGest = (TapGestureRecognizer)lblEdit.GestureRecognizers[0];
            var player = tapGest.CommandParameter as Player;

            //var player = ((TapGestureRecognizer)lblDetail.GestureRecognizers[0]).CommandParameter as Player; //Poderia ter sido feito assim também
            Navigation.PushAsync(new EditPlayerPage(player));
        }
        public void DeletePlayer (object sender, EventArgs args)
        {
            // label --> GestureRecognized --> CommandParameter
            Label lblDelete = (Label)sender;
            TapGestureRecognizer tapGest = (TapGestureRecognizer)lblDelete.GestureRecognizers[0];
            var player = tapGest.CommandParameter as Player;

            AccessDatabase db = new AccessDatabase();
            db.DeletePlayer(player);
            UpdateScreen();
        }
    }
}