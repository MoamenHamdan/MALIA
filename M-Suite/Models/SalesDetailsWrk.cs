using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class SalesDetailsWrk
{
    public int SodId { get; set; }

    public int? SodLineSeq { get; set; }

    public int SodSoId { get; set; }

    public int? SodFeId { get; set; }

    public int? SodPrId { get; set; }

    public int? SodPbId { get; set; }

    public int? SodGpId { get; set; }

    public int? SodCdIdRtr { get; set; }

    public int? SodUomId { get; set; }

    public int? SodDvdId { get; set; }

    public string? SodPrCode { get; set; }

    public string? SodPrBarcode { get; set; }

    public int? SodCdIdCur { get; set; }

    public string? SodPrDescription { get; set; }

    public string? SodPrDescriptionAr { get; set; }

    public decimal SodQuantity { get; set; }

    public decimal? SodUomSku { get; set; }

    public decimal SodQuantitySku { get; set; }

    public decimal? SodFree { get; set; }

    public decimal? SodUnitPrice { get; set; }

    public decimal? SodVat { get; set; }

    public decimal? SodLineDiscAmt { get; set; }

    public decimal? SodLineDiscPerc { get; set; }

    public decimal? SodLineDiscAmtIni { get; set; }

    public decimal? SodLineDiscPercIni { get; set; }

    public string? SodLotNb { get; set; }

    public DateTime? SodProductionDate { get; set; }

    public DateTime? SodExpiryDate { get; set; }

    public string? SodUomDescription { get; set; }

    public string? SodRemark { get; set; }

    public int? SodPriceChanged { get; set; }

    public string? SodText1 { get; set; }

    public string? SodText2 { get; set; }

    public string? SodText3 { get; set; }

    public int? SodIsCreated { get; set; }

    public string? SodSynched { get; set; }

    public int? SodIsPromo { get; set; }

    public int? SodWpId { get; set; }

    public string? SodWpUid { get; set; }

    public decimal? SodWpQuantity { get; set; }

    public decimal? SodLineTotal { get; set; }

    public int? SodSodId { get; set; }

    public string? SodVersion { get; set; }
}
