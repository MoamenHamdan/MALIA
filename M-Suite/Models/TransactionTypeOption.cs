using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class TransactionTypeOption
{
    public int TtoId { get; set; }

    public int? TtoTtId { get; set; }

    public string TtoCode { get; set; } = null!;

    public string TtoDescription { get; set; } = null!;

    public string TtoDescriptionAr { get; set; } = null!;

    public int? TtoAllowDiscountChange { get; set; }

    public int? TtoAllowFreeGood { get; set; }

    public int? TtoAllowOverstock { get; set; }

    public int? TtoApplyConstraints { get; set; }

    public int TtoCalculateTotalFactor { get; set; }

    public int TtoCheckStockAvailability { get; set; }

    public string? TtoColWidthDetail { get; set; }

    public string? TtoColWidthSearch { get; set; }

    public int TtoManageLotExprod { get; set; }

    public int TtoQuantityMultiplier { get; set; }

    public int? TtoSaleable { get; set; }

    public string? TtoUomColWidth { get; set; }

    public string? TtoUomSelectCode { get; set; }

    public int TtoUpdateStock { get; set; }

    public string? TtoText1 { get; set; }

    public string? TtoText2 { get; set; }

    public string? TtoText3 { get; set; }

    public DateTime? TtoDate1 { get; set; }

    public DateTime? TtoDate2 { get; set; }

    public decimal? TtoNum1 { get; set; }

    public decimal? TtoNum2 { get; set; }

    public decimal? TtoNum3 { get; set; }

    public decimal? TtoNum4 { get; set; }

    public decimal? TtoNum5 { get; set; }

    public decimal? TtoNum6 { get; set; }

    public decimal? TtoNum7 { get; set; }

    public decimal? TtoNum8 { get; set; }

    public decimal? TtoNum9 { get; set; }

    public virtual TransactionType? TtoTt { get; set; }
}
