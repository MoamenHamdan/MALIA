using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class MovementItem
{
    public int MviId { get; set; }

    public int? MviOrgId { get; set; }

    public int? MviMvOrgId { get; set; }

    public int MviMvId { get; set; }

    public int? MviLpId { get; set; }

    public int? MviItId { get; set; }

    public int? MviMviId { get; set; }

    public int? MviMvtoId { get; set; }

    public int? MviUomId { get; set; }

    public short MviLineSequence { get; set; }

    public decimal MviQuantity { get; set; }

    public decimal? MviQuantity2 { get; set; }

    public decimal? MviPrice { get; set; }

    public decimal? MviDiscountPercentage { get; set; }

    public decimal? MviDiscountAmount { get; set; }

    public string? MviRemarks { get; set; }

    public short? MviPriceChanged { get; set; }

    public int? MviPnId { get; set; }

    public decimal? MviTotalAmount { get; set; }

    public decimal? MviTotalDiscount { get; set; }

    public decimal? MviTotalTax { get; set; }

    public decimal? MviTotalAmountBc { get; set; }

    public decimal? MviTotalDiscountBc { get; set; }

    public decimal? MviTotalTaxBc { get; set; }

    public int? MviPlIdWhs { get; set; }

    public int? MviCdIdRct { get; set; }

    public virtual ICollection<MovementItem> InverseMviMvi { get; set; } = new List<MovementItem>();

    public virtual ICollection<MovementItemDetail> MovementItemDetails { get; set; } = new List<MovementItemDetail>();

    public virtual ICollection<MovementItemHistory> MovementItemHistories { get; set; } = new List<MovementItemHistory>();

    public virtual Item? MviIt { get; set; }

    public virtual Listprice? MviLp { get; set; }

    public virtual Movement MviMv { get; set; } = null!;

    public virtual MovementItem? MviMvi { get; set; }

    public virtual MovementtypeOption? MviMvto { get; set; }

    public virtual Uom? MviUom { get; set; }
}
