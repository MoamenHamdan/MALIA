using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class SignatureDetailsSnc
{
    public int SSgdId { get; set; }

    public string? SSgdName { get; set; }

    public string? SSgdSignFile { get; set; }

    public DateTime? SSgdDate { get; set; }

    public string? SSgdText1 { get; set; }

    public string? SSgdText2 { get; set; }

    public int? SSgdSmId { get; set; }

    public string SSgdVersion { get; set; } = null!;

    public short? SSgdSynched { get; set; }

    public int? SSgdIsCreated { get; set; }
}
