using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ServiceTicketDetailSnc
{
    public int SSvtdId { get; set; }

    public int SSvtdSvtId { get; set; }

    public string? SSvtdDescription { get; set; }

    public int? SSvtdCdIdSvtdcond { get; set; }

    public int? SSvtdCdIdSvtdrs { get; set; }

    public string? SSvtdComments { get; set; }

    public string SSvtdVersion { get; set; } = null!;

    public int SSvtdSmId { get; set; }
}
