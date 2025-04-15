using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class Stand
{
    public int StId { get; set; }

    public int? StCdIdStyp { get; set; }

    public int? StCdIdSclr { get; set; }

    public int? StCdIdSfrm { get; set; }

    public int? StCdIdSdim { get; set; }

    public int? StCdIdSmtr { get; set; }

    public int? StCuId { get; set; }

    public string StCode { get; set; } = null!;

    public string StBarcode { get; set; } = null!;

    public string StDescription { get; set; } = null!;

    public string StDescriptionAr { get; set; } = null!;

    public string? StText1 { get; set; }

    public string? StText2 { get; set; }

    public decimal? StNum1 { get; set; }

    public decimal? StNum2 { get; set; }

    public int? StBeId { get; set; }
}
