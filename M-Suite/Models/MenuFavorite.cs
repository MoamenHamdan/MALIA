using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class MenuFavorite
{
    public int MnfId { get; set; }

    public int? MnfMnId { get; set; }

    public short? MnfOrder { get; set; }
}
