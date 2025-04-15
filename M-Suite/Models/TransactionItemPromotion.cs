using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class TransactionItemPromotion
{
    public int TipId { get; set; }

    public int TipTsId { get; set; }

    public int TipTsiId { get; set; }

    public int? TipTsidId { get; set; }

    public int TipPndId { get; set; }

    public decimal? TipValue { get; set; }

    public decimal? TipValueBefore { get; set; }

    public int? TipPndPrecedence { get; set; }

    public int? TipPndApplyOrder { get; set; }

    public int? TipPndBucket { get; set; }

    public virtual PromotionDetail TipPnd { get; set; } = null!;

    public virtual Transaction TipTs { get; set; } = null!;

    public virtual TransactionItem TipTsi { get; set; } = null!;
}
