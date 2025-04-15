using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ProductCategoryFamilyValue
{
    public int? PcfvPrId { get; set; }

    public int? PcfvPcfId { get; set; }

    public string PcfvCodePcf { get; set; } = null!;

    public int? PcfvPkId { get; set; }

    public int? PcfvPcvId { get; set; }
}
