using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class SalesDetailsHistory
{
    public int SohId { get; set; }

    public int? SohLineSeq { get; set; }

    public int SohShId { get; set; }

    public int? SohPrId { get; set; }

    public decimal SohUnitQty { get; set; }

    public decimal? SohFree { get; set; }

    public decimal? SohUnitPrice { get; set; }

    public decimal? SohVat { get; set; }

    public decimal? SohDiscountLine { get; set; }

    public string? SohRemark { get; set; }

    public string? SohLotNb { get; set; }

    public short? SohPriceChanged { get; set; }

    public string? SohText1 { get; set; }

    public string? SohText2 { get; set; }

    public string? SohText3 { get; set; }

    public short? SohIsCreated { get; set; }

    public string? SohSynched { get; set; }

    public int? SohPnId { get; set; }

    public int? SohCdIdRtr { get; set; }

    public decimal? SohPackQty { get; set; }

    public decimal? SohPackPrice { get; set; }

    public string? SohVersion { get; set; }

    public int? SohBeId { get; set; }

    public DateTime? SohExpiryDate { get; set; }

    public DateTime? SohProductionDate { get; set; }

    public int? SohPrPrId { get; set; }

    public decimal? SohPrPrQty { get; set; }

    public long? SohLineId { get; set; }

    public int? SohIsPromo { get; set; }

    public decimal? SohLineDiscAmt { get; set; }

    public decimal? SohLineDiscPerc { get; set; }
}
