using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity
{
    public class CV : BaseEntity
    {
        [Required]
        public string Name { get; set; }

        public PersonalInformation  PersonalInformation { get; set; }
      
        public ExperienceInformation  ExperienceInformation { get; set; }
       }
}
