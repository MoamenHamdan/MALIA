using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class UserBusinessUnit
{
    public int UbuId { get; set; }

    public int UbuUsId { get; set; }

    public int UbuBuId { get; set; }

    public DateOnly? UbuFromDate { get; set; }

    public DateOnly? UbuToDate { get; set; }

    public short? UbuIsOwner { get; set; }

    public virtual BusinessUnit UbuBu { get; set; } = null!;

    public virtual User UbuUs { get; set; } = null!;

    public virtual ICollection<UserFinance> UserFinances { get; set; } = new List<UserFinance>();
}
