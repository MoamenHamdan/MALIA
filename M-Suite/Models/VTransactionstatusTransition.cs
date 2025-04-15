using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VTransactionstatusTransition
{
    public int TsstId { get; set; }

    public int TsstTstId { get; set; }

    public int TsstTssIdFrom { get; set; }

    public int TsstTssIdTo { get; set; }

    public int? TsstTstIdGenerate { get; set; }

    public int? TsstTssIdGenerate { get; set; }

    public short TsstTsUsIsOwner { get; set; }

    public short TsstCheckAvailability { get; set; }

    public short TsstUpdateQuantity { get; set; }

    public short TsstLxpRequired { get; set; }

    public short TsstAutoAllocateLxp { get; set; }

    public short TsstManageDueInvoice { get; set; }

    public string? TsstExtraCode { get; set; }

    public short TsstExportData { get; set; }

    public string TsstTstCode { get; set; } = null!;

    public string? TsstTstDescriptionLan1 { get; set; }

    public string? TsstTstDescriptionLan2 { get; set; }

    public string TssFromCode { get; set; } = null!;

    public string TsstFromTssDescriptionLan1 { get; set; } = null!;

    public string TsstFromTssDescriptionLan2 { get; set; } = null!;

    public string TssToCode { get; set; } = null!;

    public string TsstToTssDescriptionLan1 { get; set; } = null!;

    public string TsstToTssDescriptionLan2 { get; set; } = null!;

    public string? TsstDescriptionLan1 { get; set; }

    public string? TsstDescriptionLan2 { get; set; }

    public int TsstSilentMode { get; set; }
}
