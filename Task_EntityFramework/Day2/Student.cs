using System;
using System.Collections.Generic;

namespace TaskDay2_EF.Models;

public partial class Student
{
    public int StudentId { get; set; }

    public string FullName { get; set; } = null!;

    public int Age { get; set; }

    public string? Email { get; set; }
}
