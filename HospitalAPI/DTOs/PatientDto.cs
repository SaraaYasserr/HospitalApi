using System.ComponentModel.DataAnnotations;

namespace HospitalAPI.DTOs
{
    public class PatientDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public int Fees { get; set; }
        [Required]
        public bool Urgency { get; set; }
    }
}
