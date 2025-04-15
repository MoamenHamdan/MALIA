using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class TemplateItem
{
    public int TmpliId { get; set; }

    public int TmpliTmplId { get; set; }

    public int TmpliItId { get; set; }

    public int? TmpliUomId { get; set; }

    public decimal? TmpliQuantity { get; set; }

    public virtual Item TmpliIt { get; set; } = null!;

    public virtual Template TmpliTmpl { get; set; } = null!;

    public virtual Uom? TmpliUom { get; set; }
}
