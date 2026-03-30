using System.ComponentModel.DataAnnotations;

namespace Blood_Donation_Project.Models
{
    public class BloodTypeTable
    {
        [Key]
        public int BloodType_ID { get; set; }
        [Required]
        public string BloodType { get; set; }
    }
}
