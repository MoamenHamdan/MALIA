using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class GeoTagSnc
{
    public int SGtId { get; set; }

    public int SGtCdIdGet { get; set; }

    public int SGtSmId { get; set; }

    public DateTime SGtDatetime { get; set; }

    public string SGtLatitude { get; set; } = null!;

    public string SGtLongitude { get; set; } = null!;

    public string? SGtSeaAltitude { get; set; }

    public string? SGtEllipsoidAltitude { get; set; }

    public string? SGtHeading { get; set; }

    public int? SGtSatelliteCount { get; set; }

    public int? SGtSatelliteInviewCount { get; set; }

    public string? SGtPdop { get; set; }

    public string? SGtHdop { get; set; }

    public string? SGtVdop { get; set; }

    public string? SGtSpeed { get; set; }

    public string? SGtGpsDatetime { get; set; }

    public string? SGtColumn { get; set; }

    public string? SGtColumnValue { get; set; }

    public string? SGtFreeText { get; set; }

    public string SGtVersion { get; set; } = null!;

    public string? SGtColumnValueUid { get; set; }
}
