using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ExpXxVansalsTrxToDriverV
{
    public string TrxType { get; set; } = null!;

    public string? TrxDocNumber { get; set; }

    public int TrxId { get; set; }

    public string TrxOrgId { get; set; } = null!;

    public string TrxDriverName { get; set; } = null!;

    public string TrxVanNumber { get; set; } = null!;

    public string TrxItemId { get; set; } = null!;

    public string TrxItemCode { get; set; } = null!;

    public string TrxItemDescription { get; set; } = null!;

    public decimal OrderedQtyPiece { get; set; }

    public decimal OrderedQtyBag { get; set; }

    public decimal OrderedQtyBox { get; set; }

    public string LotNumber { get; set; } = null!;

    public DateTime? ProductionDate { get; set; }

    public DateTime? ExpiryDate { get; set; }

    public DateTime? BakeryDate { get; set; }

    public string ImportedFlag { get; set; } = null!;

    public int MvId { get; set; }

    public int MviId { get; set; }

    public int? MviOrgId { get; set; }
}
