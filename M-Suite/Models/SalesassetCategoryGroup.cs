using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class SalesassetCategoryGroup
{
    public int AtgcId { get; set; }

    public int AtgcAcfId { get; set; }

    public int AtgcCdIdAtg { get; set; }

    public short AtgcActive { get; set; }

    public short? AtgcMandatory { get; set; }

    public short AtgcOrder { get; set; }

    public virtual SalesassetCategoryFamily AtgcAcf { get; set; } = null!;

    public virtual Codesc AtgcCdIdAtgNavigation { get; set; } = null!;
}
