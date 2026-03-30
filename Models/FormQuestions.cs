using System.ComponentModel.DataAnnotations;

namespace Blood_Donation_Project.Models
{
    public class FormQuestions
    {
        [Key]
        public int HealthQ_ID { get; set; }
        [Required]
        public string Questions { get; set; }

    }
}
