using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class RebuildIndexesV
{
    public string TableName { get; set; } = null!;

    public int Ord { get; set; }

    public string? Cmd { get; set; }

    public string? TableSchema { get; set; }

    public string? TableCatalog { get; set; }

    public string? TableType { get; set; }
}
