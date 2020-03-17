using System;
using System.ComponentModel.DataAnnotations;

namespace SpeakerAPI
{
    public class Speaker
    {
        public string SpeakerId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string MobileNumber { get; set; }

        [Required]
        public string AreaOfSpecialization { get; set; }

        [Required]
        public string CityOfResidence { get; set; }

        [Required]
        public string ProvinceOfResidence { get; set; }

        [Required]
        public string Employer { get; set; }
    }
}
