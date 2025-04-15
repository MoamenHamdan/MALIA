using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class SalesWrk
{
    public int SoId { get; set; }

    public int? SoSmId { get; set; }

    public int? SoVtId { get; set; }

    public int? SoCdIdCur { get; set; }

    public int? SoCuId { get; set; }

    public int? SoFeId { get; set; }

    public int? SoCdIdWhs { get; set; }

    public int? SoSoId { get; set; }

    public int? SoCuIdShp { get; set; }

    public int? SoCdIdPtm { get; set; }

    public int? SoTtId { get; set; }

    public int? SoPtId { get; set; }

    public int? SoCdIdPmd { get; set; }

    public string? SoPaymentType { get; set; }

    public string? SoType { get; set; }

    public string? SoInvoiceNo { get; set; }

    public DateTime? SoDate { get; set; }

    public decimal? SoSubtotal { get; set; }

    public decimal? SoDiscountCust { get; set; }

    public decimal? SoDiscountLine { get; set; }

    public decimal? SoVat { get; set; }

    public decimal? SoTotal { get; set; }

    public string? SoRemarks { get; set; }

    public string? SoCurSymb { get; set; }

    public string? SoSignFile { get; set; }

    public decimal? SoLinesDiscPerc { get; set; }

    public decimal? SoLinesDiscAmt { get; set; }

    public decimal? SoSalesDiscPerc { get; set; }

    public decimal? SoSalesDiscAmt { get; set; }

    public int? SoIsCreated { get; set; }

    public int? SoVoided { get; set; }

    public string? SoSynched { get; set; }

    public DateTime? SoDateDlvdue { get; set; }

    public string? SoVersion { get; set; }
}
