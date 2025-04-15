using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class UserThirdparty
{
    public int UthpId { get; set; }

    public int UthpUsId { get; set; }

    public int? UthpThpId { get; set; }

    public int? UthpBuId { get; set; }

    public int? UthpCcFrequency { get; set; }

    public virtual BusinessUnit? UthpBu { get; set; }

    public virtual Thirdparty? UthpThp { get; set; }

    public virtual User UthpUs { get; set; } = null!;
}
