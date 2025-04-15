using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ProfileMenuDetail
{
    public int PmdId { get; set; }

    public int? PmdPrId { get; set; }

    public int? PmdMndId { get; set; }

    public virtual MenuDetail? PmdMnd { get; set; }

    public virtual Profile? PmdPr { get; set; }
}
