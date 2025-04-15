using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ImpBankV
{
    public string IBkCode { get; set; } = null!;

    public string? IBkDescription { get; set; }

    public int? IcdId { get; set; }

    public int IcdFcId { get; set; }

    public string IcdFcCode { get; set; } = null!;
}
