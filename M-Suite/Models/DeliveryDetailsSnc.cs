using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class DeliveryDetailsSnc
{
    public int SDvdId { get; set; }

    public int SDvdDvId { get; set; }

    public int SDvdPrId { get; set; }

    public int? SDvdCdIdDdq { get; set; }

    public decimal SDvdQuantity { get; set; }

    public short SDvdPackQuantity { get; set; }

    public decimal? SDvdQtyDelivered { get; set; }

    public short? SDvdPackQtyDlv { get; set; }

    public string? SDvdPrCode { get; set; }

    public string SDvdPrBarcode { get; set; } = null!;

    public string SDvdPrDescriptionAr { get; set; } = null!;

    public string? SDvdPrDescription { get; set; }

    public short? SDvdUnitPerPack { get; set; }

    public short? SDvdSynched { get; set; }

    public string SDvdVersion { get; set; } = null!;

    public int SDvdSmId { get; set; }

    public string? SDvdExpiryDate { get; set; }

    public string? SDvdLotNo { get; set; }
}
