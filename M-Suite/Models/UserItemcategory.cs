using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class UserItemcategory
{
    public int UigId { get; set; }

    public int UigUsId { get; set; }

    public int UigIcfvId { get; set; }

    public virtual User UigUs { get; set; } = null!;
}
