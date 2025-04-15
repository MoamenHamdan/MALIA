using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VProfileMenuAccess
{
    public int MndId { get; set; }

    public int? MndMnId { get; set; }

    public string? MndCdDescription { get; set; }

    public int? MndPmaId { get; set; }

    public int MndPrId { get; set; }

    public int MndVisible { get; set; }
}
