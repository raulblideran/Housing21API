using System;
using System.Collections.Generic;

namespace Housing21.Models;

public partial class User
{
    
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public DateTime Dob { get; set; }

    public string Phonenumber { get; set; } = null!;

    public string Email { get; set; } = null!;

}
