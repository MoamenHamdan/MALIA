using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class InventoryItem
{
    public int IviId { get; set; }

    public int IviIvId { get; set; }

    public int? IviPlId { get; set; }

    public int IviItId { get; set; }

    public int IviUomId { get; set; }

    public int? IviIldId { get; set; }

    public int? IviCdIdIit { get; set; }

    public decimal IviQuantity { get; set; }

    public decimal IviQuantityExpected { get; set; }

    public string? IviRemarks { get; set; }

    public virtual Codesc? IviCdIdIitNavigation { get; set; }

    public virtual ItemLotDate? IviIld { get; set; }

    public virtual Item IviIt { get; set; } = null!;

    public virtual Inventory1 IviIv { get; set; } = null!;

    public virtual PhysicalLocation? IviPl { get; set; }

    public virtual Uom IviUom { get; set; } = null!;
}
