using System;
using System.Collections.Generic;

namespace Blood_Management_System.Models;

public partial class BloodRequest
{
    public int Id { get; set; }

    public string RequiredBloodGroup { get; set; } = null!;

    public string HospitalName { get; set; } = null!;

    public string RequestorName { get; set; } = null!;

    public string RequestorRollNumber { get; set; } = null!;

    public string RequestorPhone { get; set; } = null!;

    public string Case { get; set; } = null!;

    public string AttendantName { get; set; } = null!;

    public string AttendantPhone { get; set; } = null!;

    public DateTime TimeAndDate { get; set; }

    public string PickAndDrop { get; set; } = null!;

    public string DonorName { get; set; } = null!;

    public string DonorContact { get; set; } = null!;
}
