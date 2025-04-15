using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VQlkItemWarehouse
{
    public int ItwId { get; set; }

    public int ItwPlIdWhs { get; set; }

    public int ItwItId { get; set; }

    public int ItwUomId { get; set; }

    public decimal ItwQuantity { get; set; }

    public decimal ItwQuantityDamage { get; set; }

    public decimal ItwQuantityReserved { get; set; }

    public decimal? ItwQuantityPreviewed { get; set; }

    public int PlId { get; set; }

    public int PlCdIdPlt { get; set; }

    public short? PlLevel { get; set; }

    public string PlCode { get; set; } = null!;

    public string PlDescriptionLan1 { get; set; } = null!;

    public string? PlDescriptionLan2 { get; set; }

    public string? PlDescriptionLan3 { get; set; }

    public string PltCode { get; set; } = null!;

    public string? PltDescriptionLan2 { get; set; }

    public string? PltDescriptionLan1 { get; set; }

    public string? PltDescriptionLan3 { get; set; }
}
