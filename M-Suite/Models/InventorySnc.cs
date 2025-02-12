using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class InventorySnc
{
    public int SIvId { get; set; }

    public int SIvVtId { get; set; }

    public int SIvCuId { get; set; }

    public DateTime SIvDate { get; set; }

    public string SIvCode { get; set; } = null!;

    public string? SIvDescription { get; set; }

    public int SIvSmId { get; set; }

    public string SIvVersion { get; set; } = null!;

    public int? SIvRivId { get; set; }

    public string? SIvVtUid { get; set; }

    public string? SIvUid { get; set; }
}
