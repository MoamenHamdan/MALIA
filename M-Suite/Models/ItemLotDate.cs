using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ItemLotDate
{
    public int IldId { get; set; }

    public int? IldItId { get; set; }

    public string IldShortDescription { get; set; } = null!;

    public string? IldNumber { get; set; }

    public DateTime? IldProdutionDate { get; set; }

    public DateTime? IldExpiryDate { get; set; }

    public DateTime IldCreationDate { get; set; }

    public short? IldActive { get; set; }

    public virtual Item? IldIt { get; set; }

    public virtual ICollection<InventoryItem> InventoryItems { get; set; } = new List<InventoryItem>();

    public virtual ICollection<ThpsInventoryDetail> ThpsInventoryDetails { get; set; } = new List<ThpsInventoryDetail>();
}
