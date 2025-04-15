using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VItemWarehouseDetail
{
    public int ItwdItId { get; set; }

    public string ItwdItDescriptionLan1 { get; set; } = null!;

    public string ItwdItCode { get; set; } = null!;

    public int? ItwdId { get; set; }

    public int? ItwdItwId { get; set; }

    public string? ItwdSlNumber { get; set; }

    public DateTime? ItwdExpiryDate { get; set; }

    public DateTime? ItwdProductionDate { get; set; }

    public decimal? ItwdQuantity { get; set; }
}
