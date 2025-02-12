using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class MenuPage
{
    public int MnpId { get; set; }

    public int? MnpMnId { get; set; }

    public string? MnpPagePath { get; set; }

    public short? MnpMaximized { get; set; }
}
