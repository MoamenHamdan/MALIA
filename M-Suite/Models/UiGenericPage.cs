using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class UiGenericPage
{
    public int GpId { get; set; }

    public string? GpCode { get; set; }

    public string? GpTitle { get; set; }

    public short? GpActive { get; set; }

    public short? GpAutoLoad { get; set; }

    public string? GpAction { get; set; }

    public string? GpObjectid { get; set; }

    public string? GpActionField { get; set; }

    public short? GpRowsPerPage { get; set; }

    public string? GpProcedureName { get; set; }

    public string? GpType { get; set; }

    public int? GpMnId { get; set; }

    public virtual ICollection<MovementtypeUiGenericpage> MovementtypeUiGenericpages { get; set; } = new List<MovementtypeUiGenericpage>();

    public virtual ICollection<TransactiontypeUiGenericpage> TransactiontypeUiGenericpages { get; set; } = new List<TransactiontypeUiGenericpage>();

    public virtual ICollection<UiGenericPageAction> UiGenericPageActions { get; set; } = new List<UiGenericPageAction>();

    public virtual ICollection<UiGenericPageCriterion> UiGenericPageCriteria { get; set; } = new List<UiGenericPageCriterion>();
}
