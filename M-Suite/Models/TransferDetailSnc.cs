using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class TransferDetailSnc
{
    public int STrdId { get; set; }

    public int STrdTrId { get; set; }

    public int STrdPrId { get; set; }

    public decimal STrdUnitQty { get; set; }

    public int STrdPackQty { get; set; }

    public decimal STrdTotalQty { get; set; }

    public short STrdUnitPerPack { get; set; }

    public short? STrdIsCreated { get; set; }

    public short? STrdSynched { get; set; }

    public string STrdVersion { get; set; } = null!;

    public int STrdSmId { get; set; }

    public string STrdLotNo { get; set; } = null!;

    public string STrdExpiryDate { get; set; } = null!;

    public string? STrdTrUid { get; set; }
}
