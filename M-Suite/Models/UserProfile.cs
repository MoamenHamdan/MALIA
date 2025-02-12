using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class UserProfile
{
    public int UspId { get; set; }

    public int UspUsId { get; set; }

    public int UspPrId { get; set; }

    public virtual Profile UspPr { get; set; } = null!;

    public virtual User UspUs { get; set; } = null!;
}
