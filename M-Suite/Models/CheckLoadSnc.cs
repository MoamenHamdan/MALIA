using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class CheckLoadSnc
{
    public int SClId { get; set; }

    public int SClSmId { get; set; }

    public DateTime? SClDate { get; set; }

    public string? SClComment { get; set; }

    public string? SClSignFilename { get; set; }

    public string? SClCode { get; set; }

    public short? SClStatus { get; set; }

    public string SClVersion { get; set; } = null!;

    public short? SClSynched { get; set; }
}
