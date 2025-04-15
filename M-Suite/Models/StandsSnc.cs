using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class StandsSnc
{
    public int SStId { get; set; }

    public int? SStCuId { get; set; }

    public int? SStCdIdSclr { get; set; }

    public int? SStCdIdStyp { get; set; }

    public int? SStCdIdSmtr { get; set; }

    public int? SStCdIdSfrm { get; set; }

    public int? SStCdIdSdim { get; set; }

    public string? SStCode { get; set; }

    public string? SStBarcode { get; set; }

    public string? SStDescription { get; set; }

    public string? SStDescriptionAr { get; set; }

    public string? SStText1 { get; set; }

    public string? SStText2 { get; set; }

    public decimal? SStNum1 { get; set; }

    public decimal? SStNum2 { get; set; }

    public string SStVersion { get; set; } = null!;

    public string SStSmId { get; set; } = null!;
}
