using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class RouteTaskSnc
{
    public int SRtaId { get; set; }

    public int? SRtaRtId { get; set; }

    public int? SRtaVtId { get; set; }

    public int? SRtaOrder { get; set; }

    public string SRtaTasks { get; set; } = null!;

    public int? SRtaThpsId { get; set; }

    public short SRtaCompleted { get; set; }

    public DateTime? SRtaDate { get; set; }

    public DateTime? SRtaCompeletedDate { get; set; }

    public int? SRtaUsCreatedBy { get; set; }

    public int? SRtaUsCompletedBy { get; set; }

    public string? SRtaComments { get; set; }

    public int SRtaSmId { get; set; }

    public string SRtaVersion { get; set; } = null!;

    public short? SRtaSynched { get; set; }
}
