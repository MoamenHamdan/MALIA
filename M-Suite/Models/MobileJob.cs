using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class MobileJob
{
    public int MjId { get; set; }

    public string MjActionCode { get; set; } = null!;

    public string? MjDirectoryPath { get; set; }

    public string? MjFileName { get; set; }

    public string? MjScript { get; set; }

    public DateTime? MjStartDate { get; set; }

    public DateTime? MjExpiryDate { get; set; }

    public int? MjUsId { get; set; }

    public int? MjActive { get; set; }
}
