using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class TaskMessageSnc
{
    public int STmId { get; set; }

    public int STmSmId { get; set; }

    public short? STmOrder { get; set; }

    public DateTime STmDate { get; set; }

    public string? STmDescription { get; set; }

    public short STmFlag { get; set; }

    public string STmVersion { get; set; } = null!;

    public short? STmSynched { get; set; }
}
