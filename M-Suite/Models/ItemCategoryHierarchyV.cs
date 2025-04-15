using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ItemCategoryHierarchyV
{
    public int? CtgId { get; set; }

    public int? CtgCtgId { get; set; }

    public string? CtgHierarchy { get; set; }

    public int? CtgLevel { get; set; }
}
