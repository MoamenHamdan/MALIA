using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class SignatureInfoSnc
{
    public int SSiId { get; set; }

    public string? SSiScreenCode { get; set; }

    public string? SSiNameLb { get; set; }

    public string? SSiCodeLb { get; set; }

    public string? SSiDocLb { get; set; }

    public string? SSiDocvalLb { get; set; }

    public string? SSiFolder { get; set; }

    public string SSiVersion { get; set; } = null!;

    public string SSiSmId { get; set; } = null!;
}
