using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class SalesassetInventoryDetailSnc
{
    public int SAtidId { get; set; }

    public int SAtidAtiId { get; set; }

    public int SAtidAtId { get; set; }

    public int SAtidSmId { get; set; }

    public decimal SAtidQuantity { get; set; }

    public string? SAtidRemark { get; set; }

    public string SAtidVersion { get; set; } = null!;
}
