using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class Task
{
    public int TkId { get; set; }

    public int? TkBuId { get; set; }

    public int? TkCdIdMod { get; set; }

    public short? TkOrder { get; set; }

    public string TkSubject { get; set; } = null!;

    public string TkDescription { get; set; } = null!;

    public DateTime? TkDate { get; set; }

    public DateTime? TkDueDate { get; set; }

    public short? TkApplyToAll { get; set; }

    public DateTime TkCreateDate { get; set; }

    public string? TkCdIdPri { get; set; }

    public short? TkActive { get; set; }

    public int? TkUsIdCr { get; set; }

    public virtual ICollection<TaskDetail> TaskDetails { get; set; } = new List<TaskDetail>();

    public virtual BusinessUnit? TkBu { get; set; }

    public virtual Codesc? TkCdIdModNavigation { get; set; }
}
