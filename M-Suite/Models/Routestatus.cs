using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class Routestatus
{
    public int RtsId { get; set; }

    public string RtsCode { get; set; } = null!;

    public string RtsDescriptionLan1 { get; set; } = null!;

    public string? RtsDescriptionLan2 { get; set; }

    public string? RtsDescriptionLan3 { get; set; }

    public string RtsLabelCode { get; set; } = null!;

    public string? RtsStyle { get; set; }

    public string? RtsConfirmationCode { get; set; }

    public int RtsOrder { get; set; }

    public virtual ICollection<Route> Routes { get; set; } = new List<Route>();

    public virtual ICollection<RoutestatusTransition> RoutestatusTransitionRtstRtsIdFromNavigations { get; set; } = new List<RoutestatusTransition>();

    public virtual ICollection<RoutestatusTransition> RoutestatusTransitionRtstRtsIdToNavigations { get; set; } = new List<RoutestatusTransition>();
}
