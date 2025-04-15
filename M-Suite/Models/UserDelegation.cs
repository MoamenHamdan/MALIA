using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class UserDelegation
{
    public int UsdId { get; set; }

    public int UsdUsId { get; set; }

    public int UsdUsIdTo { get; set; }

    public int? UsdBuId { get; set; }

    public DateTime UsdFromDate { get; set; }

    public DateTime UsdToDate { get; set; }

    public string? UsdComments { get; set; }

    public short UsdActive { get; set; }
}
