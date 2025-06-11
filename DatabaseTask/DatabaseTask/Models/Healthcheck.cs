using System;
using System.Collections.Generic;

namespace DatabaseTask.Models;

public partial class Healthcheck
{
    public string Id { get; set; } = null!;

    public string? Employeeid { get; set; }

    public DateOnly? Lastcheckdate { get; set; }

    public bool? Ishealthy { get; set; }

    public virtual Employee? Employee { get; set; }
}
