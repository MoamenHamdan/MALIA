using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class TblItemcategoryCommonTree
{
    public int? NodeId { get; set; }

    public int? NodeParentId { get; set; }

    public string? NodeDescription { get; set; }

    public int? NodeHasChild { get; set; }

    public string? NodeHierarchy { get; set; }

    public string? TreeType { get; set; }
}
