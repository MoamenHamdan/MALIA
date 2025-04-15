using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ItemUomBarcode
{
    public int IubId { get; set; }

    public int? IubItuId { get; set; }

    public string IubBarcode { get; set; } = null!;

    public short IubActive { get; set; }

    public virtual ItemUom? IubItu { get; set; }
}
