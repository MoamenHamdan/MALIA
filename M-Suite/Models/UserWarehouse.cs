using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class UserWarehouse
{
    public int UswId { get; set; }

    public int? UswUsId { get; set; }

    public int? UswPlIdWhs { get; set; }

    public short UswIsDefault { get; set; }

    public short? UswIsOwner { get; set; }

    public virtual PhysicalLocation? UswPlIdWhsNavigation { get; set; }

    public virtual User? UswUs { get; set; }
}
