using System.ComponentModel.DataAnnotations;

namespace HospitalAPI.DTOs
{
    public class AdminDashboardDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public int Fees { get; set; }
        [Required]
        public bool Urgency { get; set; }
        [Required]
        public string password { get; set; }
    }
}
