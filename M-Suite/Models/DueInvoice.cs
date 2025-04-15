using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class DueInvoice
{
    public int DiId { get; set; }

    public int? DiOrgId { get; set; }

    public int? DiBuId { get; set; }

    public int? DiCdIdCur { get; set; }

    public int? DiCdIdSrc { get; set; }

    public int? DiUsId { get; set; }

    public int? DiTsId { get; set; }

    public int? DiTsOrgId { get; set; }

    public int? DiThpsId { get; set; }

    public string? DiNumber { get; set; }

    public DateTime? DiDate { get; set; }

    public DateTime? DiDueDate { get; set; }

    public short? DiOrder { get; set; }

    public decimal? DiTotalAmount { get; set; }

    public decimal? DiRemainAmount { get; set; }

    public DateTime? DiCreateDate { get; set; }

    public DateTime? DiModifiedDate { get; set; }

    public short? DiVoid { get; set; }

    public string? DiDescription { get; set; }

    public int? DiErpSource { get; set; }

    public string? DiUid { get; set; }

    public string? DiErpSoNumber { get; set; }

    public string? DiText1 { get; set; }

    public string? DiText2 { get; set; }

    public string? DiText3 { get; set; }

    public string? DiRate { get; set; }

    public decimal? DiPrintAmount { get; set; }

    public string? DiAllowedDifference { get; set; }

    public string? DiDiUid { get; set; }

    public int? DiIsVat { get; set; }

    public decimal? DiUsdlbpVatRate { get; set; }

    public decimal? DiRemaingAmountBase { get; set; }

    public decimal? DiTotalAmountBase { get; set; }

    public string? DiVoucher { get; set; }

    public string? DiOrigCur { get; set; }

    public decimal? DiOrigAmtInCur { get; set; }

    public virtual ICollection<Creditdebitnote> Creditdebitnotes { get; set; } = new List<Creditdebitnote>();

    public virtual BusinessUnit? DiBu { get; set; }

    public virtual Codesc? DiCdIdCurNavigation { get; set; }

    public virtual Codesc? DiCdIdSrcNavigation { get; set; }

    public virtual ThirdpartySite? DiThps { get; set; }

    public virtual Transaction? DiTs { get; set; }

    public virtual User? DiUs { get; set; }

    public virtual ICollection<PaymentInvoice> PaymentInvoices { get; set; } = new List<PaymentInvoice>();
}
