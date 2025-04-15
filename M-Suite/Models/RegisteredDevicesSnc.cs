using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class RegisteredDevicesSnc
{
    public int SRdId { get; set; }

    public string? SRdSn { get; set; }

    public string? SRdModel { get; set; }

    public string SRdKey { get; set; } = null!;

    public string SRdUnlockKey { get; set; } = null!;

    public int? SRdDate { get; set; }

    public int SRdIsCurrent { get; set; }

    public int SRdSmId { get; set; }

    public string SRdVersion { get; set; } = null!;
}
