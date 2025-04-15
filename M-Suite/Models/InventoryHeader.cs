using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class InventoryHeader
{
    public int IvhId { get; set; }

    public int? IvhCdIdIvt { get; set; }

    public int IvhCdIdIvs { get; set; }

    public int IvhUsId { get; set; }

    public string IvhCode { get; set; } = null!;

    public string? IvhDescription { get; set; }

    public DateTime IvhDateStart { get; set; }

    public DateTime IvhDateEnd { get; set; }

    public short IvhAllItems { get; set; }

    public short IvhItemLotDate { get; set; }

    public string? IvhRemarks { get; set; }

    public DateTime IvhCreateDate { get; set; }

    public DateTime IvhModifiedDate { get; set; }

    public short IvhActive { get; set; }

    public int? IvhBuId { get; set; }

    public virtual ICollection<Inventory1> Inventory1s { get; set; } = new List<Inventory1>();

    public virtual ICollection<InventoryheaderItem> InventoryheaderItems { get; set; } = new List<InventoryheaderItem>();

    public virtual Codesc IvhCdIdIvsNavigation { get; set; } = null!;

    public virtual Codesc? IvhCdIdIvtNavigation { get; set; }

    public virtual User IvhUs { get; set; } = null!;
}
