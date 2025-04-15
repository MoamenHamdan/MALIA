using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class InventorystatusTransition
{
    public int IvstId { get; set; }

    public int IvstCdIdIvtId { get; set; }

    public int IvstCdIdIvsFrom { get; set; }

    public int IvstCdIdIvsTo { get; set; }

    public string? IvstExtraCode { get; set; }

    public short IvstExportData { get; set; }

    public virtual Codesc IvstCdIdIvsFromNavigation { get; set; } = null!;

    public virtual Codesc IvstCdIdIvsToNavigation { get; set; } = null!;

    public virtual Codesc IvstCdIdIvt { get; set; } = null!;
}
