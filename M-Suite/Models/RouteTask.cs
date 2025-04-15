using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class RouteTask
{
    public int RtaId { get; set; }

    public int? RtaRtId { get; set; }

    public int? RtaOrder { get; set; }

    public string? RtaTasks { get; set; }

    public int? RtaThpsId { get; set; }

    public short? RtaCompleted { get; set; }

    public DateTime? RtaDate { get; set; }

    public DateTime? RtaCompeletedDate { get; set; }

    public int? RtaUsCreatedBy { get; set; }

    public int? RtaUsCompletedBy { get; set; }

    public string? RtaComments { get; set; }

    public virtual Route? RtaRt { get; set; }

    public virtual ThirdpartySite? RtaThps { get; set; }
}
