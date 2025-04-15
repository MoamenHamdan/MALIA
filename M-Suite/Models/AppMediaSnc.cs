using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class AppMediaSnc
{
    public int SMedId { get; set; }

    public int? SMedOrgId { get; set; }

    public string SMedName { get; set; } = null!;

    public string SMedRef { get; set; } = null!;

    public string SMedType { get; set; } = null!;

    public int SMedUsId { get; set; }

    public DateTime SMedDatetime { get; set; }

    public string? SMedLatitude { get; set; }

    public string? SMedLongitude { get; set; }

    public int SMedFkValue { get; set; }

    public string? SMedDevicePath { get; set; }

    public string? SMedServerPath { get; set; }

    public int? SMedOrder { get; set; }

    public short? SMedActive { get; set; }

    public string? SMedText1 { get; set; }

    public string? SMedText2 { get; set; }

    public decimal? SMedNum1 { get; set; }

    public decimal? SMedNum2 { get; set; }

    public string SMedVersion { get; set; } = null!;

    public string? SMedFkValueUid { get; set; }
}
