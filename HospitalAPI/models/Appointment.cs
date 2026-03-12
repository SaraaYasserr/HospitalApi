using System.ComponentModel.DataAnnotations;

namespace HospitalAPI.models
{
    public class Appointment
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Age {  get; set; }
        [Required]
        public string Symptoms { get; set; }
        [Required]
        public int Number {  get; set; }
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; } 
        public int PatientId { get; set; }
        public Patient Patient { get; set; }



    }
}
