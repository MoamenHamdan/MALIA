using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class QueryDesign
{
    public int QdId { get; set; }

    public string? QdDbObjectName { get; set; }

    public string? QdAttribute { get; set; }

    public virtual ICollection<QueryDesignDetail> QueryDesignDetails { get; set; } = new List<QueryDesignDetail>();
}
