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

        [Display(Name="Name")]
        public String name { get; set; }

        [Display(Name = "DB Type")]
        public int    db_type_id { get; set; }

        [Display(Name = "DB Name")]
        public String database_name { get; set; }

        [Display(Name = "Schema")]
        public String default_schema { get; set; }

        [Display(Name = "Host")]
        public String host { get; set; }
        
        [Display(Name = "User")]
        public String db_user { get; set; }

        [Display(Name = "Pass")]
        public String password { get; set; }

        [Display(Name = "Time out")]
        public int    time_out { get; set; }

        [Display(Name = "Conn String")]
        public String connection_string { get; set; }


        [ForeignKey("db_type_id")]
        public virtual Db_Type Db_Type { get; set; }

    }
}