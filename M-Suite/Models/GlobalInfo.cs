using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class GlobalInfo
{
    public int GlId { get; set; }

    public int? GlSmId { get; set; }

    public int? GlPrId { get; set; }

    public int? GlCuId { get; set; }

    public int? GlDtId { get; set; }

    public string? GlCode { get; set; }

    public string? GlValue { get; set; }

    public string? GlDescription { get; set; }

    public string? GlType { get; set; }

    public string? GlFamily { get; set; }

    public int? GlItuId { get; set; }
}
