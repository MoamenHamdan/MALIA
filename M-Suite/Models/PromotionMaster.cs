using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class PromotionMaster
{
    public int PnId { get; set; }

    public int PnBuId { get; set; }

    public int PnCdIdPtp { get; set; }

    public int? PnCdIdPpb { get; set; }

    public string PnCode { get; set; } = null!;

    public string PnDescriptionLan1 { get; set; } = null!;

    public string PnDescriptionLan2 { get; set; } = null!;

    public string PnDescriptionLan3 { get; set; } = null!;

    public DateTime PnFromDate { get; set; }

    public DateTime PnToDate { get; set; }

    public int PnActive { get; set; }

    public int? PnCdIdCql { get; set; }

    public virtual BusinessUnit PnBu { get; set; } = null!;

    public virtual Codesc? PnCdIdCqlNavigation { get; set; }

    public virtual Codesc? PnCdIdPpbNavigation { get; set; }

    public virtual Codesc PnCdIdPtpNavigation { get; set; } = null!;

    public virtual ICollection<PromotionDetailQualifier> PromotionDetailQualifiers { get; set; } = new List<PromotionDetailQualifier>();

    public virtual ICollection<PromotionDetail> PromotionDetails { get; set; } = new List<PromotionDetail>();

    public virtual ICollection<PromotionGive> PromotionGives { get; set; } = new List<PromotionGive>();

    public virtual ICollection<PromotionLine> PromotionLines { get; set; } = new List<PromotionLine>();

    public virtual ICollection<PromotionMasterQualifier> PromotionMasterQualifiers { get; set; } = new List<PromotionMasterQualifier>();
}
