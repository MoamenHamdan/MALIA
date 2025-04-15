using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class SalesassetInventoryDetail
{
    public int AtidId { get; set; }

    public int AtidAtiId { get; set; }

    public int AtidAtId { get; set; }

    public decimal AtidQuantity { get; set; }

    public string? AtidRemark { get; set; }

    public int? AtidOrgId { get; set; }

    public virtual SalesAsset AtidAt { get; set; } = null!;

    public virtual SalesassetInventory AtidAti { get; set; } = null!;

    public virtual ICollection<SalesassetAtidPicture> SalesassetAtidPictures { get; set; } = new List<SalesassetAtidPicture>();
}
