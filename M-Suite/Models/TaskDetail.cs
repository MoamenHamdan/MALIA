using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class TaskDetail
{
    public int TkdId { get; set; }

    public int TkdTkId { get; set; }

    public int TkdUsId { get; set; }

    public short? TkdCompleted { get; set; }

    public DateTime? TkdCompletedDate { get; set; }

    public short? TkdRead { get; set; }

    public DateTime? TkdReadDate { get; set; }

    public virtual Task TkdTk { get; set; } = null!;

    public virtual User TkdUs { get; set; } = null!;
}
