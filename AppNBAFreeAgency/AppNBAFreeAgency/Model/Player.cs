using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppNBAFreeAgency.Model
{
    [Table("Player")]
    public class Player
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public short Age { get; set; }
        public string College { get; set; }
        public double Salary { get; set; }
        public string PreviousTeam { get; set; }
        public string Description { get; set; }
        public bool ThreePointShooter { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
