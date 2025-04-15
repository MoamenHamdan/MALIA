using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class OperationtypeOption
{
    public int OptoId { get; set; }

    public int? OptoOptId { get; set; }

    public string? OptoCode { get; set; }

    public string? OptoDescriptionLan1 { get; set; }

    public string? OptoDescriptionLan2 { get; set; }

    public string? OptoDescriptionLan3 { get; set; }

    public short? OptoShowPrice { get; set; }

    public short? OptoManageLot { get; set; }

    public short? OptoManageSerial { get; set; }

    public virtual ICollection<OperationBatchItem> OperationBatchItems { get; set; } = new List<OperationBatchItem>();

    public virtual ICollection<OperationItem> OperationItems { get; set; } = new List<OperationItem>();

    public virtual Operationtype? OptoOpt { get; set; }
}
