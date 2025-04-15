using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class MovementtypeUiGenericpage
{
    public int MtgpId { get; set; }

    public int MtgpMvtId { get; set; }

    public int MtgpGpId { get; set; }

    public virtual UiGenericPage MtgpGp { get; set; } = null!;

    public virtual Movementtype1 MtgpMvt { get; set; } = null!;
}
