using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ThpsInventoryheaderstatusTransition
{
    public int TivhstId { get; set; }

    public int TivhstCdIdTivt { get; set; }

    public int TivhstCdIdTivsFrom { get; set; }

    public int TivhstCdIdTivsTo { get; set; }

    public string? TivhstExtraCode { get; set; }

    public short TivhstExportData { get; set; }

    public virtual ICollection<ThpsIvhsTransitionBu> ThpsIvhsTransitionBus { get; set; } = new List<ThpsIvhsTransitionBu>();

    public virtual ThpsIvhsTransitionProfile? ThpsIvhsTransitionProfile { get; set; }

    public virtual Codesc TivhstCdIdTivsFromNavigation { get; set; } = null!;

    public virtual Codesc TivhstCdIdTivsToNavigation { get; set; } = null!;

    public virtual Codesc TivhstCdIdTivtNavigation { get; set; } = null!;
}
