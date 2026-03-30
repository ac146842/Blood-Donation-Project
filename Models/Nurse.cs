using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Blood_Donation_Project.Models
{
    public class Nurse
    {
        [Key]
        public int Nurse_ID { get; set; }
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
