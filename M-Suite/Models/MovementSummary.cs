using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class MovementSummary
{
    public DateOnly? MvDate { get; set; }

    public string ItCode { get; set; } = null!;

    public int MvId { get; set; }

    public string ItDescriptionLan1 { get; set; } = null!;

    public string? ItDescriptionLan2 { get; set; }

    public string? ItDescriptionLan3 { get; set; }

    public string FPlDescriptionLan1 { get; set; } = null!;

    public string TPlDescriptionLan1 { get; set; } = null!;

    public string? FPlDescriptionLan2 { get; set; }

    public string? TPlDescriptionLan2 { get; set; }

    public string? FPlDescriptionLan3 { get; set; }

    public string? TPlDescriptionLan3 { get; set; }

    public int FPlId { get; set; }

    public int TPlId { get; set; }

    public int ItId { get; set; }

    public decimal? TotalQty { get; set; }

    public string? MvtCode { get; set; }

    public int MvtId { get; set; }

    public int MvBuId { get; set; }

    public int? MvMssId { get; set; }

    public int UomId { get; set; }

    public string? UomNameLan1 { get; set; }

    public string? UomNameLan2 { get; set; }

    public string? UomNameLan3 { get; set; }

    public string MssDescriptionLan1 { get; set; } = null!;

    public string MssDescriptionLan2 { get; set; } = null!;

    public string MssDescriptionLan3 { get; set; } = null!;
}
