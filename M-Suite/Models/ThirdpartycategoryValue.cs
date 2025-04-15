using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ThirdpartycategoryValue
{
    public int ThcvId { get; set; }

    public int ThcvThpId { get; set; }

    public int ThcvThcfvId { get; set; }

    public int ThcvThcfId { get; set; }

    public virtual ThirdpartycategoryFamily ThcvThcf { get; set; } = null!;

    public virtual ThirdpartycategoryFamilyValue ThcvThcfv { get; set; } = null!;

    public virtual Thirdparty ThcvThp { get; set; } = null!;
}
