using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ExpXxVansalsIntgrInvoiceLV
{
    public int InvoiceHeaderId { get; set; }

    public int InvoiceLineId { get; set; }

    public string ItemId { get; set; } = null!;

    public string? LotNumber { get; set; }

    public DateTime? ProductionDate { get; set; }

    public DateTime? ExpiryDate { get; set; }

    public string ItemCode { get; set; } = null!;

    public string ItemDescription { get; set; } = null!;

    public decimal OrderedQtyPiece { get; set; }

    public decimal OrderedQtyBag { get; set; }

    public decimal OrderedQtyBox { get; set; }

    public int? Shad { get; set; }

    public decimal? UnitPricePiece { get; set; }

    public decimal? UnitPriceBag { get; set; }

    public decimal? UnitPriceBox { get; set; }

    public int TsId { get; set; }

    public int? TsOrgId { get; set; }

    public string? VtVersion { get; set; }
}
