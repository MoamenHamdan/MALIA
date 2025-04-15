using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class NoReasonsSnc
{
    public int SNrId { get; set; }

    public string SNrCode { get; set; } = null!;

    public int SNrVtId { get; set; }

    public int SNrCdId { get; set; }

    public string SNrVersion { get; set; } = null!;

    public short? SNrSynched { get; set; }

    public int SNrSmId { get; set; }

    public string? SNrVtUid { get; set; }
}
