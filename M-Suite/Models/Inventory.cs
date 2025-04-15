using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class Inventory
{
    public int IvId { get; set; }

    public int? IvBuId { get; set; }

    public int IvVtId { get; set; }

    public int IvThpsId { get; set; }

    public DateTime IvDate { get; set; }

    public string IvCode { get; set; } = null!;

    public string? IvDescription { get; set; }

    public int IvIsCreated { get; set; }
}
