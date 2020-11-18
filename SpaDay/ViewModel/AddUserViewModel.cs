using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SpaDay.ViewModel
{
    public class AddUserViewModel
    {
        [Required(ErrorMessage ="Username is required")]
        [StringLength(15, MinimumLength = 5,ErrorMessage ="Username must be between 5 and 15 characters")]
        public string Username { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage ="Password is required")]
        [StringLength(20, MinimumLength = 6,ErrorMessage ="Password must be between 6 and 20 characters long")]
        public string Password { get; set; }

        [Required(ErrorMessage ="Please re-enter password")]
        public string VerifyPassword { get; set; }

    }
}
