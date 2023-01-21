namespace Core.Dtos
{
    public class CvDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public PersonalinfoDto PersonalInformation { get; set; }
    
        public ExperienceInformationDto ExperienceInformation { get; set; }
      
    }
}
