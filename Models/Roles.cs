using System.ComponentModel.DataAnnotations;

namespace Blood_Donation_Project.Models
{
    public class Roles
    {
        [Key]
        public int Role_ID { get; set; }
        public int User_ID { get; set; }
        [Required]
        [StringLength(10)]
        public string Role  { get; set; }
    }
}
