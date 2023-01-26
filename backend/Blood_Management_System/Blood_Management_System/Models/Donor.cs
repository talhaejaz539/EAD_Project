using System;
using System.Collections.Generic;

namespace Blood_Management_System.Models;

public partial class Donor
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string RollNo { get; set; } = null!;

    public string PhoneNo { get; set; } = null!;

    public string BloodGroup { get; set; } = null!;

    public string TemporaryAddress { get; set; } = null!;

    public string PermanentAddress { get; set; } = null!;

    public DateTime LastDonationDate { get; set; }

    public string Status { get; set; } = null!;
}
