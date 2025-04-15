using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class SalesDetailsCfrSnc
{
    public int SSodId { get; set; }

    public int? SSodLineSeq { get; set; }

    public int? SSodSoId { get; set; }

    public int? SSodPrId { get; set; }

    public int? SSodCdIdRtr { get; set; }

    public int? SSodUomId { get; set; }

    public decimal? SSodQuantity { get; set; }

    public decimal? SSodQuantitySku { get; set; }

    public decimal? SSodFree { get; set; }

    public decimal? SSodUnitPrice { get; set; }

    public decimal? SSodVat { get; set; }

    public decimal? SSodLineDiscAmt { get; set; }

    public decimal? SSodLineDiscPerc { get; set; }

    public string? SSodLotNb { get; set; }

    public DateTime? SSodProductionDate { get; set; }

    public DateTime? SSodExpiryDate { get; set; }

    public string? SSodRemark { get; set; }

    public int? SSodPriceChanged { get; set; }

    public string? SSodText1 { get; set; }

    public string? SSodText2 { get; set; }

    public string? SSodText3 { get; set; }

    public int? SSodIsCreated { get; set; }

    public string? SSodSynched { get; set; }

    public int? SSodIsPromo { get; set; }

    public string SSodVersion { get; set; } = null!;

    public string SSodSmId { get; set; } = null!;

    public int? SSodDvdId { get; set; }

    public int? SSodSodId { get; set; }

    public int? SSodSalesVersion { get; set; }
}
