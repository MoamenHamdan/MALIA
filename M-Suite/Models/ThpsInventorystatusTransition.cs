using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ThpsInventorystatusTransition
{
    public int TivstId { get; set; }

    public int TivstCdIdTivt { get; set; }

    public int TivstCdIdTivsFrom { get; set; }

    public int TivstCdIdTivsTo { get; set; }

    public string? TivstExtraCode { get; set; }

    public short TivstExportData { get; set; }

    public virtual ICollection<ThpsIvsTransitionBu> ThpsIvsTransitionBus { get; set; } = new List<ThpsIvsTransitionBu>();

    public virtual Codesc TivstCdIdTivsFromNavigation { get; set; } = null!;

    public virtual Codesc TivstCdIdTivsToNavigation { get; set; } = null!;

    public virtual Codesc TivstCdIdTivtNavigation { get; set; } = null!;
}
