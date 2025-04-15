using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class Inventory1
{
    public int IvId { get; set; }

    public int IvIvhId { get; set; }

    public int IvUsId { get; set; }

    public int IvCdIdIvs { get; set; }

    public string IvCode { get; set; } = null!;

    public DateTime IvDate { get; set; }

    public DateTime? IvDateStart { get; set; }

    public DateTime IvDateEnd { get; set; }

    public string? IvRemarks { get; set; }

    public DateTime IvCreateDate { get; set; }

    public DateTime IvModifiedDate { get; set; }

    public short IvActive { get; set; }

    public int? IvOrgId { get; set; }

    public virtual ICollection<InventoryItem> InventoryItems { get; set; } = new List<InventoryItem>();

    public virtual ICollection<InventoryLinePhysicallocation> InventoryLinePhysicallocations { get; set; } = new List<InventoryLinePhysicallocation>();

    public virtual ICollection<InventoryLineThirdpartySite> InventoryLineThirdpartySites { get; set; } = new List<InventoryLineThirdpartySite>();

    public virtual Codesc IvCdIdIvsNavigation { get; set; } = null!;

    public virtual InventoryHeader IvIvh { get; set; } = null!;

    public virtual User IvUs { get; set; } = null!;
}
