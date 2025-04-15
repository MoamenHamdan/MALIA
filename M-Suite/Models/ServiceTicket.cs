using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ServiceTicket
{
    public int SvtId { get; set; }

    public string SvtCode { get; set; } = null!;

    public string? SvtDescription { get; set; }

    public int SvtVtId { get; set; }

    public int? SvtItId { get; set; }

    public string? SvtSerialNo { get; set; }

    public string? SvtCauseOfIssue { get; set; }

    public string? SvtResolution { get; set; }

    public string? SvtComments { get; set; }

    public int? SvtUsId { get; set; }

    public string? SvtDeliveredTo { get; set; }

    public int? SvtCdIdStsts { get; set; }

    public int? SvtCdIdStpr { get; set; }

    public int? SvtCdIdStt { get; set; }

    public int? SvtCdIdStcoi { get; set; }

    public string? SvtUid { get; set; }

    public DateTime? SvtCreationDate { get; set; }

    public DateTime? SvtExpiryDate { get; set; }

    public virtual ICollection<ServiceTicketDetail> ServiceTicketDetails { get; set; } = new List<ServiceTicketDetail>();

    public virtual ICollection<ServiceTicketStatusHistory> ServiceTicketStatusHistories { get; set; } = new List<ServiceTicketStatusHistory>();

    public virtual Codesc? SvtCdIdStcoiNavigation { get; set; }

    public virtual Codesc? SvtCdIdStprNavigation { get; set; }

    public virtual Codesc? SvtCdIdStstsNavigation { get; set; }

    public virtual Codesc? SvtCdIdSttNavigation { get; set; }

    public virtual Item? SvtIt { get; set; }

    public virtual User? SvtUs { get; set; }

    public virtual Visit SvtVt { get; set; } = null!;
}
