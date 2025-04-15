using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ProfileAppliSetting
{
    public int PasId { get; set; }

    public int PasAsId { get; set; }

    public int PasPrId { get; set; }

    public virtual AppliSetting PasAs { get; set; } = null!;

    public virtual Profile PasPr { get; set; } = null!;
}
