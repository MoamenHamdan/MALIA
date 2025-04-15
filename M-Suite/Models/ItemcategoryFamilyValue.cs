using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ItemcategoryFamilyValue
{
    public int IcfvId { get; set; }

    public int? IcfvIcfId { get; set; }

    public string IcfvCode { get; set; } = null!;

    public string? IcfvDescriptionLan1 { get; set; }

    public string? IcfvDescriptionLan2 { get; set; }

    public string? IcfvDescriptionLan3 { get; set; }

    public int? IcfvOrder { get; set; }

    public virtual ItemcategoryFamily? IcfvIcf { get; set; }

    public virtual ICollection<ItemCategoryValue> ItemCategoryValues { get; set; } = new List<ItemCategoryValue>();

    public virtual ICollection<ItemcategoryValueLink> ItemcategoryValueLinkIclIcfvIdChildNavigations { get; set; } = new List<ItemcategoryValueLink>();

    public virtual ICollection<ItemcategoryValueLink> ItemcategoryValueLinkIclIcfvIdParentNavigations { get; set; } = new List<ItemcategoryValueLink>();

    public virtual ICollection<TargetDetail> TargetDetails { get; set; } = new List<TargetDetail>();
}
