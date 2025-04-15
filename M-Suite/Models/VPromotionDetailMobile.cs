using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VPromotionDetailMobile
{
    public int PndId { get; set; }

    public int PndPnId { get; set; }

    public int PndBeId { get; set; }

    public int PndCdIdPil { get; set; }

    public int? PndUomIdBuy { get; set; }

    public int? PndUomIdGet { get; set; }

    public int PndCdIdPec { get; set; }

    public string PndCode { get; set; } = null!;

    public string PndDescription { get; set; } = null!;

    public string PndDescriptionAr { get; set; } = null!;

    public int? PndPrecedence { get; set; }

    public int PndApplyOrder { get; set; }

    public int? PndBucket { get; set; }

    public int PndDeduceValue { get; set; }

    public int PndCyclicOrder { get; set; }

    public int PndElligibiltyCount { get; set; }

    public int PndRecurringCount { get; set; }

    public short PndLineConditional { get; set; }

    public short PndBuyPerTotal { get; set; }

    public string? PndBuyFrom { get; set; }

    public string? PndBuyTo { get; set; }

    public string? PndGetValue { get; set; }

    public string? PndGetValueMax { get; set; }

    public int PndGetFromSame { get; set; }

    public int PndActive { get; set; }

    public string? PndBuyAnySelection { get; set; }

    public string? PndBuyAmountQuantitySku { get; set; }

    public string? PndAmountIsGrossNet { get; set; }

    public string? PndBuyAndOr { get; set; }

    public string? PndGetSelectTotalAny { get; set; }

    public string? PndGetPerAmountQuantity { get; set; }

    public int PndLineCountPnl { get; set; }

    public int PndLineCountPng { get; set; }

    public string? PndGetValuePerc { get; set; }

    public int PndMandatory { get; set; }

    public decimal PndForeach { get; set; }

    public decimal PndCyclicValue { get; set; }
}
