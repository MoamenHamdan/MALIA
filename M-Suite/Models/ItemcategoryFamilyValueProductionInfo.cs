using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ItemcategoryFamilyValueProductionInfo
{
    public int? IIcfvId { get; set; }

    public int IIcfId { get; set; }

    public string IIcfvCode { get; set; } = null!;

    public string IIcfvDescriptionLan1 { get; set; } = null!;

    public string IIcfvDescriptionLan2 { get; set; } = null!;
}
