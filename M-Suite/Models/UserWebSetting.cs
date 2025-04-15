using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class UserWebSetting
{
    public int UswsId { get; set; }

    public int UswsUsId { get; set; }

    public string UswsKey { get; set; } = null!;

    public string UswsValue { get; set; } = null!;

    public string? UswsPage { get; set; }

    public DateTime UswsDate { get; set; }

    public string UswsGroup { get; set; } = null!;

    public virtual User UswsUs { get; set; } = null!;
}
