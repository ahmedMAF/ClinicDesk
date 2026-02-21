using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicDesk.Database.Models;

public class User
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;
    public string Username { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Password { get; set; } = null!;
    public UserRole Role { get; set; }
}
