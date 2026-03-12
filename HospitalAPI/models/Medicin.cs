using System.ComponentModel.DataAnnotations;

namespace HospitalAPI.models
{
    public class Medicin
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string DrugName { get; set; }
        [Required]
        public string Stock {  get; set; }

    }
}
