using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VPromotionQualifierValue
{
    public int? QlvId { get; set; }

    public int QlvQlId { get; set; }

    public int QlvRefId { get; set; }

    public string? QlvCode { get; set; }

    public string? QlvDescriptionLan1 { get; set; }

    public string? QlvDescriptionLan2 { get; set; }

    public string? QlvDescriptionLan3 { get; set; }

    public string QlvQlCode { get; set; } = null!;

    public string QlvQlDescriptionLan1 { get; set; } = null!;

    public string QlvQlDescriptionLan2 { get; set; } = null!;

    public string QlvQlDescriptionLan3 { get; set; } = null!;
}
