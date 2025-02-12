using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class TransferSnc
{
    public int STrId { get; set; }

    public string STrInOut { get; set; } = null!;

    public DateTime STrDate { get; set; }

    public string STrCode { get; set; } = null!;

    public int STrSmIdFrom { get; set; }

    public int STrSmIdTo { get; set; }

    public string? STrRemarks { get; set; }

    public string? STrSignFilename { get; set; }

    public short? STrIsCreated { get; set; }

    public short? STrSynched { get; set; }

    public string STrVersion { get; set; } = null!;

    public int STrSmId { get; set; }

    public int? STrWhIdFrom { get; set; }

    public int? STrWhIdTo { get; set; }

    public string? STrUid { get; set; }
}
