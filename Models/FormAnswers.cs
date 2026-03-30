using System.ComponentModel.DataAnnotations;

namespace Blood_Donation_Project.Models
{
    public class FormAnswers
    {
        [Key]
        public int Answers_ID { get; set; }
        public int Form_ID { get; set; }
        public int HealthQ_ID { get; set; }
        [Required]
        public string Answer { get; set; }
    }
}
