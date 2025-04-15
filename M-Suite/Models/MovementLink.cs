using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class MovementLink
{
    public int MvlId { get; set; }

    public int? MvlOrgId { get; set; }

    public int? MvlMvId { get; set; }

    public int? MvlMvIdLink { get; set; }

    public int? MvlTsIdLink { get; set; }

    public virtual Movement? MvlMv { get; set; }

    public virtual Movement? MvlMvIdLinkNavigation { get; set; }

    public virtual Transaction? MvlTsIdLinkNavigation { get; set; }
}
