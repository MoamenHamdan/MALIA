using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class TransactionLink
{
    public int TslId { get; set; }

    public int? TslOrgId { get; set; }

    public int? TslTsId { get; set; }

    public int? TslTsIdLink { get; set; }

    public int? TslMvIdLink { get; set; }

    public virtual Transaction? TslTs { get; set; }

    public virtual Transaction? TslTsIdLinkNavigation { get; set; }
}
