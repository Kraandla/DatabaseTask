using System;
using System.Collections.Generic;

namespace DatabaseTask.Models;

public partial class Sickleave
{
    public string Employeeid { get; set; } = null!;

    public DateOnly? Startdate { get; set; }

    public DateOnly? Enddate { get; set; }

    public bool? Wasonleave { get; set; }

    public virtual Employee Employee { get; set; } = null!;
}
