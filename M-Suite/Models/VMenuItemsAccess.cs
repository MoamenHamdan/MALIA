using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VMenuItemsAccess
{
    public int MiaId { get; set; }

    public int MiaCodescId { get; set; }

    public string MiaCode { get; set; } = null!;

    public string? MiaDescription { get; set; }

    public int? MiaMnId { get; set; }

    public string? MiaMenuDescription { get; set; }
}
