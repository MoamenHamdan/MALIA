using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ReportMail
{
    public int RpmId { get; set; }

    public int? RpmRpId { get; set; }

    public string? RpmSubject { get; set; }

    public string? RpmProfile { get; set; }

    public string? RpmTo { get; set; }

    public string? RpmCc { get; set; }

    public string? RpmBcc { get; set; }

    public short? RpmPriority { get; set; }

    public string? RpmBody { get; set; }

    public short? RpmIsHtml { get; set; }

    public short? RpmActive { get; set; }

    public virtual Report? RpmRp { get; set; }
}
