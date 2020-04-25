using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using AppNBAFreeAgency.Model;
using Xamarin.Forms;
using System.Linq;

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
            _conection.CreateTable<Player>();
        }
        public void EnterPlayer(Player player)
        {
            _conection.Insert(player);
        }
        public void DeletePlayer(Player player)
        {
            _conection.Delete(player);
        }
        public void UpdateList(Player player)
        {
            _conection.Update(player);
        }
        public List<Player> SearchPlayer(string name)
        {
            return _conection.Table<Player>().Where(x => x.Name == name).ToList();
        }
        public Player GetPlayer(int id)
        {
            return _conection.Table<Player>().Where(x => x.Id == id).FirstOrDefault();
        }
        public List<Player> SelectAllPlayers()
        {
            return _conection.Table<Player>().ToList();
        }
    }
}
