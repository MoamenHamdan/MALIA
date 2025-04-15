using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ThpsItemcontainer
{
    public int TsicId { get; set; }

    public int TsicThpsId { get; set; }

    public int TsicIcId { get; set; }

    public string? TsicBarcode { get; set; }

    public short TsicQuantity { get; set; }

    public virtual Itemcontainer TsicIc { get; set; } = null!;

    public virtual ThirdpartySite TsicThps { get; set; } = null!;
}
