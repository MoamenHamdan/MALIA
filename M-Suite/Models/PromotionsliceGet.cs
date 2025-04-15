using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class PromotionsliceGet
{
    public int PsgId { get; set; }

    public int PsgPndId { get; set; }

    public int PsgIcfId { get; set; }

    public int PsgIcfvId { get; set; }

    public virtual PromotionDetail PsgPnd { get; set; } = null!;
}
