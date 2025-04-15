using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class DeliveryDetailsToBeDeleted
{
    public int DvdId { get; set; }

    public int DvdDvId { get; set; }

    public int DvdPrId { get; set; }

    public int? DvdCdIdDdq { get; set; }

    public string DvdQuantity { get; set; } = null!;

    public int DvdPackQuantity { get; set; }

    public string? DvdQtyDelivered { get; set; }

    public int? DvdPackQtyDlv { get; set; }

    public string? DvdPrCode { get; set; }

    public string DvdPrBarcode { get; set; } = null!;

    public string DvdPrDescriptionAr { get; set; } = null!;

    public string DvdPrDescription { get; set; } = null!;

    public int? DvdUnitPerPack { get; set; }

    public int? DvdSynched { get; set; }

    public string? DvdExpiryDate { get; set; }

    public string? DvdLotNo { get; set; }
}
