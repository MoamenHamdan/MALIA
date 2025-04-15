using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class UserDeviceInfoSnc
{
    public string? SUdiDeviceImei { get; set; }

    public DateTime SUdiCreationDate { get; set; }

    public string? SUdiDeviceSerial { get; set; }

    public string? SUdiDeviceIp { get; set; }

    public int SUdiSmId { get; set; }

    public string SUdiVersion { get; set; } = null!;
}
