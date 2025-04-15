using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class UserpaymentstatusTransition
{
    public int UpstId { get; set; }

    public int UpstUpsIdFrom { get; set; }

    public int UpstUpsIdTo { get; set; }

    public int UpstUptId { get; set; }

    public short UpstUplVsUpdAmount { get; set; }

    public string? UpstExtraCode { get; set; }

    public virtual Userpaymentstatus UpstUpsIdFromNavigation { get; set; } = null!;

    public virtual Userpaymentstatus UpstUpsIdToNavigation { get; set; } = null!;

    public virtual Userpaymenttype UpstUpt { get; set; } = null!;

    public virtual ICollection<UserpaymentstatusTransitionProfile> UserpaymentstatusTransitionProfiles { get; set; } = new List<UserpaymentstatusTransitionProfile>();
}
