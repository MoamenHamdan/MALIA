using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class MobileGrid
{
    public int MgId { get; set; }

    public string MgGridCode { get; set; } = null!;

    public string MgField { get; set; } = null!;

    public string MgHeader { get; set; } = null!;

    public int? MgHeight { get; set; }

    public int? MgWidth { get; set; }

    public int? MgSelectAllOnFocus { get; set; }

    public string? MgInputType { get; set; }

    public string? MgViewType { get; set; }

    public string? MgCheckboxField { get; set; }

    public int? MgWithlabel { get; set; }

    public string? MgTextColor { get; set; }

    public int? MgMaxLength { get; set; }

    public int? MgColId { get; set; }

    public int? MgOrder { get; set; }

    public int? MgUsId { get; set; }

    public int? MgUgmId { get; set; }

    public int? MgFontSize { get; set; }

    public string? MgTextStyle { get; set; }

    public int? MgLabelMargin { get; set; }

    public string? MgBackground { get; set; }

    public string? MgBackgroundTint { get; set; }
}
