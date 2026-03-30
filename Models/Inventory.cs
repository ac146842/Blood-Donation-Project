using System.ComponentModel.DataAnnotations;

namespace Blood_Donation_Project.Models
{
    public class Inventory
    {
        [Key]
        public int BloodBank_ID { get; set; }
        public int Donation_ID { get; set; }
        public int BloodType_ID { get; set; }
        [Required]
        [Range(0.01, 500, ErrorMessage = "Volume must be greater than 0 and less than 500")]
        public decimal VolumeML { get; set; }
        [Required]
        public bool Status { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime ExpiryDate { get; set; }
    }
}
