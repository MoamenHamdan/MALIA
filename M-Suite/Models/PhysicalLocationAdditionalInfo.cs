using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class PhysicalLocationAdditionalInfo
{
    public int PliId { get; set; }

    public int? PliPlId { get; set; }

    public string? PliNumber { get; set; }

    public string? PliAddress1 { get; set; }

    public string? PliAddress2 { get; set; }

    public string? PliAddress3 { get; set; }

    public string? PliPhone { get; set; }

    public string? PliMobile { get; set; }

    public string? PliFax { get; set; }

    public string? PliLatitude { get; set; }

    public string? PliLongitude { get; set; }

    public decimal? PliWidth { get; set; }

    public decimal? PliHeight { get; set; }

    public decimal? PliDepth { get; set; }

    public decimal? PliArea { get; set; }

    public decimal? PliVolume { get; set; }

    public int? PliGlId { get; set; }

    public decimal? PliWeight { get; set; }

    public virtual PhysicalLocation? PliPl { get; set; }
}
