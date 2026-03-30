using System.ComponentModel.DataAnnotations;

namespace Blood_Donation_Project.Models
{
    public class MedicalForm
    {
        [Key]
        public int Form_ID { get; set; }
        public int Donor_ID { get; set; }
        public int Nurse_ID { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime FormDate { get; set; }
    }
}