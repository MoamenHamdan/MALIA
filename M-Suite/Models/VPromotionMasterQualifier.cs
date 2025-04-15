using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VPromotionMasterQualifier
{
    public int PnqId { get; set; }

    public int PnqPnId { get; set; }

    public int PnqQlvId { get; set; }

    public int PnqCdIdCop { get; set; }

    public int PnBuId { get; set; }

    public int? PnqRefId { get; set; }

    public int PnqGroupingNo { get; set; }

    public int? PnqAttributeValueFrom { get; set; }

    public int? PnqAttributeValueTo { get; set; }

    public string PnqCodeQl { get; set; } = null!;

    public string PnqDescriptionQl { get; set; } = null!;

    public string PnqDescriptionQlAr { get; set; } = null!;

    public string PnqCdCodeCop { get; set; } = null!;

    public string? PnqCdDescriptionCop { get; set; }

    public string? PnqCdDescriptionCopAr { get; set; }

    public int? PnqNbValues { get; set; }

    public string? PnqOperator { get; set; }

    public int PnqIngridEdit { get; set; }

    public short PndIsForeignKey { get; set; }
}
