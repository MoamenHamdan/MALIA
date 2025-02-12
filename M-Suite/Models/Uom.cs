using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class Uom
{
    public int UomId { get; set; }

    public string UomCode { get; set; } = null!;

    public string? UomNameLan1 { get; set; }

    public string? UomNameLan2 { get; set; }

    public string? UomNameLan3 { get; set; }

    public short? UomRoundingPrecision { get; set; }

    public short UomIsBase { get; set; }

    public int? UomIsSaleable { get; set; }

    public string? UomOrder { get; set; }

    public virtual ICollection<ItemUom> ItemUoms { get; set; } = new List<ItemUom>();

    public virtual ICollection<Item> Items { get; set; } = new List<Item>();
}
