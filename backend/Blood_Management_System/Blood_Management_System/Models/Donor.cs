namespace Blood_Management_System.Models
{
    public class Donor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string RollNo { get; set; }
        public string PhoneNo { get; set; }
        public string BloodGroup { get; set; }
        public string TemporaryAddress { get; set; }
        public string PermanentAddress { get; set; }
        public DateOnly LastDonationDate { get; set; }
        public string Status { get; set; }
    }
}
