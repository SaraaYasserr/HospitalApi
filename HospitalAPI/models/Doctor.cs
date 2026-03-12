using System.ComponentModel.DataAnnotations;

namespace HospitalAPI.models
{
    public class Doctor
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Age { get; set; }
        public int Fees { get; set; }
        public string Urgency { get; set; }
        public string password { get; set; }

    }
}
