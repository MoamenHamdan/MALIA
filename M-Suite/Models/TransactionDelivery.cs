using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class TransactionDelivery
{
    public int TsdId { get; set; }

    public int? TsdOrgId { get; set; }

    public int? TsdUsId { get; set; }

    public int TsdBuId { get; set; }

    public int? TsdVtId { get; set; }

    public int TsdTstId { get; set; }

    public int? TsdTssId { get; set; }

    public int TsdCdIdSrc { get; set; }

    public int TsdCdIdCur { get; set; }

    public int? TsdCdIdCms { get; set; }

    public int? TsdThpsIdBill { get; set; }

    public int? TsdThpsIdShip { get; set; }

    public int? TsdSgdId { get; set; }

    public string TsdNumber { get; set; } = null!;

    public string? TsdOurReference { get; set; }

    public string? TsdTheirReference { get; set; }

    public DateTime? TsdDueDate { get; set; }

    public DateTime TsdDate { get; set; }

    public decimal? TsdDiscount { get; set; }

    public decimal TsdTotalDiscount { get; set; }

    public decimal? TsdTotalDiscountBc { get; set; }

    public decimal? TsdTotalTax { get; set; }

    public decimal? TsdTotalTaxBc { get; set; }

    public decimal TsdTotal { get; set; }

    public decimal? TsdTotalBc { get; set; }

    public string? TsdRemarks { get; set; }

    public DateTime? TsdCreateDate { get; set; }

    public DateTime? TsdModifiedDate { get; set; }

    public decimal? TsdCurRate { get; set; }

    public decimal? TsdInvCurRate { get; set; }

    public int? TsdUsIdCreatedby { get; set; }

    public int? TsdPtId { get; set; }

    public string? TsdAttribute01 { get; set; }

    public string? TsdAttribute02 { get; set; }

    public string? TsdAttribute03 { get; set; }

    public decimal? TsdDiscountAmount { get; set; }

    public string? TsdUid { get; set; }

    public decimal? TsdTotalFinal { get; set; }

    public decimal? TsdCrRate { get; set; }

    public string? TsdTsUid { get; set; }

    public int? TsdTsId { get; set; }

    public virtual ICollection<TransactionDeliveryItem> TransactionDeliveryItems { get; set; } = new List<TransactionDeliveryItem>();

    public virtual BusinessUnit TsdBu { get; set; } = null!;

    public virtual Codesc? TsdCdIdCmsNavigation { get; set; }

    public virtual Codesc TsdCdIdCurNavigation { get; set; } = null!;

    public virtual Codesc TsdCdIdSrcNavigation { get; set; } = null!;

    public virtual SignatureDetail? TsdSgd { get; set; }

    public virtual ThirdpartySite? TsdThpsIdBillNavigation { get; set; }

    public virtual ThirdpartySite? TsdThpsIdShipNavigation { get; set; }

    public virtual Transactionstatus? TsdTss { get; set; }

    public virtual Transactiontype1 TsdTst { get; set; } = null!;

    public virtual User? TsdUs { get; set; }

    public virtual Visit? TsdVt { get; set; }
}
