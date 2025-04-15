using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class UserDeviceInfo
{
    public int UdiId { get; set; }

    public int UdiUsId { get; set; }

    public string? UdiDeviceImei { get; set; }

    public DateTime UdiCreationDate { get; set; }

    public string? UdiDeviceSerial { get; set; }

    public string? UdiDeviceIp { get; set; }

    public string UdiVersion { get; set; } = null!;

    public virtual User UdiUs { get; set; } = null!;
}
