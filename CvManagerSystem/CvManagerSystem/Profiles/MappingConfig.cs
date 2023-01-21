using AutoMapper;
using Core.Dtos;
using Core.Entity;

namespace CvManagerSystem.Profiles
{
    public class MappingConfig : Profile
    {

        public MappingConfig()
        {
            CreateMap<CV, CvDto>().ReverseMap();
            CreateMap<ExperienceInformation, ExperienceInformationDto>().ReverseMap();
            CreateMap<PersonalInformation, PersonalinfoDto>().ReverseMap();
            
            
        }
    }
}
