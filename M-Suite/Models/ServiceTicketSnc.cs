using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ServiceTicketSnc
{
    public int SSvtId { get; set; }

    public string SSvtCode { get; set; } = null!;

    public string? SSvtDescription { get; set; }

    public int SSvtVtId { get; set; }

    public int? SSvtItId { get; set; }

    public string? SSvtSerialNo { get; set; }

    public string? SSvtCauseOfIssue { get; set; }

    public string? SSvtResolution { get; set; }

    public string? SSvtComments { get; set; }

    public int? SSvtUsId { get; set; }

    public string? SSvtDeliveredTo { get; set; }

    public int? SSvtCdIdStsts { get; set; }

    public int? SSvtCdIdStpr { get; set; }

    public int? SSvtCdIdStt { get; set; }

    public int? SSvtCdIdStcoi { get; set; }

    public string? SSvtUid { get; set; }

    public DateTime? SSvtCreationDate { get; set; }

    public DateTime? SSvtExpiryDate { get; set; }

    public string SSvtVersion { get; set; } = null!;

    public int SSvtSmId { get; set; }
}
