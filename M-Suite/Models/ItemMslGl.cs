using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ItemMslGl
{
    public int ImslgId { get; set; }

    public int ImslgImslId { get; set; }

    public int ImslgGlId { get; set; }

    public virtual GeoLocation ImslgGl { get; set; } = null!;

    public virtual ItemMsl ImslgImsl { get; set; } = null!;
}
