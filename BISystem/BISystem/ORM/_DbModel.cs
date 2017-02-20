using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BISystem.ORM
{
    public class _DbModel : DbContext    {

        public _DbModel() : base("name=SystemDB") {

        }

        public DbSet<User> User { get; set; }
        public DbSet<Connection> Connections { get; set; }
        public DbSet<Db_Type> Db_Types { get; set; }
    }
}