using System.ComponentModel.DataAnnotations;

namespace Blood_Donation_Project.Models
{
    public class User
    {
        [Key]
        public int User_ID { get; set; }
        [Required]
        [StringLength(50)]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [StringLength(100)]
        public string Password { get; set; }
    }
}
