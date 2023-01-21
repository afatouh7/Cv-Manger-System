using Core.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrestructure.Data
{
  public class CvContext :DbContext
    {
        public CvContext(DbContextOptions options) : base(options)
        { }
        public DbSet<CV>  CVs { get; set; }
        public DbSet<ExperienceInformation>  ExperienceInformation { get; set; }
        public DbSet<PersonalInformation>   PersonalInformation { get; set; }
    }
}
