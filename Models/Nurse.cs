using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Blood_Donation_Project.Models
{
    public class Nurse
    {
        [Key]
        public int Nurse_ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
    }
}
