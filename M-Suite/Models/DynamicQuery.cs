using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class DynamicQuery
{
    public int DqId { get; set; }

    public int? DqMdId { get; set; }

    public int? DqDqId { get; set; }

    public int DqCdIdDqt { get; set; }

    public string DqCode { get; set; } = null!;

    public string? DqDescription { get; set; }

    public string DqQuery { get; set; } = null!;

    public short? DqOrder { get; set; }

    public virtual Codesc DqCdIdDqtNavigation { get; set; } = null!;

    public virtual Module? DqMd { get; set; }
}
