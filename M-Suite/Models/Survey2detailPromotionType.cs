using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class Survey2detailPromotionType
{
    public int SrdpId { get; set; }

    public int SrdpSrdId { get; set; }

    public int SrdpCdIdSrdpt { get; set; }

    public string? SrdpComments { get; set; }

    public virtual Codesc SrdpCdIdSrdptNavigation { get; set; } = null!;

    public virtual Survey2Detail SrdpSrd { get; set; } = null!;
}
