using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ProductTargetSnc
{
    public int? SPrgId { get; set; }

    public string? SPrgType { get; set; }

    public int? SPrgSmId { get; set; }

    public int? SPrgPrId { get; set; }

    public int? SPrgPbId { get; set; }

    public int? SPrgGpId { get; set; }

    public string? SPrgYmValue { get; set; }

    public decimal? SPrgYmTargetV { get; set; }

    public decimal? SPrgYmTargetR { get; set; }

    public int? SPrgYtdValue { get; set; }

    public decimal? SPrgYtdTargetV { get; set; }

    public decimal? SPrgYtdTargetR { get; set; }

    public string? SPrgVersion { get; set; }
}
