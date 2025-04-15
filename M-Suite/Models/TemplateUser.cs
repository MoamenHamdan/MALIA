using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class TemplateUser
{
    public int TmpluId { get; set; }

    public int TmpluTmplId { get; set; }

    public int TmpluUsId { get; set; }

    public virtual Template TmpluTmpl { get; set; } = null!;

    public virtual User TmpluUs { get; set; } = null!;
}
