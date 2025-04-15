using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VGenericSearch
{
    public long? ViewgsId { get; set; }

    public string ViewgsThetable { get; set; } = null!;

    public string? ViewgsName { get; set; }

    public string? ViewgsLink { get; set; }

    public int ViewgsMaintableid { get; set; }

    public string ViewgsMaintablelink { get; set; } = null!;
}
