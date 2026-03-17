namespace Blood_Donation_Project.Models
{
    public class Appointment
    {
        public int Appointment_ID { get; set; }
        public int Donor_ID { get; set; }
        public DateTime AppointmentDateTime { get; set; }
        public string Location { get; set; }
        public bool Status { get; set; }
    }
}
