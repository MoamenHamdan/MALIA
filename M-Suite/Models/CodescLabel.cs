using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class CodescLabel
{
    public int ClId { get; set; }

    public int ClFcId { get; set; }

    public string? ClText1 { get; set; }

    public string? ClText2 { get; set; }

    public string? ClNum1 { get; set; }

    public string? ClNum2 { get; set; }

    public string? ClNum3 { get; set; }

    public string? ClDate1 { get; set; }

    public string? ClDate2 { get; set; }

    public virtual FamilyCodesc ClFc { get; set; } = null!;
}
