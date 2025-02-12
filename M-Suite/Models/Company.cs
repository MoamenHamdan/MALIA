using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class Company
{
    public int CpId { get; set; }

    public string CpNameLan1 { get; set; } = null!;

    public string? CpNameLan2 { get; set; }

    public string? CpNameLan3 { get; set; }

    public string CpRegistryNo { get; set; } = null!;

    public string CpPrintableName { get; set; } = null!;

    public string? CpAddress { get; set; }

    public string? CpContactPerson { get; set; }

    public string? CpPhone { get; set; }

    public string? CpEmail { get; set; }

    public string? CpWebsite { get; set; }

    public string? CpLogo { get; set; }

    public virtual ICollection<BusinessUnit> BusinessUnits { get; set; } = new List<BusinessUnit>();
}
