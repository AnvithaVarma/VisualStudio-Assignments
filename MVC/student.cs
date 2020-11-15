using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace practisingMVC.Models
{
    public class student
    {
        public int ID { get; set; }

        [Required(ErrorMessage ="Name is required")]
        [MaxLength(20)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage ="Invalid Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Contact is required")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\?([0-9]{3}\)?[-.]?([0-9]{3})[-.]?([0-9]{4})$",ErrorMessage ="Not a valid number")]
        public string Contact { get; set; }
        
    }
}