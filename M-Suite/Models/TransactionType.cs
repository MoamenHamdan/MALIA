using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class TransactionType
{
    public int TtId { get; set; }

    public int TtCdIdRit { get; set; }

    public int TtBeId { get; set; }

    public int? TtUgmId { get; set; }

    public string TtCode { get; set; } = null!;

    public string TtDescription { get; set; } = null!;

    public int? TtImageIndex { get; set; }

    public string? TtColWidthSearch { get; set; }

    public string? TtColWidthDetail { get; set; }

    public string? TtUomColWidth { get; set; }

    public string? TtPrintingCode { get; set; }

    public string? TtMessageCode { get; set; }

    public string? TtUomSelectCode { get; set; }

    public int? TtCheckCreditLimit { get; set; }

    public int TtManageLotExprod { get; set; }

    public int TtApplyPromotion { get; set; }

    public int? TtApplyAdjustment { get; set; }

    public int? TtApplyConstraints { get; set; }

    public int? TtAllowOverstock { get; set; }

    public int? TtAllowFreeGood { get; set; }

    public int? TtAllowDiscountChange { get; set; }

    public int? TtAllowCustDiscountChange { get; set; }

    public int TtCollect { get; set; }

    public int? TtGenerateDueTrans { get; set; }

    public int TtUpdateStock { get; set; }

    public int? TtNumberOfDocumentPrint { get; set; }

    public int? TtDisplaySearchCriteria { get; set; }

    public string? TtText1 { get; set; }

    public string? TtText2 { get; set; }

    public string? TtText3 { get; set; }

    public decimal? TtNum1 { get; set; }

    public decimal? TtNum2 { get; set; }

    public decimal? TtNum3 { get; set; }

    public DateTime? TtDate1 { get; set; }

    public DateTime? TtDate2 { get; set; }

    public string TtDescriptionAr { get; set; } = null!;

    public int TtExportFlag { get; set; }

    public string? TtHeaderExportCode { get; set; }

    public string? TtLineExportCode { get; set; }

    public virtual ICollection<TransactionTypeOption> TransactionTypeOptions { get; set; } = new List<TransactionTypeOption>();
}
