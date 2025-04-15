using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ThirdpartySiteComment
{
    public int ThpscId { get; set; }

    public int ThpscThpsId { get; set; }

    public int ThpscUsId { get; set; }

    public DateTime ThpscCreationDate { get; set; }

    public string? ThpscComments { get; set; }

    public string? ThpscLatitude { get; set; }

    public string? ThpscLongitude { get; set; }

    public string ThpscUid { get; set; } = null!;

    public string? ThpscImgPath { get; set; }

    public string? ThpscCdIdThpscList { get; set; }
}
