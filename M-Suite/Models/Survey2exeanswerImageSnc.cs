using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class Survey2exeanswerImageSnc
{
    public int SSrxaiId { get; set; }

    public int SSrxaiSraId { get; set; }

    public string SSrxaiPathname { get; set; } = null!;

    public int? SSrxaiOrder { get; set; }

    public int SSrxaiUsId { get; set; }

    public string SSrxaiVersion { get; set; } = null!;
}
