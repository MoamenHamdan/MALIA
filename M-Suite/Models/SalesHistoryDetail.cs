using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class SalesHistoryDetail
{
    public int SohId { get; set; }

    public short SohLineSeq { get; set; }

    public int SohShId { get; set; }

    public int SohPrId { get; set; }

    public string Product { get; set; } = null!;

    public decimal SohUnitQty { get; set; }

    public int SohFree { get; set; }

    public decimal? SohUnitPrice { get; set; }

    public decimal? SohVat { get; set; }

    public decimal? SohDiscountLine { get; set; }

    public string SohRemark { get; set; } = null!;

    public string SohLotNb { get; set; } = null!;

    public int SohPriceChanged { get; set; }

    public string SohText1 { get; set; } = null!;

    public string SohText2 { get; set; } = null!;

    public string SohText3 { get; set; } = null!;

    public int SohIsCreated { get; set; }

    public int SohSynched { get; set; }

    public int SohPnId { get; set; }

    public int SohCdIdRtr { get; set; }

    public int SohPackQty { get; set; }

    public int SohPackPrice { get; set; }

    public string SohVersion { get; set; } = null!;

    public int SohBeId { get; set; }

    public int? SohExpiryDate { get; set; }

    public int? SohProductionDate { get; set; }

    public int? SohPrPrId { get; set; }

    public int? SohPrPrQty { get; set; }

    public int? SohLineId { get; set; }

    public int? SohIsPromo { get; set; }

    public int? SohLineDiscAmt { get; set; }

    public int? SohLineDiscPerc { get; set; }

    public string CurrencyCode { get; set; } = null!;

    public string UomCode { get; set; } = null!;
}
