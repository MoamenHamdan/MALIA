using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class SalesassetAtiPicture
{
    public int AtipId { get; set; }

    public int AtipAtiId { get; set; }

    public string AtipFilename { get; set; } = null!;

    public virtual SalesassetInventory AtipAti { get; set; } = null!;
}
