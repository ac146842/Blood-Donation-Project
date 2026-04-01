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
        abPosi tive,
        abNegative,
        oPositive,
        oNegative,
    }

    //possibly add audit log for tracking changes to donor information
    //add 2FA
    //change erd to match NVARCHAR updates
    //get rid of all underscores in var names

    //add error messages for every model validation eg "name too long"
    public class Donor
    { 
        [Key]
        public int DonorID { get; set; }

        [Required]
        public int BloodTypeID { get; set; } 
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

        public BloodType BloodType { get; set; }
    }
}
