using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class UserAppliSetting
{
    public int UasId { get; set; }

    public int UasAsId { get; set; }

    public int UasUsId { get; set; }

    public string UasAsValue { get; set; } = null!;

    public virtual AppliSetting UasAs { get; set; } = null!;

    public virtual User UasUs { get; set; } = null!;
}
