using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VProfileMenuItem
{
    public int MnId { get; set; }

    public int? MnMnId { get; set; }

    public int MnOrder { get; set; }

    public short MnLevel { get; set; }

    public string MnCode { get; set; } = null!;

    public string MnDescription { get; set; } = null!;

    public string? MnDescription2 { get; set; }

    public string? MnDescription3 { get; set; }

    public string? MnCommand { get; set; }

    public string? MnIcon { get; set; }

    public short MnIsAction { get; set; }

    public short? MnActive { get; set; }

    public short? MnIsSystem { get; set; }

    public int MnVisible { get; set; }

    public int MnPrId { get; set; }
}
