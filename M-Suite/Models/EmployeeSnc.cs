using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class EmployeeSnc
{
    public int SEmId { get; set; }

    public string? SEmCode { get; set; }

    public string? SEmName { get; set; }

    public string? SEmLogin { get; set; }

    public string? SEmPassword { get; set; }

    public string? SEmPrinterName { get; set; }

    public short? SEmIsDataOwner { get; set; }

    public decimal? SEmBasicSalary { get; set; }

    public short? SEmActive { get; set; }

    public short? SEmCanLogin { get; set; }

    public int? SEmCdIdType { get; set; }

    public short SEmIsCreated { get; set; }

    public int? SEmEmId { get; set; }

    public string SEmVersion { get; set; } = null!;

    public short? SEmSynched { get; set; }

    public short? SEmUseBarcode { get; set; }
}
