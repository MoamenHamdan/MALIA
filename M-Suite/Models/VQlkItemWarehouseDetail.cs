using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VQlkItemWarehouseDetail
{
    public int ItwdId { get; set; }

    public int ItwId { get; set; }

    public string? ItwdSlNumber { get; set; }

    public DateTime? ItwdExpiryDate { get; set; }

    public DateTime? ItwdProductionDate { get; set; }

    public decimal ItwdQuantity { get; set; }

    public int? ItwdExpiryDateNum { get; set; }

    public int? ItwdProductionDateNum { get; set; }
}
