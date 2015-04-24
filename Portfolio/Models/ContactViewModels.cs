using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Portfolio.Models
{
    public class ContactViewModels
    {
        [Required]
        [MaxLength(20, ErrorMessage="Your name is too long.")]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        [DisplayName("Email Address")]
        public string Email { get; set; }

        [Required]
        [StringLength(300, ErrorMessage = "The message must be at least {2} characters long.", MinimumLength = 5)]
        public string Message { get; set; }
    }
}