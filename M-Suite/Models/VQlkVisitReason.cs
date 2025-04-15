using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VQlkVisitReason
{
    public int VtId { get; set; }

    public string? VrComments { get; set; }

    public DateTime VrDate { get; set; }

    public string? VrReasonCode { get; set; }

    public string? VrReasonLan1 { get; set; }

    public string? VrReasonLan2 { get; set; }

    public string? VrReasonLan3 { get; set; }
}
