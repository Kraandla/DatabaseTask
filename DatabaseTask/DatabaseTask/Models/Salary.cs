using System;
using System.Collections.Generic;

namespace DatabaseTask.Models;

public partial class Salary
{
    public string Employeeid { get; set; } = null!;

    public decimal? Salaryamount { get; set; }

    public decimal? Bonus { get; set; }

    public DateOnly? Startdate { get; set; }

    public virtual Employee Employee { get; set; } = null!;
}
