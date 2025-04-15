using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class MenuActionLogV
{
    public string SalesmanName { get; set; } = null!;

    public string SalesmanCode { get; set; } = null!;

    public string ThpsCode { get; set; } = null!;

    public string ThpsNameLan1 { get; set; } = null!;

    public string? ThpsNameLan2 { get; set; }

    public string? ThpsNameLan3 { get; set; }

    public DateOnly? VtDate { get; set; }

    public DateTime VtTimeIn { get; set; }

    public string? TimeIn { get; set; }

    public string? TimeOut { get; set; }

    public int? VtTimeSpent { get; set; }

    public string? TstDescriptionLan1 { get; set; }

    public string? TstDescriptionLan2 { get; set; }

    public string? TstDescriptionLan3 { get; set; }

    public string? MalStartTime { get; set; }

    public string? MalEndTime { get; set; }

    public int? MalTimeSpent { get; set; }

    public int UsId { get; set; }

    public int ThpsId { get; set; }
}
