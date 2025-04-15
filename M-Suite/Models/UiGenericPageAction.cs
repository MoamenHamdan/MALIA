using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class UiGenericPageAction
{
    public int GpaId { get; set; }

    public int? GpaGpId { get; set; }

    public int? GpaCdIdAct { get; set; }

    public short? GpaOrder { get; set; }

    public string? GpaCode { get; set; }

    public string? GpaTitle { get; set; }

    public string? GpaDescription { get; set; }

    public string? GpaStyle { get; set; }

    public string? GpaIngridStyle { get; set; }

    public string? GpaProcedureName { get; set; }

    public short? GpaActive { get; set; }

    public string? GpaCommand { get; set; }

    public string? GpaCommandArgument { get; set; }

    public string? GpaAction { get; set; }

    public short? GpaIsGridAction { get; set; }

    public short? GpaIsIngridAction { get; set; }

    public short? GpaRequireConfirmation { get; set; }

    public string? GpaConfirmationCode { get; set; }

    public string? GpaGridImageUrl { get; set; }

    public string? GpaIngridImageUrl { get; set; }

    public virtual UiGenericPage? GpaGp { get; set; }
}
