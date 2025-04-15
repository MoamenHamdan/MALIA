using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class Version
{
    public int VrId { get; set; }

    public string? VrDbVersion { get; set; }

    public string? VrMobileVersion { get; set; }

    public string? VrWebWersion { get; set; }

    public string? VrAndroidVersion { get; set; }

    public string? VrIosVersion { get; set; }

    public short VrIsLatest { get; set; }

    public DateTime VrDatetime { get; set; }

    public string? VrComments { get; set; }
}
