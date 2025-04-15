using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ServiceTicketDetail
{
    public int SvtdId { get; set; }

    public int SvtdSvtId { get; set; }

    public string? SvtdDescription { get; set; }

    public int? SvtdCdIdSvtdcond { get; set; }

    public int? SvtdCdIdSvtdrs { get; set; }

    public string? SvtdComments { get; set; }

    public virtual Codesc? SvtdCdIdSvtdcondNavigation { get; set; }

    public virtual Codesc? SvtdCdIdSvtdrsNavigation { get; set; }

    public virtual ServiceTicket SvtdSvt { get; set; } = null!;
}
