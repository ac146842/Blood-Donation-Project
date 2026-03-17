namespace Blood_Donation_Project.Models
{
    public class MedicalForm
    {
        public int Form_ID { get; set; }
        public int Donor_ID { get; set; }
        public int Nurse_ID { get; set; }
        public DateTime FormDate { get; set; }
    }
}
