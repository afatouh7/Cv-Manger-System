using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity
{
    public class PersonalInformation :BaseEntity
    {
        [Required]
        public string FullName { get; set; }
        public string CityName { get; set; }
        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        [RegularExpression(@"^([A-Za-z0-9][^'!&\\#*$%^?<>()+=:;`~\[\]{}|/,₹€@ ][a-zA-z0- 9-._][^!&\\#*$%^?<>()+=:;`~\[\]{}|/,₹€@ ]*\@[a-zA-Z0-9][^!&@\\#*$%^?<> ()+=':;~`.\[\]{}|/,₹€ ]*\.[a-zA-Z]{2,6})$", ErrorMessage = "Please enter a  valid Email")]
        public string Email { get; set; }
        [Required]
        [RegularExpression(@"[0-9]{13}", ErrorMessage = "Invalid ID Number")]
        public string MobilNumber { get; set; }
    }
}
