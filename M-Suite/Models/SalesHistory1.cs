using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class SalesHistory1
{
    public int ShId { get; set; }

    public int? ShCdIdCur { get; set; }

    public int? ShCuId { get; set; }

    public int? ShFeId { get; set; }

    public string? ShType { get; set; }

    public string ShInvoiceNo { get; set; } = null!;

    public DateTime ShDate { get; set; }

    public decimal ShSubtotal { get; set; }

    public decimal? ShDiscountCust { get; set; }

    public decimal ShDiscountLine { get; set; }

    public decimal? ShVat { get; set; }

    public decimal ShTotal { get; set; }

    public string? ShRemarks { get; set; }

    public string? ShCurSymb { get; set; }

    public string? ShSignFile { get; set; }

    public short? ShIsCreated { get; set; }

    public short ShVoided { get; set; }

    public string? ShSynched { get; set; }

    public int? ShCdIdWhs { get; set; }

    public int? ShShId { get; set; }

    public int? ShApproved { get; set; }

    public int? ShSmId { get; set; }

    public int ShYyyy { get; set; }

    public int ShYyyymm { get; set; }

    public int? ShBeId { get; set; }

    public int? ShPtId { get; set; }

    public int? ShWhId { get; set; }

    public int? ShCdIdPmd { get; set; }

    public int? ShCdIdPtm { get; set; }

    public DateTime? ShDateDlvdue { get; set; }

    public decimal? ShLinesDiscAmt { get; set; }

    public decimal? ShLinesDiscPerc { get; set; }

    public string? ShPaymentType { get; set; }

    public decimal? ShSalesDiscAmt { get; set; }

    public decimal? ShSalesDiscPerc { get; set; }
}
