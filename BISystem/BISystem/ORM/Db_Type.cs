using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BISystem.ORM
{
    [Table("Db_Types")]
    public class Db_Type  {

        [Key]
        public int    db_type_id { get; set; }
        public String name { get; set; }
        public String version { get; set; }

        public virtual IEnumerable<Connection> Connections { get; set; }

    }
}