using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class SalesmanSnc
{
    public int SSmId { get; set; }

    public int? SSmUgmId { get; set; }

    public int? SSmCuId { get; set; }

    public string? SSmCode { get; set; }

    public string? SSmName { get; set; }

    public string? SSmLogin { get; set; }

    public string? SSmPassword { get; set; }

    public string SSmPrinterName { get; set; } = null!;

    public int? SSmIsDataOwner { get; set; }

    public int? SSmVanId { get; set; }

    public string? SSmVanNo { get; set; }

    public int? SSmCdIdGlobalCur { get; set; }

    public decimal? SSmBalance { get; set; }

    public decimal? SSmCreditLimit { get; set; }

    public string? SSmAccessRights { get; set; }

    public string? SSmText1 { get; set; }

    public string? SSmRefId { get; set; }

    public int SSmSmId { get; set; }

    public string SSmVersion { get; set; } = null!;
}
