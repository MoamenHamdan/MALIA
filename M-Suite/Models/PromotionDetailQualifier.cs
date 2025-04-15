using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class PromotionDetailQualifier
{
    public int PndqId { get; set; }

    public int PndqPnId { get; set; }

    public int PndqPndId { get; set; }

    public int PndqQlvId { get; set; }

    public int PndqCdIdCop { get; set; }

    public int PndqGroupingNo { get; set; }

    public int? PndqAttributeValueFrom { get; set; }

    public int? PndqAttributeValueTo { get; set; }

    public int PndqQlId { get; set; }

    public virtual Codesc PndqCdIdCopNavigation { get; set; } = null!;

    public virtual PromotionMaster PndqPn { get; set; } = null!;

    public virtual PromotionDetail PndqPnd { get; set; } = null!;

    public virtual PromotionQualifier PndqQl { get; set; } = null!;
}
