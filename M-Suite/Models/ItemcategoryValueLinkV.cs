using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ItemcategoryValueLinkV
{
    public int IclId { get; set; }

    public int? IclIcfvIdParent { get; set; }

    public int IclIcfvIdChild { get; set; }

    public int IcfvId { get; set; }

    public int? IcfvIcfId { get; set; }

    public string IcfvCode { get; set; } = null!;

    public string? IcfvDescriptionLan1 { get; set; }

    public string? IcfvDescriptionLan2 { get; set; }

    public string? IcfvDescriptionLan3 { get; set; }
}
