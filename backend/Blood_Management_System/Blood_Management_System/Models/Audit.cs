namespace Blood_Management_System.Models
{
    public abstract class Audit : IAudit
    {
        public int UserAdd { get; set; }
        public int UserDel { get; set; }
        public int? UserMod { get; set; }
        public bool isActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
