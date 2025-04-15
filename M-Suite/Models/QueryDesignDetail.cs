using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class QueryDesignDetail
{
    public int QddId { get; set; }

    public int QddQdId { get; set; }

    public string QddColumnName { get; set; } = null!;

    public string? QddColumnAlign { get; set; }

    public string? QddColumnWidth { get; set; }

    public string? QddColumnAlias { get; set; }

    public string? QddColumnFormat { get; set; }

    public short? QddIsPrimaryKey { get; set; }

    public string? QddAttribute { get; set; }

    public short? QddColumnOrder { get; set; }

    public short? QddWrapText { get; set; }

    public short? QddSortOrder { get; set; }

    public virtual QueryDesign QddQd { get; set; } = null!;
}
