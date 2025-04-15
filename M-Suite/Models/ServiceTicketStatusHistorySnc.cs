using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ServiceTicketStatusHistorySnc
{
    public int SSvtshId { get; set; }

    public int SSvtshSvtId { get; set; }

    public int SSvtshCdIdStsts { get; set; }

    public int SSvtshUsId { get; set; }

    public DateTime SSvtshCreationDate { get; set; }

    public string SSvtshVersion { get; set; } = null!;

    public int SSvtshSmId { get; set; }
}
