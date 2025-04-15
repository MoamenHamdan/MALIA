using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ItemcategoryTypeV
{
    public int Id { get; set; }

    public int? Parent { get; set; }

    public string? Description { get; set; }

    public int? HasChild { get; set; }
}
