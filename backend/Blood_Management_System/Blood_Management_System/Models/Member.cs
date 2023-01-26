using System;
using System.Collections.Generic;

namespace Blood_Management_System.Models;

public partial class Member
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string RollNo { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Designation { get; set; } = null!;

    public string? ListGroup { get; set; }

    public string Status { get; set; } = null!;
}
