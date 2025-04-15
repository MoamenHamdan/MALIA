using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ImpPriceListV
{
    public int IPlBuId { get; set; }

    public int IPlCdIdCur { get; set; }

    public string IPlCode { get; set; } = null!;

    public string IPlDescriptionLan1 { get; set; } = null!;

    public string IPlDescriptionLan2 { get; set; } = null!;

    public string IPlDescriptionLan3 { get; set; } = null!;

    public DateOnly? IPlFromDate { get; set; }

    public DateOnly? IPlToDate { get; set; }

    public int IPlActive { get; set; }

    public int? ILpId { get; set; }
}
