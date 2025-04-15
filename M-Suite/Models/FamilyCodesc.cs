using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class FamilyCodesc
{
    public int FcId { get; set; }

    public int? FcMdId { get; set; }

    public string FcCode { get; set; } = null!;

    public string FcDescriptionLan1 { get; set; } = null!;

    public string? FcDescriptionLan2 { get; set; }

    public string? FcDescriptionLan3 { get; set; }

    public short FcIsSystem { get; set; }

    public short FcIsTree { get; set; }

    public virtual ICollection<CodescLabel> CodescLabels { get; set; } = new List<CodescLabel>();

    public virtual ICollection<Codesc> Codescs { get; set; } = new List<Codesc>();

    public virtual Module? FcMd { get; set; }

    public virtual ICollection<UiCodesc> UiCodescs { get; set; } = new List<UiCodesc>();

    public virtual ICollection<VisitReason> VisitReasons { get; set; } = new List<VisitReason>();
}
