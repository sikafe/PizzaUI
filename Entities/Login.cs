using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class Login
    {
        [Required]
        [DisplayName("Email Address")]
        public string Email { set; get; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
