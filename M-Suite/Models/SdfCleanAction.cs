using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class SdfCleanAction
{
    public int CaId { get; set; }

    public int? CaOrder { get; set; }

    public string CaStatement { get; set; } = null!;

    public int? CaBeId { get; set; }
}
