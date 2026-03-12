using System.ComponentModel.DataAnnotations;

namespace HospitalAPI.DTOs
{
    public class MedicinDto
    {
        [Required]
        public string DrugName { get; set; }
        [Required]
        public string Stock { get; set; }
    }
}
