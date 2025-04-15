using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class OperationItemDetail
{
    public int OpidId { get; set; }

    public int? OpidOrgId { get; set; }

    public int OpidOpiId { get; set; }

    public int OpidIldId { get; set; }

    public decimal? OpidQuantity { get; set; }

    public decimal? OpidQuantity2 { get; set; }

    public int? OpidPlIdLoc { get; set; }

    public int? OpidPlIdWhs { get; set; }

    public virtual ICollection<OperationBatchItemDetail> OperationBatchItemDetails { get; set; } = new List<OperationBatchItemDetail>();

    public virtual OperationItem OpidOpi { get; set; } = null!;

    public virtual PhysicalLocation? OpidPlIdLocNavigation { get; set; }

    public virtual PhysicalLocation? OpidPlIdWhsNavigation { get; set; }
}
