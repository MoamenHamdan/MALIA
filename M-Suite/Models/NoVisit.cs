using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class NoVisit
{
    public int NvId { get; set; }

    public int? NvVtId { get; set; }

    public int? NvCdIdNvr { get; set; }

    public DateTime? NvDate { get; set; }

    public string? NvComments { get; set; }

    public virtual Codesc? NvCdIdNvrNavigation { get; set; }

    public virtual Visit? NvVt { get; set; }
}
