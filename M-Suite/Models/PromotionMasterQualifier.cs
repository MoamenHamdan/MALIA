using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class PromotionMasterQualifier
{
    public int PnqId { get; set; }

    public int PnqPnId { get; set; }

    public int PnqQlvId { get; set; }

    public int PnqCdIdCop { get; set; }

    public int PnqGroupingNo { get; set; }

    public int? PnqAttributeValueFrom { get; set; }

    public int? PnqAttributeValueTo { get; set; }

    public int PnqQlId { get; set; }

    public virtual Codesc PnqCdIdCopNavigation { get; set; } = null!;

    public virtual PromotionMaster PnqPn { get; set; } = null!;

    public virtual PromotionQualifier PnqQl { get; set; } = null!;
}
