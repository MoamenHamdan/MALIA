using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class SearchCriterion
{
    public int ScId { get; set; }

    public string ScScreenCode { get; set; } = null!;

    public short ScOrder { get; set; }

    public string ScDescription { get; set; } = null!;

    public string ScColumn { get; set; } = null!;

    public string ScColumnType { get; set; } = null!;

    public string ScCriteriaType { get; set; } = null!;

    public string? ScJoinTable { get; set; }

    public string? ScJoinClause { get; set; }

    public short ScIsDefault { get; set; }

    public string? ScSelect { get; set; }

    public string ScDescriptionAr { get; set; } = null!;

    public int? ScBeId { get; set; }

    public string? ScTag { get; set; }
}
