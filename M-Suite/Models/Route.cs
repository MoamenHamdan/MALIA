using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class Route
{
    public int RtId { get; set; }

    public string RtCode { get; set; } = null!;

    public string? RtDescriptionLan1 { get; set; }

    public string? RtDescriptionLan2 { get; set; }

    public string? RtDescriptionLan3 { get; set; }

    public DateOnly RtFromDate { get; set; }

    public DateOnly RtToDate { get; set; }

    public DateTime? RtFromTime { get; set; }

    public DateTime? RtToTime { get; set; }

    public int? RtRtsId { get; set; }

    public int? RtUsId { get; set; }

    public int RtPlId { get; set; }

    public DateTime RtCreationDate { get; set; }

    public int RtUsIdCr { get; set; }

    public DateTime? RtUpdateDate { get; set; }

    public int? RtUsIdUp { get; set; }

    public string? RtComments { get; set; }

    public int? RtExecutionMode { get; set; }

    public virtual User? RtUs { get; set; }
}
