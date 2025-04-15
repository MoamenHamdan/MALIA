using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class SalesAsset
{
    public int AtId { get; set; }

    public int AtCdIdAtg { get; set; }

    public int AtCdIdAts { get; set; }

    public int AtCdIdAtn { get; set; }

    public string? AtBarcode { get; set; }

    public string AtCode { get; set; } = null!;

    public string AtDescriptionLan1 { get; set; } = null!;

    public string? AtDescriptionLan2 { get; set; }

    public string? AtDescriptionLan3 { get; set; }

    public int? AtOrgId { get; set; }

    public virtual Codesc AtCdIdAtgNavigation { get; set; } = null!;

    public virtual Codesc AtCdIdAtnNavigation { get; set; } = null!;

    public virtual Codesc AtCdIdAtsNavigation { get; set; } = null!;

    public virtual ICollection<SalesassetCategoryValue> SalesassetCategoryValues { get; set; } = new List<SalesassetCategoryValue>();

    public virtual ICollection<SalesassetHistory> SalesassetHistories { get; set; } = new List<SalesassetHistory>();

    public virtual ICollection<SalesassetInventoryDetail> SalesassetInventoryDetails { get; set; } = new List<SalesassetInventoryDetail>();
}
