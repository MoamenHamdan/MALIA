using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ImpCurrencyV
{
    public string ICrCode { get; set; } = null!;

    public string? ICrDescription { get; set; }

    public string? ICrSymb { get; set; }

    public int? IcdId { get; set; }

    public int IcdFcId { get; set; }

    public string IcdFcCode { get; set; } = null!;
}
