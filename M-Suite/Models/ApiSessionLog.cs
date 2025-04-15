using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ApiSessionLog
{
    public int AslId { get; set; }

    public int? AslUsId { get; set; }

    public string AslKey { get; set; } = null!;

    public string AslToken { get; set; } = null!;

    public int AslValidated { get; set; }

    public DateTime AslDate { get; set; }
}
