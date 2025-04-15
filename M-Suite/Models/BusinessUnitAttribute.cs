using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class BusinessUnitAttribute
{
    public int BuaId { get; set; }

    public int? BuaBuId { get; set; }

    public int? BuaCdIdPrt { get; set; }

    public int? BuaCdIdMod { get; set; }

    public int? BuaCdIdPvt { get; set; }

    public string? BuaCode { get; set; }

    public virtual BusinessUnit? BuaBu { get; set; }
}
