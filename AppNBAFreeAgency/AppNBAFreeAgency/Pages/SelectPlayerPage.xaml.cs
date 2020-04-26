using AppNBAFreeAgency.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppNBAFreeAgency.Database;
using Rg.Plugins.Popup.Services;
using Rg.Plugins.Popup.Pages;

namespace AppNBAFreeAgency.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SelectPlayerPage : ContentPage
    {
        List<Player> list { get; set; }
        public SelectPlayerPage()
        {
            InitializeComponent();

            AccessDatabase db = new AccessDatabase();
            listPlayers.ItemsSource = db.SelectAllPlayers();
            list = db.SelectAllPlayers();
            lblCountPlayers.Text = list.Count.ToString();

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
            //Navigation.PushAsync(new PlayerInformation(player));
            var nextPage = new PlayerInformation(player);
            PopupNavigation.Instance.PushAsync(nextPage);
        }
        public void SearchPlayer (object sender, TextChangedEventArgs args)
        {            
            listPlayers.ItemsSource = list.Where(x => x.Name.Contains(args.NewTextValue)).ToList();
        }
    }
}