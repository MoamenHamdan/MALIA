using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class TemplateThp
{
    public int TmpltId { get; set; }

    public int TmpltTmplId { get; set; }

    public int? TmpltThpsId { get; set; }

    public int? TmpltThcfId { get; set; }

    public int? TmpltThcfvId { get; set; }

    public virtual ThirdpartySite? TmpltThps { get; set; }

    public virtual Template TmpltTmpl { get; set; } = null!;
}
