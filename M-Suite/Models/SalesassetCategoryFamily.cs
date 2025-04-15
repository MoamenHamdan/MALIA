using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class SalesassetCategoryFamily
{
    public int AcfId { get; set; }

    public int? AcfAcfId { get; set; }

    public int? AcfBuId { get; set; }

    public short AcfLevel { get; set; }

    public string AcfCode { get; set; } = null!;

    public string AcfDescriptionLan1 { get; set; } = null!;

    public string AcfDescriptionLan2 { get; set; } = null!;

    public string AcfDescriptionLan3 { get; set; } = null!;

    public short AcfIsLov { get; set; }

    public string? AcfRegex { get; set; }

    public virtual SalesassetCategoryFamily? AcfAcf { get; set; }

    public virtual ICollection<SalesassetCategoryFamily> InverseAcfAcf { get; set; } = new List<SalesassetCategoryFamily>();

    public virtual ICollection<SalesassetCategoryFamilyValue> SalesassetCategoryFamilyValues { get; set; } = new List<SalesassetCategoryFamilyValue>();

    public virtual ICollection<SalesassetCategoryGroup> SalesassetCategoryGroups { get; set; } = new List<SalesassetCategoryGroup>();

    public virtual ICollection<SalesassetCategoryValue> SalesassetCategoryValues { get; set; } = new List<SalesassetCategoryValue>();
}
