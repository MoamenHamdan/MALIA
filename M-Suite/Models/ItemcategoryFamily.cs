using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ItemcategoryFamily
{
    public int IcfId { get; set; }

    public int? IcfIcfId { get; set; }

    public int? IcfBuId { get; set; }

    public short IcfLevel { get; set; }

    public string IcfCode { get; set; } = null!;

    public string IcfDescriptionLan1 { get; set; } = null!;

    public string IcfDescriptionLan2 { get; set; } = null!;

    public string IcfDescriptionLan3 { get; set; } = null!;

    public short IcfIsLov { get; set; }

    public string? IcfRegex { get; set; }

    public virtual BusinessUnit? IcfBu { get; set; }

    public virtual ItemcategoryFamily? IcfIcf { get; set; }

    public virtual ICollection<ItemcategoryFamily> InverseIcfIcf { get; set; } = new List<ItemcategoryFamily>();

    public virtual ICollection<ItemCategoryValue> ItemCategoryValues { get; set; } = new List<ItemCategoryValue>();

    public virtual ICollection<ItemcategoryFamilyValue> ItemcategoryFamilyValues { get; set; } = new List<ItemcategoryFamilyValue>();

    public virtual ICollection<ItemcategoryGroup> ItemcategoryGroups { get; set; } = new List<ItemcategoryGroup>();
}
