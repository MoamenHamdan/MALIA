using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ItemWarehouse
{
    public int ItwId { get; set; }

    public int ItwPlIdWhs { get; set; }

    public int ItwItId { get; set; }

    public int ItwUomId { get; set; }

    public decimal ItwQuantity { get; set; }

    public decimal ItwQuantityDamage { get; set; }

    public decimal ItwQuantityReserved { get; set; }

    public decimal? ItwQuantityPreviewed { get; set; }

    public DateTime? ItwCreationDate { get; set; }

    public int? ItwCreatedBy { get; set; }

    public DateTime? ItwUpdateDate { get; set; }

    public int? ItwUpdatedBy { get; set; }

    public string? ItwRemarks { get; set; }

    public virtual ICollection<ItemWarehouseDetail> ItemWarehouseDetails { get; set; } = new List<ItemWarehouseDetail>();

    public virtual Item ItwIt { get; set; } = null!;

    public virtual PhysicalLocation ItwPlIdWhsNavigation { get; set; } = null!;

    public virtual Uom ItwUom { get; set; } = null!;
}
