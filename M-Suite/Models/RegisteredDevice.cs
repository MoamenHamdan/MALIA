using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class RegisteredDevice
{
    public int RdId { get; set; }

    public string? RdModel { get; set; }

    public string? RdSn { get; set; }

    public string RdKey { get; set; } = null!;

    public string RdUnlockKey { get; set; } = null!;

    public DateTime RdDate { get; set; }

    public int RdActive { get; set; }

    public int RdFirst { get; set; }

    public int? RdLast { get; set; }
}
