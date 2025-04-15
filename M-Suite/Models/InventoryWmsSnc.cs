using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class InventoryWmsSnc
{
    public int SInId { get; set; }

    public int SInUsId { get; set; }

    public int? SInCdIdIns { get; set; }

    public string SInCode { get; set; } = null!;

    public DateTime SInDate { get; set; }

    public int? SInWhId { get; set; }

    public string? SInWhCode { get; set; }

    public string? SInDivisionCode { get; set; }

    public string? SInText1 { get; set; }

    public string? SInText2 { get; set; }

    public decimal? SInNum1 { get; set; }

    public decimal? SInNum2 { get; set; }

    public int? SInIsCreated { get; set; }

    public int SInUsIdSync { get; set; }

    public string SInVersion { get; set; } = null!;
}
