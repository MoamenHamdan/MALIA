using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class SalesassetInventorySnc
{
    public int SAtiId { get; set; }

    public int SAtiUsId { get; set; }

    public int SAtiVtId { get; set; }

    public int SAtiThpsId { get; set; }

    public int SAtiSmId { get; set; }

    public DateTime SAtiDatetime { get; set; }

    public string? SAtiRemark { get; set; }

    public string? SAtiLatitude { get; set; }

    public string? SAtiLongitude { get; set; }

    public string SAtiVersion { get; set; } = null!;
}
