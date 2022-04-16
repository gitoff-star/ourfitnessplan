using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ourfitnessplan.Models
{
    [Table("users")]
    public class users
    { 
    
        [Key]
        public int id{ get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.EmailAddress,ErrorMessage ="plese enter valid email")]
        public string Email { get; set; }
        [DataType (DataType.Password,ErrorMessage ="please enter password")]
        [MinLength(6,ErrorMessage ="Password should be greater than 6 characters")]
        public string Password { get; set; }
        [DataType(DataType.Password, ErrorMessage = "please enter password")]
        [MinLength(6, ErrorMessage = "Password should be greater than 6 characters")]
        [Compare(nameof(Password),ErrorMessage ="Password and confirm Password should be same")]
        public string Confirm_password { get; set; }
        public string User_status { get; set; }

        
        public string image_path { get; set; }
    }
}