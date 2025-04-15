using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ProductCategoryValue
{
    public int? PcvId { get; set; }

    public int? PcvPcfId { get; set; }

    public int? PcvPkId { get; set; }

    public string PcvCode { get; set; } = null!;

    public string? PcvDescription { get; set; }

    public string? PcvDescriptionAr { get; set; }

    public string PcvCodePcf { get; set; } = null!;

    public string PcvDescriptionPcf { get; set; } = null!;

    public string PcvDescriptionPcfAr { get; set; } = null!;
}
