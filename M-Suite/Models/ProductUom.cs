using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ProductUom
{
    public int PuomId { get; set; }

    public int? PuomBeId { get; set; }

    public int PuomPrId { get; set; }

    public int PuomUomId { get; set; }

    public string? PuomBarcode { get; set; }

    public decimal PuomConvSku { get; set; }

    public int? PuomIsBase { get; set; }

    public int? PuomLevel { get; set; }
}
