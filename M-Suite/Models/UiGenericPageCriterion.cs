using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class UiGenericPageCriterion
{
    public int GpcId { get; set; }

    public int? GpcGpId { get; set; }

    public string? GpcCode { get; set; }

    public string? GpcTitle { get; set; }

    public string? GpcOrder { get; set; }

    public string? GpcDataType { get; set; }

    public string? GpcDataMember { get; set; }

    public string? GpcControlType { get; set; }

    public string? GpcControlAttribute { get; set; }

    public string? GpcAutoValue { get; set; }

    public short? GpcActive { get; set; }

    public virtual UiGenericPage? GpcGp { get; set; }
}
