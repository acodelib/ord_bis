using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BISystem.ORM
{
    public class _DbModel : DbContext {

        public _DbModel() : base("name=SystemDB") {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<User_in_Role> Users_in_Roles {get;set;}
        public DbSet<Role> Roles { get; set; }
        public DbSet<Connection> Connections { get; set; }
        public DbSet<Db_Type> Db_Types { get; set; }
        public DbSet<AccessRequest> AccessRequests { get; set; }
        
    }
}