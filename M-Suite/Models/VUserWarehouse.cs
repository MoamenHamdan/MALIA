using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VUserWarehouse
{
    public int UswId { get; set; }

    public int? UswUsId { get; set; }

    public int? UswPlIdWhs { get; set; }

    public short UswIsDefault { get; set; }

    public string UswWhsName { get; set; } = null!;

    public string UswWhsCode { get; set; } = null!;

    public string? UswWhsType { get; set; }
}
