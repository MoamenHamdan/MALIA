using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class Survey2Detail
{
    public int SrdId { get; set; }

    public int SrdSrId { get; set; }

    public int? SrdCdIdFrq { get; set; }

    public int? SrdUsId { get; set; }

    public DateTime SrdDateFrom { get; set; }

    public DateTime SrdDateTo { get; set; }

    public short SrdCdIdSrdsts { get; set; }

    public int SrdOccurence { get; set; }

    public DateTime SrdCreationDate { get; set; }

    public int SrdUsIdCr { get; set; }

    public DateTime? SrdReminderDate { get; set; }

    public int? SrdIcfId { get; set; }

    public int? SrdIcfvId { get; set; }

    public string? SrdNotes { get; set; }

    public int? SrdCdIdSrdtp { get; set; }

    public int? SrdCdIdSrdct { get; set; }

    public int? SrdCdIdSrdagr { get; set; }

    public decimal? SrdBudget { get; set; }

    public int? SrdCdIdCur { get; set; }

    public int? SrdFacing { get; set; }

    public string? SrdComments { get; set; }

    public int? SrdOrgId { get; set; }

    public virtual Survey2 SrdSr { get; set; } = null!;

    public virtual User? SrdUs { get; set; }

    public virtual User SrdUsIdCrNavigation { get; set; } = null!;

    public virtual ICollection<Survey2detailPromotionType> Survey2detailPromotionTypes { get; set; } = new List<Survey2detailPromotionType>();
}
