using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class DataCollectionDetailsSnc
{
    public int SDcdId { get; set; }

    public int? SDcdDcId { get; set; }

    public string SDcdBarcode { get; set; } = null!;

    public string SDcdDescription { get; set; } = null!;

    public decimal SDcdQty { get; set; }

    public string? SDcdText1 { get; set; }

    public string? SDcdText2 { get; set; }

    public decimal? SDcdNum1 { get; set; }

    public decimal? SDcdNum2 { get; set; }

    public int SDcdSmId { get; set; }

    public string SDcdVersion { get; set; } = null!;
}
