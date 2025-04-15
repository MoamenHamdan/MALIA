using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class MobileLog
{
    public int MlId { get; set; }

    public int? MlSmId { get; set; }

    public DateTime? MlDate { get; set; }

    public string? MlTag { get; set; }

    public string? MlDescription { get; set; }

    public DateTime? MlServerDate { get; set; }

    public string? MlType { get; set; }

    public string? MlDevice { get; set; }
}
