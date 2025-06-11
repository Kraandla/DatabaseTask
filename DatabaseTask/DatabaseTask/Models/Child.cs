using System;
using System.Collections.Generic;

namespace DatabaseTask.Models;

public partial class Child
{
    public string Id { get; set; } = null!;

    public string? Employeeid { get; set; }

    public DateOnly? Birthdate { get; set; }

    public string? Firstname { get; set; }

    public string? Lastname { get; set; }

    public virtual Employee? Employee { get; set; }
}
