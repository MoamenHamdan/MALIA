using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class GeoTagRepV
{
    public string SalesmanName { get; set; } = null!;

    public string SalesmanCode { get; set; } = null!;

    public string CustomerName { get; set; } = null!;

    public string Type { get; set; } = null!;

    public string Docnb { get; set; } = null!;

    public DateTime Date { get; set; }

    public string Latitude { get; set; } = null!;

    public string Longitude { get; set; } = null!;

    public string MapThis { get; set; } = null!;

    public int UsId { get; set; }
}
