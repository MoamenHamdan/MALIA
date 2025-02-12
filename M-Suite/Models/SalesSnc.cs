using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class SalesSnc
{
    public int SSoId { get; set; }

    public int? SSoVtId { get; set; }

    public int? SSoCdIdCur { get; set; }

    public int? SSoCuId { get; set; }

    public int? SSoFeId { get; set; }

    public int? SSoSoId { get; set; }

    public string? SSoType { get; set; }

    public string SSoInvoiceNo { get; set; } = null!;

    public DateTime SSoDate { get; set; }

    public string? SSoSubtotal { get; set; }

    public decimal? SSoDiscountCust { get; set; }

    public decimal? SSoDiscountLine { get; set; }

    public decimal? SSoVat { get; set; }

    public string? SSoTotal { get; set; }

    public string? SSoRemarks { get; set; }

    public string? SSoCurSymb { get; set; }

    public string? SSoSignFile { get; set; }

    public short? SSoIsCreated { get; set; }

    public short SSoVoided { get; set; }

    public string? SSoSynched { get; set; }

    public string SSoVersion { get; set; } = null!;

    public int SSoSmId { get; set; }

    public int? SSoCdIdWhs { get; set; }

    public int? SSoYyyy { get; set; }

    public int? SSoYyyymm { get; set; }

    public int? SSoCdIdPmd { get; set; }

    public int? SSoCdIdPtm { get; set; }

    public DateTime? SSoDateDlvdue { get; set; }

    public decimal? SSoLinesDiscAmt { get; set; }

    public decimal? SSoLinesDiscPerc { get; set; }

    public string? SSoPaymentType { get; set; }

    public int? SSoPtId { get; set; }

    public decimal? SSoSalesDiscAmt { get; set; }

    public decimal? SSoSalesDiscPerc { get; set; }

    public string? SSoDeliveryDate { get; set; }

    public decimal? SSoDiscountAmountLine { get; set; }

    public string? SSoVtUid { get; set; }

    public string? SSoUid { get; set; }

    public int? SSoCdIdSpc { get; set; }
}
