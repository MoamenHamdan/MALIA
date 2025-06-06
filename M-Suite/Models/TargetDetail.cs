﻿using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class TargetDetail
{
    public int TdId { get; set; }

    public int TdTaId { get; set; }

    public int? TdGlId { get; set; }

    public int? TdItId { get; set; }

    public int? TdCdIdIbd { get; set; }

    public int? TdCdIdIgp { get; set; }

    public int? TdUsId { get; set; }

    public int? TdThpsId { get; set; }

    public decimal? TdJan { get; set; }

    public decimal? TdFeb { get; set; }

    public decimal? TdMar { get; set; }

    public decimal? TdApr { get; set; }

    public decimal? TdMai { get; set; }

    public decimal? TdJun { get; set; }

    public decimal? TdJul { get; set; }

    public decimal? TdAug { get; set; }

    public decimal? TdSep { get; set; }

    public decimal? TdOct { get; set; }

    public decimal? TdNov { get; set; }

    public decimal? TdDec { get; set; }

    public decimal? TdTotal { get; set; }

    public virtual ItemcategoryFamilyValue? TdCdIdIgpNavigation { get; set; }

    public virtual GeoLocation? TdGl { get; set; }

    public virtual Item? TdIt { get; set; }

    public virtual Target TdTa { get; set; } = null!;

    public virtual ThirdpartySite? TdThps { get; set; }

    public virtual User? TdUs { get; set; }
}
