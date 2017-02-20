using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BISystem.ORM
{
    [Table("Connections")]
    public class Connection    {

        [Key]
        public int    connection_id { get; set; }
        public String name { get; set; }
        public int    db_type_id { get; set; }
        public String database_name { get; set; }

        public String default_schema { get; set; }
        public String host { get; set; }
        public String db_user { get; set; }
        public String password { get; set; }
        public int    time_out { get; set; }
        public String connection_string { get; set; }

        [ForeignKey("db_type_id")]
        public virtual Db_Type Db_Type { get; set; }

    }
}