using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class UiMovementFunctionNouse
{
    public int UmfId { get; set; }

    public int? UmfMvtId { get; set; }

    public int? UmfMssId { get; set; }

    public string? UmfKey { get; set; }

    public short? UmfValue { get; set; }

    public virtual Movementstatus? UmfMss { get; set; }

    public virtual Movementtype1? UmfMvt { get; set; }
}
