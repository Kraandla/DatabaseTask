using System;
using System.Collections.Generic;

namespace DatabaseTask.Models;

public partial class Employee
{
    public string Id { get; set; } = null!;

    public string? Firstname { get; set; }

    public string? Lastname { get; set; }

    public DateOnly? Birthdate { get; set; }

    public byte? Phone { get; set; }

    public string? Email { get; set; }

    public byte? Positioncode { get; set; }

    public byte? Addresscode { get; set; }

    public string? Jobhistoryid { get; set; }

    public virtual Address? Address { get; set; }

    public virtual ICollection<Child> Children { get; set; } = new List<Child>();

    public virtual ICollection<Healthcheck> Healthchecks { get; set; } = new List<Healthcheck>();

    public virtual Salary? Salary { get; set; }

    public virtual Sickleave? Sickleave { get; set; }
}
