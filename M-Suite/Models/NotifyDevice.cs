using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class NotifyDevice
{
    public int NdId { get; set; }

    public int NdUsId { get; set; }

    public string? NdMessage { get; set; }

    public string? NdTitle { get; set; }

    public string? NdIcon { get; set; }

    public string? NdAction1 { get; set; }

    public string? NdAction2 { get; set; }

    public int NdStatus { get; set; }

    public DateTime NdCreationDate { get; set; }
}
