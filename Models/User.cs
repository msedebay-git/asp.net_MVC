using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace asp.net_MVC.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage ="Please Enter Username..")]
        [Display(Name ="UserName")]
        public string? Username { get; set; }

        [Required(ErrorMessage ="Please Enter Password..")]
        [DataType(DataType.Password)]
        [Display(Name ="Password")]
        public string? password{ get; set; }

        [Required(ErrorMessage ="Please Enter Confirm Password...")]
        [DataType(DataType.Password)]
        [Display(Name ="Confirm Password")]
        [Compare("Password")]
        public string? ConfirmPassword { get; set; }

        [Required(ErrorMessage ="Please Enter Email...")]
        [Display(Name ="Email")]
        public string? Email { get; set; }

        [Required(ErrorMessage ="Select the Gender...")]
        [Display(Name ="Gender")]
        public string? Gender { get; set; }

        [Required(ErrorMessage ="Select the Marital Status...")]
        [Display(Name ="Marital Status")]
        public string? MaritalStatus { get; set; }
    }
}