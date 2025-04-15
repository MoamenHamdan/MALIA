using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class Transaction
{
    public int TsId { get; set; }

    public int? TsOrgId { get; set; }

    public int? TsUsId { get; set; }

    public int TsBuId { get; set; }

    public int? TsVtId { get; set; }

    public int TsTstId { get; set; }

    public int? TsTssId { get; set; }

    public int TsCdIdSrc { get; set; }

    public int TsCdIdCur { get; set; }

    public int? TsCdIdCms { get; set; }

    public int? TsThpsIdBill { get; set; }

    public int? TsThpsIdShip { get; set; }

    public int? TsSgdId { get; set; }

    public string TsNumber { get; set; } = null!;

    public string? TsOurReference { get; set; }

    public string? TsTheirReference { get; set; }

    public DateTime? TsDueDate { get; set; }

    public DateTime TsDate { get; set; }

    public decimal? TsDiscount { get; set; }

    public decimal TsTotalDiscount { get; set; }

    public decimal? TsTotalDiscountBc { get; set; }

    public decimal? TsTotalTax { get; set; }

    public decimal? TsTotalTaxBc { get; set; }

    public decimal TsTotal { get; set; }

    public decimal? TsTotalBc { get; set; }

    public string? TsRemarks { get; set; }

    public DateTime? TsCreateDate { get; set; }

    public DateTime? TsModifiedDate { get; set; }

    public decimal? TsCurRate { get; set; }

    public decimal? TsInvCurRate { get; set; }

    public int? TsUsIdCreatedby { get; set; }

    public int? TsPtId { get; set; }

    public string? TsAttribute01 { get; set; }

    public string? TsAttribute02 { get; set; }

    public string? TsAttribute03 { get; set; }

    public decimal? TsDiscountAmount { get; set; }

    public string? TsUid { get; set; }

    public decimal? TsTotalFinal { get; set; }

    public DateTime? TsExportedDate { get; set; }

    public virtual ICollection<CreditdebitnoteInvoice> CreditdebitnoteInvoices { get; set; } = new List<CreditdebitnoteInvoice>();

    public virtual ICollection<DueInvoice> DueInvoices { get; set; } = new List<DueInvoice>();

    public virtual ICollection<MovementLink> MovementLinks { get; set; } = new List<MovementLink>();

    public virtual ICollection<Operation> Operations { get; set; } = new List<Operation>();

    public virtual ICollection<RouteTransaction> RouteTransactions { get; set; } = new List<RouteTransaction>();

    public virtual ICollection<TransactionItemPromotion> TransactionItemPromotions { get; set; } = new List<TransactionItemPromotion>();

    public virtual ICollection<TransactionItem> TransactionItems { get; set; } = new List<TransactionItem>();

    public virtual ICollection<TransactionLink> TransactionLinkTslTs { get; set; } = new List<TransactionLink>();

    public virtual ICollection<TransactionLink> TransactionLinkTslTsIdLinkNavigations { get; set; } = new List<TransactionLink>();

    public virtual ICollection<TransactionReason> TransactionReasons { get; set; } = new List<TransactionReason>();

    public virtual ICollection<TransactionStatusHistory> TransactionStatusHistories { get; set; } = new List<TransactionStatusHistory>();

    public virtual ICollection<TransactionTax> TransactionTaxes { get; set; } = new List<TransactionTax>();

    public virtual BusinessUnit TsBu { get; set; } = null!;

    public virtual Codesc? TsCdIdCmsNavigation { get; set; }

    public virtual Codesc TsCdIdCurNavigation { get; set; } = null!;

    public virtual Codesc TsCdIdSrcNavigation { get; set; } = null!;

    public virtual SignatureDetail? TsSgd { get; set; }

    public virtual ThirdpartySite? TsThpsIdBillNavigation { get; set; }

    public virtual ThirdpartySite? TsThpsIdShipNavigation { get; set; }

    public virtual Transactionstatus? TsTss { get; set; }

    public virtual Transactiontype1 TsTst { get; set; } = null!;

    public virtual User? TsUs { get; set; }

    public virtual Visit? TsVt { get; set; }
}
