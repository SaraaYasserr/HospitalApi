using System.ComponentModel.DataAnnotations;

namespace HospitalAPI.models
{
    public class Patient
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Age {  get; set; }
       // public string Blood_Group {  get; set; }
        [Required]
        public int Dose {  get; set; }
        [Required]
        public int Fees { get; set; }
        [Required]
        public bool Urgency { get; set; }
    }
}
