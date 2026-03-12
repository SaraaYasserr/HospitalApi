using System.ComponentModel.DataAnnotations;

namespace HospitalAPI.DTOs
{
    public class AppointmentDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string Symptoms { get; set; }
        [Required]
        public int Number { get; set; }
    }
}
