using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class UserSequenceWmsSnc
{
    public int SUqId { get; set; }

    public int? SUqUsId { get; set; }

    public string SUqType { get; set; } = null!;

    public string SUqFromCode { get; set; } = null!;

    public string? SUqToCode { get; set; }

    public int? SUqIsModified { get; set; }

    public string? SUqPrefix { get; set; }

    public short SUqTotalLength { get; set; }

    public int SUqUsIdSync { get; set; }

    public string SUqVersion { get; set; } = null!;
}
