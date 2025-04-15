using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ItemQuotaGroup
{
    public int IqgId { get; set; }

    public string? IqgCode { get; set; }

    public DateTime IqgFromDate { get; set; }

    public DateTime IqgToDate { get; set; }

    public string IqgDescription { get; set; } = null!;

    public short IqgActive { get; set; }

    public virtual ICollection<UserItemQuotaGroup> UserItemQuotaGroups { get; set; } = new List<UserItemQuotaGroup>();
}
