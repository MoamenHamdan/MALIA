using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ProfileMenu
{
    public int PrmId { get; set; }

    public int PrmPrId { get; set; }

    public int PrmMnId { get; set; }

    public virtual Profile PrmPr { get; set; } = null!;
}
