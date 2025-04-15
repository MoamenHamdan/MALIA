using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class UserItemQuotum
{
    public int UiqId { get; set; }

    public int UiqUsId { get; set; }

    public DateTime UiqFromDate { get; set; }

    public DateTime UiqToDate { get; set; }

    public string UiqDescription { get; set; } = null!;

    public short? UiqActive { get; set; }

    public virtual User UiqUs { get; set; } = null!;

    public virtual ICollection<UserItemQuotaDetail> UserItemQuotaDetails { get; set; } = new List<UserItemQuotaDetail>();
}
