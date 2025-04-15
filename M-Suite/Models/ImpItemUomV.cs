using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ImpItemUomV
{
    public int IItuItId { get; set; }

    public int IItuUomId { get; set; }

    public int? IItuConvValue { get; set; }

    public string? IItuShortname { get; set; }

    public int IItuActive { get; set; }
}
