using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ReportRequest
{
    public int RprId { get; set; }

    public int? RprRpId { get; set; }

    public int? RprUsId { get; set; }

    public int? RprCdIdRrs { get; set; }

    public DateTime? RprRequestDate { get; set; }

    public DateTime? RprExecutionDate { get; set; }

    public DateTime? RprDownloadDate { get; set; }

    public string? RprSessionId { get; set; }

    public string? RprDownloadLink { get; set; }

    public virtual Codesc? RprCdIdRrsNavigation { get; set; }

    public virtual Report? RprRp { get; set; }

    public virtual User? RprUs { get; set; }
}
