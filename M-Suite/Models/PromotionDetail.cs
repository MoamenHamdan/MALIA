using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class PromotionDetail
{
    public int PndId { get; set; }

    public int PndPnId { get; set; }

    public int? PndCdIdPil { get; set; }

    public int? PndUomIdBuy { get; set; }

    public int? PndUomIdGet { get; set; }

    public int? PndCdIdPec { get; set; }

    public string PndCode { get; set; } = null!;

    public string PndDescriptionLan1 { get; set; } = null!;

    public string PndDescriptionLan2 { get; set; } = null!;

    public string PndDescriptionLan3 { get; set; } = null!;

    public int? PndPrecedence { get; set; }

    public int PndApplyOrder { get; set; }

    public int? PndBucket { get; set; }

    public int? PndDeduceValue { get; set; }

    public int PndCyclicOrder { get; set; }

    public int PndElligibiltyCount { get; set; }

    public int PndRecurringCount { get; set; }

    public short PndLineConditional { get; set; }

    public short PndBuyPerTotal { get; set; }

    public decimal PndBuyFrom { get; set; }

    public decimal PndBuyTo { get; set; }

    public decimal PndGetValue { get; set; }

    public decimal PndGetValueMax { get; set; }

    public int PndGetFromSame { get; set; }

    public int PndActive { get; set; }

    public int? PndCdIdPas { get; set; }

    public int? PndCdIdPaqs { get; set; }

    public int? PndCdIdPao { get; set; }

    public int? PndCdIdPast { get; set; }

    public int? PndCdIdPaqp { get; set; }

    public int? PndCdIdPgn { get; set; }

    public decimal PndCyclicValue { get; set; }

    public decimal? PndGetValuePerc { get; set; }

    public decimal PndForeach { get; set; }

    public int PndMandatory { get; set; }

    public string PndAppliesOn { get; set; } = null!;

    public short PndPromptSf { get; set; }

    public int? PndCdIdPrtypeBuy { get; set; }

    public int? PndCdIdPrtypeGet { get; set; }

    public virtual Codesc? PndCdIdPecNavigation { get; set; }

    public virtual Codesc? PndCdIdPilNavigation { get; set; }

    public virtual Codesc? PndCdIdPrtypeBuyNavigation { get; set; }

    public virtual Codesc? PndCdIdPrtypeGetNavigation { get; set; }

    public virtual PromotionMaster PndPn { get; set; } = null!;

    public virtual Uom? PndUomIdBuyNavigation { get; set; }

    public virtual Uom? PndUomIdGetNavigation { get; set; }

    public virtual ICollection<PromotionDetailQualifier> PromotionDetailQualifiers { get; set; } = new List<PromotionDetailQualifier>();

    public virtual ICollection<PromotionGive> PromotionGives { get; set; } = new List<PromotionGive>();

    public virtual ICollection<PromotionLine> PromotionLines { get; set; } = new List<PromotionLine>();

    public virtual ICollection<PromotionsliceBuyDetail> PromotionsliceBuyDetails { get; set; } = new List<PromotionsliceBuyDetail>();

    public virtual ICollection<PromotionsliceBuy> PromotionsliceBuys { get; set; } = new List<PromotionsliceBuy>();

    public virtual ICollection<PromotionsliceGetDetail> PromotionsliceGetDetails { get; set; } = new List<PromotionsliceGetDetail>();

    public virtual ICollection<PromotionsliceGet> PromotionsliceGets { get; set; } = new List<PromotionsliceGet>();

    public virtual ICollection<TransactionItemPromotion> TransactionItemPromotions { get; set; } = new List<TransactionItemPromotion>();
}
