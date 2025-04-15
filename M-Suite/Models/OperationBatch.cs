using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class OperationBatch
{
    public int OpbId { get; set; }

    public int? OpbOpId { get; set; }

    public int? OpbUsId { get; set; }

    public int? OpbBuId { get; set; }

    public int? OpbOptId { get; set; }

    public int? OpbOpsId { get; set; }

    public int? OpbThpsId { get; set; }

    public int? OpbPlIdWhs { get; set; }

    public int? OpbPlIdWhsTo { get; set; }

    public string OpbNumber { get; set; } = null!;

    public DateTime OpbDate { get; set; }

    public string? OpbRemarks { get; set; }

    public string? OpbSync { get; set; }

    public int? OpbSeq { get; set; }

    public string? OpbBatchNb { get; set; }

    public virtual BusinessUnit? OpbBu { get; set; }

    public virtual Operationstatus? OpbOps { get; set; }

    public virtual Operationtype? OpbOpt { get; set; }

    public virtual PhysicalLocation? OpbPlIdWhsNavigation { get; set; }

    public virtual PhysicalLocation? OpbPlIdWhsToNavigation { get; set; }

    public virtual ThirdpartySite? OpbThps { get; set; }

    public virtual User? OpbUs { get; set; }

    public virtual ICollection<OperationBatchItem> OperationBatchItems { get; set; } = new List<OperationBatchItem>();

    public virtual ICollection<OperationPackaging> OperationPackagings { get; set; } = new List<OperationPackaging>();
}
