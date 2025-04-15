using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class SalesHistory
{
    public int Pk { get; set; }

    public int ShId { get; set; }

    public int ShCdIdCur { get; set; }

    public int? ShCuId { get; set; }

    public int ShFeId { get; set; }

    public string ShType { get; set; } = null!;

    public string ShInvoiceNo { get; set; } = null!;

    public string? ShDate { get; set; }

    public string? ShSubtotal { get; set; }

    public decimal? ShDiscountCust { get; set; }

    public decimal ShDiscountLine { get; set; }

    public decimal? ShVat { get; set; }

    public string? ShTotal { get; set; }

    public string? ShRemarks { get; set; }

    public string ShCurSymb { get; set; } = null!;

    public string ShSignFile { get; set; } = null!;

    public int ShIsCreated { get; set; }

    public int ShVoided { get; set; }

    public int ShSynched { get; set; }

    public int ShCdIdWhs { get; set; }

    public int ShShId { get; set; }

    public int ShApproved { get; set; }

    public int? ShSmId { get; set; }

    public string ShYyyy { get; set; } = null!;

    public string ShYyyymm { get; set; } = null!;

    public int ShBeId { get; set; }

    public int ShPtId { get; set; }

    public int ShWhId { get; set; }

    public int ShCdIdPmd { get; set; }

    public int ShCdIdPtm { get; set; }

    public DateTime? ShDateDlvdue { get; set; }

    public int ShLinesDiscAmt { get; set; }

    public int ShLinesDiscPerc { get; set; }

    public string ShPaymentType { get; set; } = null!;

    public int ShSalesDiscAmt { get; set; }

    public int ShSalesDiscPerc { get; set; }

    public DateTime ShDatess { get; set; }
}
