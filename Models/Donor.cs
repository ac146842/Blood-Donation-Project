using System.ComponentModel.DataAnnotations;

namespace Blood_Donation_Project.Models
{
    //create enum for bloodtype
    public enum BloodType
    {
        aPositive,
        aNegative,
        bPositive,
        bNegative,
        abPositive,
        abNegative,
        oPositive,
        oNegative


    }

    //add 2FA
    //change erd to match NVARCHAR updates

    //add error messages for every model validation eg "name too long"
    public class Donor
    { 
        [Key]
        public int Donor_ID { get; set; }
        [Required]
        public int BloodType_ID { get; set; } 
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50)]
        [EmailAddress]
        public string LastName { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public int Phone { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
    }
}
