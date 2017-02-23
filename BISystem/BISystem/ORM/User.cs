using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BISystem.ORM
{
    [Table("Users")]
    public class User
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }

        
        public string UserName { get; set; }
        public string surname { get; set; }
        public string first_name { get; set; }
        public string email { get; set; }
        public string manager_id { get; set; }

        public virtual IEnumerable<Users_Roles> roles { get; set; }
    }
}