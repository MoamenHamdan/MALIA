using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class TransactionItemBackup
{
    public int TsiId { get; set; }

    public int? TsiOrgId { get; set; }

    public int? TsiTsOrgId { get; set; }

    public int TsiTsId { get; set; }

    public int? TsiItId { get; set; }

    public int? TsiUomId { get; set; }

    public int? TsiTstoId { get; set; }

    public int? TsiLpiId { get; set; }

    public int? TsiTsiId { get; set; }

    public int? TsiPlIdWhs { get; set; }

    public short TsiLineSequence { get; set; }

    public decimal TsiQuantity { get; set; }

    public decimal TsiQuantity2 { get; set; }

    public decimal? TsiPrice { get; set; }

    public decimal? TsiDiscountPercentage { get; set; }

    public decimal? TsiDiscountAmount { get; set; }

    public string? TsiRemarks { get; set; }

    public short? TsiPriceChanged { get; set; }

    public decimal? TsiTotalDiscount { get; set; }

    public decimal? TsiTotalTax { get; set; }

    public decimal? TsiTotalAmountBc { get; set; }

    public decimal? TsiTotalDiscountBc { get; set; }

    public decimal? TsiTotalTaxBc { get; set; }

    public int? TsiCdIdRett { get; set; }

    public string? TsiFreeComment { get; set; }

    public int? TsiCdIdFrc { get; set; }

    public decimal? TsiThpsDiscount { get; set; }

    public decimal? TsiTotalAmount { get; set; }
}
