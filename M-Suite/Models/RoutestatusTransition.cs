using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class RoutestatusTransition
{
    public int RtstId { get; set; }

    public int RtstRtsIdFrom { get; set; }

    public int RtstRtsIdTo { get; set; }

    public string? RtstExtraCode { get; set; }

    public short? RtstExportData { get; set; }

    public virtual Routestatus RtstRtsIdFromNavigation { get; set; } = null!;

    public virtual Routestatus RtstRtsIdToNavigation { get; set; } = null!;
}
