using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class SalesassetAtidPicture
{
    public int AtidpId { get; set; }

    public int AtidpAtidId { get; set; }

    public string AtidpFilename { get; set; } = null!;

    public virtual SalesassetInventoryDetail AtidpAtid { get; set; } = null!;
}
