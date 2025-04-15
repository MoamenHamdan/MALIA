using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ImpItemWarehouseV
{
    public int IItwPlIdWhs { get; set; }

    public int IItwItId { get; set; }

    public int IItwUomId { get; set; }

    public decimal? IItwQuantity { get; set; }

    public int IItwQuantityDamage { get; set; }

    public int IItwQuantityReserved { get; set; }
}
