using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ItemMslDetail
{
    public int ImsldId { get; set; }

    public int ImsldImslId { get; set; }

    public int ImsldItId { get; set; }

    public int? ImsldGrouping { get; set; }

    public virtual ItemMsl ImsldImsl { get; set; } = null!;

    public virtual Item ImsldIt { get; set; } = null!;
}
