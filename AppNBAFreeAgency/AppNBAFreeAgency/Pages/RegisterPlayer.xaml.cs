using AppNBAFreeAgency.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppNBAFreeAgency.Database;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppNBAFreeAgency.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPlayer : ContentPage
    {
        public RegisterPlayer(Player player = null)
        {
            InitializeComponent();            
        }
        public void SavePlayer (object sender, EventArgs args)
        {
            //TODO - Create validation
            Player player = new Player();
            player.Name = playerName.Text;
            player.PreviousTeam = lastTeam.Text;
            player.Age = short.Parse(age.Text);
            player.College = cityBirth.Text;
            player.Salary = double.Parse(salary.Text);
            player.Description = description.Text;
            player.ThreePointShooter = shootThrees.IsToggled;
            player.PhoneNumber = phone.Text;
            player.Email = email.Text;
            
            //Saving in the database
            AccessDatabase dbAccess = new AccessDatabase();
            dbAccess.EnterPlayer(player);
                        
            App.Current.MainPage = new NavigationPage(new SelectPlayerPage());
        }
    }
}