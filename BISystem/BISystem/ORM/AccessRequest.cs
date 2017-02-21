using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BISystem.ORM
{
    public class AccessRequest
    {
        [Key]
        public int request_id { get; set; }

        [Display(Name ="For Name")]
        public string for_user_name { get; set; }
        [Display(Name = "For Surname")]
        public string for_surname { get; set; }

        [Display(Name = "Email")]
        public string for_email { get; set; }

        public int? requsestor_id { get; set; }

        [Display(Name ="Request Message")]
        public string message { get; set; }
        
    }
}