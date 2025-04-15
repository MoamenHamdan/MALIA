using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VPromotionInfoRep
{
    public string PnCode { get; set; } = null!;

    public string PnDescriptionLan1 { get; set; } = null!;

    public string PndCode { get; set; } = null!;

    public string PndDescriptionLan1 { get; set; } = null!;

    public int PndApplyOrder { get; set; }

    public string? PndPilDescriptionLan1 { get; set; }

    public int? PndPrecedence { get; set; }

    public int? PndDeduceValue { get; set; }

    public string PndAppliesOn { get; set; } = null!;

    public string PnDescriptionLan2 { get; set; } = null!;

    public string PnDescriptionLan3 { get; set; } = null!;

    public string PndDescriptionLan2 { get; set; } = null!;

    public string PndDescriptionLan3 { get; set; } = null!;

    public string? PndPilCode { get; set; }

    public string? PndPilDescriptionLan2 { get; set; }

    public string? PndPilDescriptionLan3 { get; set; }

    public string? PnPtpDescriptionLan1 { get; set; }

    public string? PnPtpDescriptionLan2 { get; set; }

    public string? PnPtpDescriptionLan3 { get; set; }

    public string? PnPpbDescriptionLan1 { get; set; }

    public string? PnPpbDescriptionLan2 { get; set; }

    public string? PnPpbDescriptionLan3 { get; set; }

    public DateTime PnFromDate { get; set; }

    public DateTime PnToDate { get; set; }

    public int PnActive { get; set; }

    public int PndActive { get; set; }

    public int PnId { get; set; }

    public int PndId { get; set; }

    public int? PndCdIdPil { get; set; }
}
