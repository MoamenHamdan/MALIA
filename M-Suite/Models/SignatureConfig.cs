using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class SignatureConfig
{
    public int SgcId { get; set; }

    public string SgcScreenCode { get; set; } = null!;

    public string? SgcSourceCodes { get; set; }

    public int SgcMaxCount { get; set; }

    public int? SgcMinCount { get; set; }

    public string? SgcFolder { get; set; }

    public virtual ICollection<SignatureConfigLine> SignatureConfigLines { get; set; } = new List<SignatureConfigLine>();
}
