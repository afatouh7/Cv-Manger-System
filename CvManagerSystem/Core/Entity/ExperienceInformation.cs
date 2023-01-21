using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity
{
    public class ExperienceInformation: BaseEntity
    {
        [Required]
        [MaxLength(20, ErrorMessage = "maximum {20} characters allowed")]
        public string CompanyName { get; set; }
        public string City { get; set; }
        public string CompanyField { get; set; }
    }
}
