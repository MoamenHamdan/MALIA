using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class SalesDetailsSnc
{
    public int SSodId { get; set; }

    public int? SSodLineSeq { get; set; }

    public int SSodSoId { get; set; }

    public int? SSodPrId { get; set; }

    public decimal SSodUnitQty { get; set; }

    public string? SSodFree { get; set; }

    public decimal? SSodUnitPrice { get; set; }

    public decimal? SSodVat { get; set; }

    public string? SSodDiscountLine { get; set; }

    public string? SSodRemark { get; set; }

    public string? SSodLotNb { get; set; }

    public string? SSodExpiryDate { get; set; }

    public short? SSodPriceChanged { get; set; }

    public string? SSodText1 { get; set; }

    public string? SSodText2 { get; set; }

    public string? SSodText3 { get; set; }

    public short? SSodIsCreated { get; set; }

    public string? SSodSynched { get; set; }

    public string SSodVersion { get; set; } = null!;

    public int SSodSmId { get; set; }

    public int? SSodPnId { get; set; }

    public int? SSodCdIdRtr { get; set; }

    public decimal? SSodPackQty { get; set; }

    public decimal? SSodPackPrice { get; set; }

    public int? SSodIsPromo { get; set; }

    public decimal? SSodLineDiscAmt { get; set; }

    public decimal? SSodLineDiscPerc { get; set; }

    public DateTime? SSodProductionDate { get; set; }

    public string? SSodFreeComment { get; set; }

    public int? SSodCdIdFrc { get; set; }

    public decimal? SSodDiscountAmountLine { get; set; }

    public string? SSodSoUid { get; set; }
}
