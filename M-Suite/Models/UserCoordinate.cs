using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class UserCoordinate
{
    public int UcId { get; set; }

    public int UcUsId { get; set; }

    public string? UcLatitude { get; set; }

    public string? UcLongitude { get; set; }

    public DateTime? UbuDatetime { get; set; }
}
