using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class OperationItem
{
    public int OpiId { get; set; }

    public int? OpiOrgId { get; set; }

    public int? OpiOpOrgId { get; set; }

    public int OpiOpId { get; set; }

    public int? OpiItId { get; set; }

    public int? OpiUomId { get; set; }

    public int? OpiOptoId { get; set; }

    public int? OpiLpId { get; set; }

    public int? OpiOpiId { get; set; }

    public int? OpiPlIdWhs { get; set; }

    public short OpiLineSequence { get; set; }

    public decimal OpiQuantity { get; set; }

    public decimal OpiPicked { get; set; }

    public decimal? OpiPrice { get; set; }

    public decimal? OpiCostPrice { get; set; }

    public decimal? OpiDiscountPercentage { get; set; }

    public decimal? OpiDiscountAmount { get; set; }

    public string? OpiRemarks { get; set; }

    public short? OpiPriceChanged { get; set; }

    public decimal? OpiTotalDiscount { get; set; }

    public decimal? OpiTotalTax { get; set; }

    public decimal? OpiTotalAmountBc { get; set; }

    public decimal? OpiTotalDiscountBc { get; set; }

    public decimal? OpiTotalTaxBc { get; set; }

    public int? OpiCdIdRett { get; set; }

    public decimal? OpiTotalAmount { get; set; }

    public int? OpiPlIdLoc { get; set; }

    public virtual ICollection<OperationItem> InverseOpiOpi { get; set; } = new List<OperationItem>();

    public virtual ICollection<OperationBatchItem> OperationBatchItems { get; set; } = new List<OperationBatchItem>();

    public virtual ICollection<OperationItemDetail> OperationItemDetails { get; set; } = new List<OperationItemDetail>();

    public virtual Item? OpiIt { get; set; }

    public virtual Listprice? OpiLp { get; set; }

    public virtual Operation OpiOp { get; set; } = null!;

    public virtual OperationItem? OpiOpi { get; set; }

    public virtual OperationtypeOption? OpiOpto { get; set; }

    public virtual PhysicalLocation? OpiPlIdLocNavigation { get; set; }

    public virtual PhysicalLocation? OpiPlIdWhsNavigation { get; set; }

    public virtual Uom? OpiUom { get; set; }
}
