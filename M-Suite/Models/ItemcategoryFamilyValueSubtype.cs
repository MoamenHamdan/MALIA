using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ItemcategoryFamilyValueSubtype
{
    public int? IIcfvId { get; set; }

    public int IIcfId { get; set; }

    public string ITpCode { get; set; } = null!;

    public string ITpDescription { get; set; } = null!;

    public string? ITpDescriptionAr { get; set; }
}
