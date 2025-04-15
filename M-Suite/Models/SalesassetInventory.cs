using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class SalesassetInventory
{
    public int AtiId { get; set; }

    public int AtiUsId { get; set; }

    public int AtiVtId { get; set; }

    public int AtiThpsId { get; set; }

    public DateTime AtiDatetime { get; set; }

    public string? AtiRemark { get; set; }

    public string? AtiLatitude { get; set; }

    public string? AtiLongitude { get; set; }

    public int? AtiOrgId { get; set; }

    public virtual ThirdpartySite AtiThps { get; set; } = null!;

    public virtual User AtiUs { get; set; } = null!;

    public virtual Visit AtiVt { get; set; } = null!;

    public virtual ICollection<SalesassetAtiPicture> SalesassetAtiPictures { get; set; } = new List<SalesassetAtiPicture>();

    public virtual ICollection<SalesassetInventoryDetail> SalesassetInventoryDetails { get; set; } = new List<SalesassetInventoryDetail>();
}
