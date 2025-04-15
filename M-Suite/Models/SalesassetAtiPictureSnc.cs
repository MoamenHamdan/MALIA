using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class SalesassetAtiPictureSnc
{
    public int SAtipId { get; set; }

    public int SAtipAtiId { get; set; }

    public int SAtipSmId { get; set; }

    public string SAtipFilename { get; set; } = null!;

    public string SAtipVersion { get; set; } = null!;
}
