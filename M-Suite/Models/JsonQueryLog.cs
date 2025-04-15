using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class JsonQueryLog
{
    public int JqlId { get; set; }

    public string? JqlCallingProcedure { get; set; }

    public string? JqlUri { get; set; }

    public string JqlRequest { get; set; } = null!;

    public string? JqlResponse { get; set; }

    public DateTime JqlDatetime { get; set; }

    public int? JqlAnyId { get; set; }

    public string? JqlStatus { get; set; }

    public string? JqlStatusText { get; set; }

    public string? JqlAttribut01 { get; set; }

    public string? JqlAttribut02 { get; set; }

    public string? JqlAttribut03 { get; set; }

    public string? JqlAttribut04 { get; set; }

    public string? JqlAttribut05 { get; set; }

    public string? JqlTransactionumber { get; set; }

    public string? JqlVersion { get; set; }
}
