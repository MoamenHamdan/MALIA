using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ItemcontainerDetail
{
    public int IcdId { get; set; }

    public int IcdIcId { get; set; }

    public int IcdItId { get; set; }

    public int IcdUomId { get; set; }

    public decimal? IcdQuantityMin { get; set; }

    public decimal? IcdQuantity { get; set; }

    public decimal? IcdQuantityMax { get; set; }

    public virtual Itemcontainer IcdIc { get; set; } = null!;

    public virtual Item IcdIt { get; set; } = null!;

    public virtual Uom IcdUom { get; set; } = null!;
}
