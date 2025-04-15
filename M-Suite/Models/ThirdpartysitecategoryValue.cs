using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ThirdpartysitecategoryValue
{
    public int ThpscvId { get; set; }

    public int ThpscvThpsId { get; set; }

    public int ThpscvThcfvId { get; set; }

    public int ThpscvThcfId { get; set; }

    public virtual ThirdpartycategoryFamily ThpscvThcf { get; set; } = null!;

    public virtual ThirdpartycategoryFamilyValue ThpscvThcfv { get; set; } = null!;

    public virtual ThirdpartySite ThpscvThps { get; set; } = null!;
}
