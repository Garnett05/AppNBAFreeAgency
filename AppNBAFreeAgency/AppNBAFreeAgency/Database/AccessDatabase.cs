using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using AppNBAFreeAgency.Model;
using Xamarin.Forms;

namespace AppNBAFreeAgency.Database
{
    public class AccessDatabase
    {
        private SQLiteConnection _conection;
                 
        public AccessDatabase()
        {
            var dep = DependencyService.Get<IDatabasePath>();
            string path = dep.GetPath("database.sqlite");
            _conection = new SQLiteConnection(path);
        }
        public void EnterPlayer(Player player)
        {

        }
        public void DeletePlayer(Player player)
        {

        }
        public void Update(Player player)
        {

        }
        public Player GetPlayer(int id)
        {
            return null;
        }
        public List<Player> SelectPlayer()
        {
            return null;
        }
    }
}
