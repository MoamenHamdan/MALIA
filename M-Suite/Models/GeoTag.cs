using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class GeoTag
{
    public int GtId { get; set; }

    public int? GtOrgId { get; set; }

    public int GtCdIdGet { get; set; }

    public int GtUsId { get; set; }

    public DateTime GtDatetime { get; set; }

    public string GtLatitude { get; set; } = null!;

    public string GtLongitude { get; set; } = null!;

    public string? GtSeaAltitude { get; set; }

    public string? GtEllipsoidAltitude { get; set; }

    public string? GtHeading { get; set; }

    public int? GtSatelliteCount { get; set; }

    public int? GtSatelliteInviewCount { get; set; }

    public string? GtPdop { get; set; }

    public string? GtHdop { get; set; }

    public string? GtVdop { get; set; }

    public string? GtSpeed { get; set; }

    public string? GtGpsDatetime { get; set; }

    public string GtColumn { get; set; } = null!;

    public string GtColumnValue { get; set; } = null!;

    public string? GtFreeText { get; set; }

    public virtual Codesc GtCdIdGetNavigation { get; set; } = null!;

    public virtual User GtUs { get; set; } = null!;
}
