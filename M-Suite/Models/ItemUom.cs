using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ItemUom
{
    public int ItuId { get; set; }

    public int ItuItId { get; set; }

    public int ItuUomId { get; set; }

    public decimal ItuConvValue { get; set; }

    public string? ItuShortname { get; set; }

    public short? ItuActive { get; set; }

    public string? ItuOracleUom { get; set; }

    public decimal? ItuConvValueIni { get; set; }

    public virtual ICollection<ItemUomAdditionalInfo> ItemUomAdditionalInfos { get; set; } = new List<ItemUomAdditionalInfo>();

    public virtual ICollection<ItemUomBarcode> ItemUomBarcodes { get; set; } = new List<ItemUomBarcode>();

    public virtual Item ItuIt { get; set; } = null!;

    public virtual Uom ItuUom { get; set; } = null!;
}
