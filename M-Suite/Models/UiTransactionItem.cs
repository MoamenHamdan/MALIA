using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class UiTransactionItem
{
    public int UtsiId { get; set; }

    public int UtsiTstId { get; set; }

    public int UtsiTssId { get; set; }

    public short? UtsiTsiId { get; set; }

    public short? UtsiTsiOrgId { get; set; }

    public short? UtsiTsiTsOrgId { get; set; }

    public short? UtsiTsiTsId { get; set; }

    public short? UtsiTsiItId { get; set; }

    public short? UtsiTsiUomId { get; set; }

    public short? UtsiTsiTstoId { get; set; }

    public short? UtsiTsiTsiId { get; set; }

    public short? UtsiTsiLpiId { get; set; }

    public short? UtsiTsiPlIdWhs { get; set; }

    public short? UtsiTsiLineSequence { get; set; }

    public short? UtsiTsiQuantity { get; set; }

    public short? UtsiTsiQuantity2 { get; set; }

    public short? UtsiTsiPrice { get; set; }

    public short? UtsiTsiDiscountPercentage { get; set; }

    public short? UtsiTsiDiscountAmount { get; set; }

    public short? UtsiTsiRemarks { get; set; }

    public short? UtsiTsiPriceChanged { get; set; }

    public short? UtsiTsiTotalAmount { get; set; }

    public short? UtsiTsiTotalDiscount { get; set; }

    public short? UtsiTsiTotalTax { get; set; }

    public short? UtsiTsiTotalAmountBc { get; set; }

    public short? UtsiTsiTotalDiscountBc { get; set; }

    public short? UtsiTsiTotalTaxBc { get; set; }

    public virtual Transactionstatus UtsiTss { get; set; } = null!;

    public virtual Transactiontype1 UtsiTst { get; set; } = null!;
}
