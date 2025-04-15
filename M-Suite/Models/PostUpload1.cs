using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class PostUpload1
{
    public int PuId { get; set; }

    public string PuCode { get; set; } = null!;

    public int? PuOrder { get; set; }

    public string PuTableName { get; set; } = null!;

    public string PuSelect { get; set; } = null!;

    public string PuUpdate { get; set; } = null!;

    public string? PuCategory { get; set; }

    public string? PuAdditionalWhere { get; set; }

    public string? PuPrefix { get; set; }

    public int? PuBuId { get; set; }

    public virtual BusinessUnit? PuBu { get; set; }
}
