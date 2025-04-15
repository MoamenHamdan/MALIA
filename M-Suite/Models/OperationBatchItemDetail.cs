using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class OperationBatchItemDetail
{
    public int OpbidId { get; set; }

    public int? OpbidOpbiId { get; set; }

    public int OpbidOpidId { get; set; }

    public int OpbidIldId { get; set; }

    public decimal OpbidQuantity { get; set; }

    public decimal? OpbidQuantity2 { get; set; }

    public int? OpbidPlIdLoc { get; set; }

    public int? OpbidPlIdWhs { get; set; }

    public string? OpbidLotSerial { get; set; }

    public DateTime? OpbidExpiryDate { get; set; }

    public DateTime? OpbidProductionDate { get; set; }

    public virtual OperationBatchItem? OpbidOpbi { get; set; }

    public virtual OperationItemDetail OpbidOpid { get; set; } = null!;

    public virtual PhysicalLocation? OpbidPlIdLocNavigation { get; set; }

    public virtual PhysicalLocation? OpbidPlIdWhsNavigation { get; set; }
}
