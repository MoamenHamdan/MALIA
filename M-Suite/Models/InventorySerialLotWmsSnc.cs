using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class InventorySerialLotWmsSnc
{
    public int SInsId { get; set; }

    public int SInsIndId { get; set; }

    public string SInsSerials { get; set; } = null!;

    public decimal SInsQty { get; set; }

    public short SInsIsSerial { get; set; }

    public int? SInsIsCreated { get; set; }

    public int? SInsIsModified { get; set; }

    public int SInsUsIdSync { get; set; }

    public string SInsVersion { get; set; } = null!;
}
