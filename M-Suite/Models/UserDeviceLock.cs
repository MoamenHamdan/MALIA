using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class UserDeviceLock
{
    public int UdlId { get; set; }

    public int UdlUsId { get; set; }

    public string? UdlDeviceImei { get; set; }

    public DateTime UdlCreationDate { get; set; }

    public string? UdlDeviceSerial { get; set; }

    public string? UdlDeviceIp { get; set; }

    public string UdlVersion { get; set; } = null!;

    public int UdlState { get; set; }

    public string? UdlUpVersion { get; set; }

    public virtual User UdlUs { get; set; } = null!;
}
