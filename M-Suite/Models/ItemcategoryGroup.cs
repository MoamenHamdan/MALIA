using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ItemcategoryGroup
{
    public int ItgcId { get; set; }

    public int ItgcIcfId { get; set; }

    public int ItgcCdIdItg { get; set; }

    public short ItgcActive { get; set; }

    public short? ItgcMandatory { get; set; }

    public short ItgcOrder { get; set; }

    public virtual Codesc ItgcCdIdItgNavigation { get; set; } = null!;

    public virtual ItemcategoryFamily ItgcIcf { get; set; } = null!;
}
