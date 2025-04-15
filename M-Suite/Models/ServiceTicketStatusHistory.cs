using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ServiceTicketStatusHistory
{
    public int SvtshId { get; set; }

    public int SvtshSvtId { get; set; }

    public int SvtshCdIdStsts { get; set; }

    public int SvtshUsId { get; set; }

    public DateTime SvtshCreationDate { get; set; }

    public virtual Codesc SvtshCdIdStstsNavigation { get; set; } = null!;

    public virtual ServiceTicket SvtshSvt { get; set; } = null!;
}
