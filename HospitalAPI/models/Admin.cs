using System.ComponentModel.DataAnnotations;

namespace HospitalAPI.models
{
    public class Admin
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public int Fees { get; set; }
        [Required]
        public string Urgency {  get; set; }
        [Required]
        public string password {  get; set; }
    }
}
