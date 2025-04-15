using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class Planogram
{
    public int PlnId { get; set; }

    public string PlnCode { get; set; } = null!;

    public string PlnDescriptionLan1 { get; set; } = null!;

    public string? PlnDescriptionLan2 { get; set; }

    public string? PlnDescriptionLan3 { get; set; }

    public short? PlnActive { get; set; }

    public DateTime PlnFromDate { get; set; }

    public DateTime PlnToDate { get; set; }

    public short? PlnAllCustomers { get; set; }

    public short? PlnAllUsers { get; set; }

    public int PlnUsIdCr { get; set; }

    public DateTime? PlnCreationDate { get; set; }

    public int? PlnUsIdUp { get; set; }

    public DateTime? PlnUpdateDate { get; set; }

    public virtual ICollection<PlanogramDetail> PlanogramDetails { get; set; } = new List<PlanogramDetail>();

    public virtual ICollection<PlanogramThp> PlanogramThps { get; set; } = new List<PlanogramThp>();

    public virtual ICollection<PlanogramUser> PlanogramUsers { get; set; } = new List<PlanogramUser>();

    public virtual User PlnUsIdCrNavigation { get; set; } = null!;
}
