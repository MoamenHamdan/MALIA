using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ApiSession
{
    public int ApsId { get; set; }

    public int? ApsUsId { get; set; }

    public string ApsKey { get; set; } = null!;

    public string ApsToken { get; set; } = null!;

    public DateTime ApsDateCreate { get; set; }

    public DateTime ApsLastActionDate { get; set; }

    public int ApsStatus { get; set; }

    public int ApsValidityMinutes { get; set; }

    public virtual User? ApsUs { get; set; }
}
