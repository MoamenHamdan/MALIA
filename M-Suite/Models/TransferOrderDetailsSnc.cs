using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class TransferOrderDetailsSnc
{
    public int STodId { get; set; }

    public int STodToId { get; set; }

    public int STodPrId { get; set; }

    public int STodUomId { get; set; }

    public decimal? STodQuantity { get; set; }

    public string? STodLotNo { get; set; }

    public DateTime? STodProductionDate { get; set; }

    public DateTime? STodExpiryDate { get; set; }

    public int? STodSynched { get; set; }

    public string STodVersion { get; set; } = null!;

    public string STodSmId { get; set; } = null!;

    public int? STodIsCreated { get; set; }
}
