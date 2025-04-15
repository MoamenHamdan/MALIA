using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class TransactionDeliveryItem
{
    public int TsdiId { get; set; }

    public int? TsdiOrgId { get; set; }

    public int? TsdiTsOrgId { get; set; }

    public int TsdiTsId { get; set; }

    public int? TsdiItId { get; set; }

    public int? TsdiUomId { get; set; }

    public int? TsdiTstoId { get; set; }

    public int? TsdiLpiId { get; set; }

    public int? TsdiTsdiId { get; set; }

    public int? TsdiPlIdWhs { get; set; }

    public short TsdiLineSequence { get; set; }

    public decimal TsdiQuantity { get; set; }

    public decimal TsdiQuantity2 { get; set; }

    public decimal? TsdiPrice { get; set; }

    public decimal? TsdiDiscountPercentage { get; set; }

    public decimal? TsdiDiscountAmount { get; set; }

    public string? TsdiRemarks { get; set; }

    public short? TsdiPriceChanged { get; set; }

    public decimal? TsdiTotalDiscount { get; set; }

    public decimal? TsdiTotalTax { get; set; }

    public decimal? TsdiTotalAmountBc { get; set; }

    public decimal? TsdiTotalDiscountBc { get; set; }

    public decimal? TsdiTotalTaxBc { get; set; }

    public int? TsdiCdIdRett { get; set; }

    public string? TsdiFreeComment { get; set; }

    public int? TsdiCdIdFrc { get; set; }

    public decimal? TsdiThpsDiscount { get; set; }

    public decimal? TsdiTotalAmount { get; set; }

    public virtual ICollection<TransactionDeliveryItem> InverseTsdiTsdi { get; set; } = new List<TransactionDeliveryItem>();

    public virtual Item? TsdiIt { get; set; }

    public virtual ListpriceItem? TsdiLpi { get; set; }

    public virtual PhysicalLocation? TsdiPlIdWhsNavigation { get; set; }

    public virtual TransactionDelivery TsdiTs { get; set; } = null!;

    public virtual TransactionDeliveryItem? TsdiTsdi { get; set; }

    public virtual TransactiontypeOption1? TsdiTsto { get; set; }

    public virtual Uom? TsdiUom { get; set; }
}
