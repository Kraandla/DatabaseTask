using System;
using System.Collections.Generic;

namespace DatabaseTask.Models;

public partial class Address
{
    public string Employeeid { get; set; } = null!;

    public string? Postalcode { get; set; }

    public short? Squaremeters { get; set; }

    public byte? Buildingapartment { get; set; }

    public short? Buildingnumber { get; set; }

    public string? Townname { get; set; }

    public string? Streetname { get; set; }

    public string? Administrativedivision { get; set; }

    public string? Country { get; set; }

    public virtual Employee Employee { get; set; } = null!;
}
