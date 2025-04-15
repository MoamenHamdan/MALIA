using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class OperationBatchItem
{
    public int OpbiId { get; set; }

    public int OpbiOpbId { get; set; }

    public int OpbiOpiId { get; set; }

    public int? OpbiItId { get; set; }

    public int? OpbiUomId { get; set; }

    public int? OpbiOptoId { get; set; }

    public int? OpbiPlIdWhs { get; set; }

    public short OpbiLineSequence { get; set; }

    public int? OpbiPlIdLoc { get; set; }

    public decimal OpbiQuantity { get; set; }

    public decimal OpbiQuantity2 { get; set; }

    public string? OpbiRemarks { get; set; }

    public string? OpbiItCode { get; set; }

    public virtual Item? OpbiIt { get; set; }

    public virtual OperationBatch OpbiOpb { get; set; } = null!;

    public virtual OperationItem OpbiOpi { get; set; } = null!;

    public virtual OperationtypeOption? OpbiOpto { get; set; }

    public virtual PhysicalLocation? OpbiPlIdLocNavigation { get; set; }

    public virtual PhysicalLocation? OpbiPlIdWhsNavigation { get; set; }

    public virtual Uom? OpbiUom { get; set; }

    public virtual ICollection<OperationBatchItemDetail> OperationBatchItemDetails { get; set; } = new List<OperationBatchItemDetail>();
}
