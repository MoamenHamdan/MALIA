using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class Operationstatus
{
    public int OpsId { get; set; }

    public string OpsCode { get; set; } = null!;

    public string OpsDescriptionLan1 { get; set; } = null!;

    public string OpsDescriptionLan2 { get; set; } = null!;

    public string OpsDescriptionLan3 { get; set; } = null!;

    public string OpsLabelCode { get; set; } = null!;

    public string? OpsStyle { get; set; }

    public string? OpsConfirmationCode { get; set; }

    public int OpsOrder { get; set; }

    public short OpsCausesValidation { get; set; }

    public virtual ICollection<OperationBatch> OperationBatches { get; set; } = new List<OperationBatch>();

    public virtual ICollection<Operation> Operations { get; set; } = new List<Operation>();
}
