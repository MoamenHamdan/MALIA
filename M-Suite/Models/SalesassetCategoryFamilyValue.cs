using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class SalesassetCategoryFamilyValue
{
    public int AcfvId { get; set; }

    public int? AcfvAcfId { get; set; }

    public string AcfvCode { get; set; } = null!;

    public string? AcfvDescriptionLan1 { get; set; }

    public string? AcfvDescriptionLan2 { get; set; }

    public string? AcfvDescriptionLan3 { get; set; }

    public virtual SalesassetCategoryFamily? AcfvAcf { get; set; }

    public virtual ICollection<SalesassetCategoryValue> SalesassetCategoryValues { get; set; } = new List<SalesassetCategoryValue>();
}
