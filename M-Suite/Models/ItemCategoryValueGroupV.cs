using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ItemCategoryValueGroupV
{
    public int IcvId { get; set; }

    public int IcvItId { get; set; }

    public int IcvIcfId { get; set; }

    public int? IcvIcfvId { get; set; }

    public string? IcvValue { get; set; }
}
