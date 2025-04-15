using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ItemMslThp
{
    public int ImsltId { get; set; }

    public int ImsltImslId { get; set; }

    public int? ImsltThpsId { get; set; }

    public int? ImsltThcfId { get; set; }

    public int? ImsltThcfvId { get; set; }

    public virtual ItemMsl ImsltImsl { get; set; } = null!;

    public virtual ThirdpartySite? ImsltThps { get; set; }
}
