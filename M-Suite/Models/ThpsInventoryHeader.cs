using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ThpsInventoryHeader
{
    public int TihId { get; set; }

    public int? TihBuId { get; set; }

    public int? TihCdIdTivt { get; set; }

    public int TihCdIdTivs { get; set; }

    public int TihUsId { get; set; }

    public string TihCode { get; set; } = null!;

    public string? TihDescription { get; set; }

    public DateTime TihDateStart { get; set; }

    public DateTime TihDateEnd { get; set; }

    public short TihCount { get; set; }

    public short TihAllItems { get; set; }

    public short TihAllThps { get; set; }

    public short TihAllGeo { get; set; }

    public short TihAllUser { get; set; }

    public short TihItemLotDate { get; set; }

    public string? TihRemarks { get; set; }

    public DateTime TihCreateDate { get; set; }

    public DateTime TihModifiedDate { get; set; }

    public short TihActive { get; set; }

    public short? TihMandatory { get; set; }

    public virtual ICollection<ThpsInventory> ThpsInventories { get; set; } = new List<ThpsInventory>();

    public virtual ICollection<ThpsInventoryheaderGl> ThpsInventoryheaderGls { get; set; } = new List<ThpsInventoryheaderGl>();

    public virtual ICollection<ThpsInventoryheaderThp> ThpsInventoryheaderThps { get; set; } = new List<ThpsInventoryheaderThp>();

    public virtual ICollection<ThpsInventoryheaderUser> ThpsInventoryheaderUsers { get; set; } = new List<ThpsInventoryheaderUser>();

    public virtual BusinessUnit? TihBu { get; set; }
}
