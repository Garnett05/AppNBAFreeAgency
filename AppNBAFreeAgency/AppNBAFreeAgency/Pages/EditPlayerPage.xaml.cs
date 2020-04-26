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
    public partial class EditPlayerPage : ContentPage
    {
        private Player player { get; set; }
        public EditPlayerPage(Player player)
        {
            InitializeComponent();
            this.player = player;

            //player = new Player();
            playerName.Text = player.Name;
            lastTeam.Text = player.PreviousTeam;
            age.Text = player.Age.ToString();
            cityBirth.Text = player.BirthCity;
            salary.Text = player.Salary.ToString();
            description.Text = player.Description;
            shootThrees.IsToggled = player.ThreePointShooter;
            phone.Text = player.PhoneNumber;
            email.Text = player.Email;            
        }
        public void UpdatePlayer (object sender, EventArgs args)
        {            
            player.Name = playerName.Text;
            player.PreviousTeam = lastTeam.Text;
            player.Age = short.Parse(age.Text);
            player.BirthCity = cityBirth.Text;
            player.Salary = double.Parse(salary.Text);
            player.Description = description.Text;
            player.ThreePointShooter = shootThrees.IsToggled;
            player.PhoneNumber = phone.Text;
            player.Email = email.Text;

            //TODO - Update in the database
            AccessDatabase db = new AccessDatabase();
            db.UpdateList(player);

            //TODO - Go back to Previous Page
            App.Current.MainPage = new NavigationPage(new PlayersPage());
        }
    }
}