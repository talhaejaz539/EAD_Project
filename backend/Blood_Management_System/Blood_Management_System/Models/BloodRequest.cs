namespace Blood_Management_System.Models
{
    public class BloodRequest
    {
        public int Id { get; set; }
        public string RequiredBloodGroup { get; set; }
        public string HospitalName { get; set; }
        public string RequestorName { get; set; }
        public string RequestorRollNumber { get; set; }
        public string RequestorPhone { get; set; }
        public string Case { get; set; }
        public string AttendantName { get; set; }
        public string AttendantPhone { get; set; }
        public DateTime TimeAndDate { get; set; }
        public string PickAndDrop { get; set; }
        public string DonorName { get; set; }
        public string DonorContact { get; set; }
    }
}
