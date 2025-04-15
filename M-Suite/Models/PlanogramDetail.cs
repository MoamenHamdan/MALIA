using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class PlanogramDetail
{
    public int PlndId { get; set; }

    public int PlndPlnId { get; set; }

    public string? PlndDescription { get; set; }

    public string PlndPath { get; set; } = null!;

    public string PlndFilename { get; set; } = null!;

    public int? PlndExt { get; set; }

    public string? PlndText1 { get; set; }

    public int? PlndActive { get; set; }

    public short PlndMain { get; set; }

    public DateTime? PlndCreationDate { get; set; }

    public int PlndUsIdCr { get; set; }

    public virtual Planogram PlndPln { get; set; } = null!;

    public virtual User PlndUsIdCrNavigation { get; set; } = null!;
}
