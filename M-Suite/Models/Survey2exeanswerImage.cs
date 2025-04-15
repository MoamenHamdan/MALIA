using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class Survey2exeanswerImage
{
    public int SrxaiId { get; set; }

    public int SrxaiSraId { get; set; }

    public string SrxaiPathname { get; set; } = null!;

    public int? SrxaiOrder { get; set; }

    public virtual Survey2ResultAnswer SrxaiSra { get; set; } = null!;
}
