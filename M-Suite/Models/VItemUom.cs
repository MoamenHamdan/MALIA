using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VItemUom
{
    public int ItuId { get; set; }

    public int ItuItId { get; set; }

    public int ItuUomId { get; set; }

    public decimal ItuConvValue { get; set; }

    public string? ItuShortname { get; set; }

    public string? ItuUomNameLan1 { get; set; }

    public string? ItuUomNameLan2 { get; set; }

    public string? ItuUomNameLan3 { get; set; }

    public string ItuFullName { get; set; } = null!;
}
