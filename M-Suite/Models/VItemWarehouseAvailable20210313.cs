using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VItemWarehouseAvailable20210313
{
    public int IwaItId { get; set; }

    public int IwaPlId { get; set; }

    public int IwaUomId { get; set; }

    public decimal? IwaStockQuantity { get; set; }

    public decimal? IwaMvQuantity { get; set; }

    public decimal? IwaTsQuantity { get; set; }

    public decimal? IwaReservedQuantity { get; set; }

    public decimal? IwaAvailableQuantity { get; set; }
}
