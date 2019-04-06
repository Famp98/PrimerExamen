using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PrimerParcialAbril.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<PrimerParcialAbril.Models.FabioMurguiaFriend> FabioMurguiaFriends { get; set; }
    }
}