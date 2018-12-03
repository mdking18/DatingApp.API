using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        [StringLength(8, ErrorMessage = "Password must be between 4 and 8 characters", MinimumLength = 4)]
        public string Password { get; set; }
    }
}
