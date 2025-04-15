using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class Operationtype
{
    public int OptId { get; set; }

    public string OptCode { get; set; } = null!;

    public string? OptDescriptionLan1 { get; set; }

    public string? OptDescriptionLan2 { get; set; }

    public string? OptDescriptionLan3 { get; set; }

    public string? OptNameLan1 { get; set; }

    public string? OptNameLan2 { get; set; }

    public string? OptNameLan3 { get; set; }

    public string? OptNotes { get; set; }

    public short? OptManageSerial { get; set; }

    public short? OptManageLot { get; set; }

    public short? OptShowPrice { get; set; }

    public virtual ICollection<OperationBatch> OperationBatches { get; set; } = new List<OperationBatch>();

    public virtual ICollection<Operation> Operations { get; set; } = new List<Operation>();

    public virtual ICollection<OperationtypeOption> OperationtypeOptions { get; set; } = new List<OperationtypeOption>();
}
