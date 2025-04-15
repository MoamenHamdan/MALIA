using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class PromotionQualifier
{
    public int QlId { get; set; }

    public string QlCode { get; set; } = null!;

    public string QlDescriptionLan1 { get; set; } = null!;

    public string QlDescriptionLan2 { get; set; } = null!;

    public string QlDescriptionLan3 { get; set; } = null!;

    public short QlIsForeignKey { get; set; }

    public string? QlQualifierSourceTable { get; set; }

    public string? QlQualifierValuesTable { get; set; }

    public int? QlQualifierSourceTablePk { get; set; }

    public int QlValueType { get; set; }

    public string? QlColumnName { get; set; }

    public string? QlTargetColumn { get; set; }

    public int QlRoot { get; set; }

    public int QlMaxNbValue { get; set; }

    public string QlLinkedTo { get; set; } = null!;

    public virtual ICollection<PromotionDetailQualifier> PromotionDetailQualifiers { get; set; } = new List<PromotionDetailQualifier>();

    public virtual ICollection<PromotionMasterQualifier> PromotionMasterQualifiers { get; set; } = new List<PromotionMasterQualifier>();
}
