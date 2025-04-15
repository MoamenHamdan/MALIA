using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VQlkDueInvoice
{
    public int DiId { get; set; }

    public int? BuId { get; set; }

    public int? DiUsId { get; set; }

    public int? TsId { get; set; }

    public int? DiThpsId { get; set; }

    public string? DiNumber { get; set; }

    public DateTime? DiDate { get; set; }

    public DateTime? DiDueDate { get; set; }

    public short? DiOrder { get; set; }

    public decimal? DiTotalAmount { get; set; }

    public decimal? DiTotalAmountBc { get; set; }

    public decimal? DiRemainAmount { get; set; }

    public decimal? DiRemainAmountBc { get; set; }

    public DateTime? DiCreateDate { get; set; }

    public DateTime? DiModifiedDate { get; set; }

    public short? DiVoid { get; set; }

    public string DiCurCode { get; set; } = null!;

    public string? DiCurDescriptionLan1 { get; set; }

    public string? DiCurDescriptionLan2 { get; set; }

    public string? DiCurDescriptionLan3 { get; set; }

    public int? DiYear { get; set; }

    public int? DiMonth { get; set; }

    public int? DiDay { get; set; }

    public int? DiDueYear { get; set; }

    public int? DiDueMonth { get; set; }

    public int? DiDueDay { get; set; }

    public int DiDueRange { get; set; }

    public int? DiDueDateNum { get; set; }

    public int? DiDateNum { get; set; }

    public int? DiDateDueDateDiff { get; set; }

    public string? ThpsBu { get; set; }
}
