using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class PromotionsliceBuy
{
    public int PsbId { get; set; }

    public int PsbPndId { get; set; }

    public int PsbIcfId { get; set; }

    public int PsbIcfvId { get; set; }

    public virtual PromotionDetail PsbPnd { get; set; } = null!;
}
