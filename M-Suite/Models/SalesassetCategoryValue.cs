using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class SalesassetCategoryValue
{
    public int AcvId { get; set; }

    public int AcvAtId { get; set; }

    public int AcvAcfId { get; set; }

    public int? AcvAcfvId { get; set; }

    public string? AcvValue { get; set; }

    public virtual SalesassetCategoryFamily AcvAcf { get; set; } = null!;

    public virtual SalesassetCategoryFamilyValue? AcvAcfv { get; set; }

    public virtual SalesAsset AcvAt { get; set; } = null!;
}
