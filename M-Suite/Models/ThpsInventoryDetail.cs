using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ThpsInventoryDetail
{
    public int ThpsidId { get; set; }

    public int? ThpsidThpsiId { get; set; }

    public int? ThpsidThpsiOrgId { get; set; }

    public int? ThpsidItId { get; set; }

    public int? ThpsidUomId { get; set; }

    public int? ThpsidIldId { get; set; }

    public decimal? ThpsidQuantity { get; set; }

    public virtual ItemLotDate? ThpsidIld { get; set; }

    public virtual Item? ThpsidIt { get; set; }

    public virtual Uom? ThpsidUom { get; set; }
}
