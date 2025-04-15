using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class TraceAppWeb
{
    public int TraId { get; set; }

    public int TraUsId { get; set; }

    public string TraPage { get; set; } = null!;

    public string? TraSession { get; set; }

    public string? TraAction { get; set; }

    public string? TraMessage { get; set; }

    public DateTime? TraDateTime { get; set; }

    public short? TraStatus { get; set; }

    public string? TraClientAddress { get; set; }
}
