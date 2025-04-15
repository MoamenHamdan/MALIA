using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ThirdpartyGroupCategory
{
    public int ThgcId { get; set; }

    public int ThgcThcfId { get; set; }

    public int ThgcCdIdTpg { get; set; }

    public short ThgcMandatory { get; set; }

    public short ThgcActive { get; set; }

    public virtual Codesc ThgcCdIdTpgNavigation { get; set; } = null!;

    public virtual ThirdpartycategoryFamily ThgcThcf { get; set; } = null!;
}
