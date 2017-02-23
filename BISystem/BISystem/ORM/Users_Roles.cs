using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BISystem.ORM
{
    [Table("webpages_UsersInRoles")]
    public class Users_Roles
    {
        [Key]        
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public int activated_by { get; set; }
        public int date_Active { get; set; }
        public int deactivated_by { get; set; }
        public int date_deactivated { get; set; }

        [ForeignKey("UserId")]
        public virtual User user { get; set; }

        [ForeignKey("RoleId")]
        public virtual Users_Roles user_roles { get; set; }

    }
}