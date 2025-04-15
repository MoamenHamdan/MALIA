using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ItemPhoto
{
    public int ItpId { get; set; }

    public int ItpItId { get; set; }

    public short? ItpOrder { get; set; }

    public string ItpFilename { get; set; } = null!;

    public virtual Item ItpIt { get; set; } = null!;
}
