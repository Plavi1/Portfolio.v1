using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Models
{
    public class Sender
    {
        public string Name { get; set; }
        [Required(ErrorMessage = "-Email is required.")]
        [EmailAddress(ErrorMessage = "-The Email field is not a valid e-mail address.")]
        public string Email { get; set; }
        public string Subject { get; set; }
        [Required(ErrorMessage = "-Some Message is required.")]
        public string Body { get; set; }
    }
}
