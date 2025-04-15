using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VApiSession
{
    public int? ApsId { get; set; }

    public int ApsUsId { get; set; }

    public string ApsUsCode { get; set; } = null!;

    public string ApsUsShortName { get; set; } = null!;

    public string ApsKey { get; set; } = null!;

    public string ApsToken { get; set; } = null!;

    public DateTime ApsDateCreate { get; set; }

    public DateTime ApsLastActionDate { get; set; }

    public string ApsStatusDescription { get; set; } = null!;

    public int ApsStatus { get; set; }

    public int ApsValidityMinutes { get; set; }

    public DateTime? ApsExpiryDate { get; set; }
}
