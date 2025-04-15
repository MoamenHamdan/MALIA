using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class Salesman
{
    public int SmId { get; set; }

    public int SmUgmId { get; set; }

    public int? SmCuId { get; set; }

    public string? SmCode { get; set; }

    public string? SmName { get; set; }

    public string? SmLogin { get; set; }

    public string? SmPassword { get; set; }

    public string? SmPrinterName { get; set; }

    public int? SmVanId { get; set; }

    public string? SmVanNo { get; set; }

    public int? SmCdIdGlobalCur { get; set; }

    public decimal? SmBalance { get; set; }

    public decimal? SmCreditLimit { get; set; }

    public string? SmAccessRights { get; set; }

    public string SmText1 { get; set; } = null!;

    public int SmRefId { get; set; }
}
