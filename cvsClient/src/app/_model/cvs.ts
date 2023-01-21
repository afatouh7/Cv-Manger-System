import { ExperienceInformation } from "./ExperienceInformation";
import { PersonalInformation } from "./PersonalInformation";





export interface cvs {
  id: number;
  name: string;
  personalInformation: PersonalInformation;
  experienceInformation: ExperienceInformation;
}



