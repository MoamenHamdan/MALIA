using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ItemUomAdditionalInfo
{
    public int ItuaId { get; set; }

    public int ItuaItuId { get; set; }

    public decimal? ItuaWidth { get; set; }

    public decimal? ItuaHeight { get; set; }

    public decimal? ItuaDepth { get; set; }

    public decimal? ItuaArea { get; set; }

    public decimal? ItuaVolume { get; set; }

    public decimal? ItuaWeight { get; set; }

    public virtual ItemUom ItuaItu { get; set; } = null!;
}
