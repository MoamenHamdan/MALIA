using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class Product
{
    public int PrId { get; set; }

    public int? PrGpId { get; set; }

    public int PrFeId { get; set; }

    public int? PrPbId { get; set; }

    public int PrCdIdCur { get; set; }

    public string? PrCode { get; set; }

    public string? PrBarcode { get; set; }

    public string? PrDescription { get; set; }

    public string? PrDescriptionAr { get; set; }

    public decimal? PrDefaultPrice { get; set; }

    public decimal? PrVat { get; set; }

    public decimal? PrDiscount { get; set; }

    public decimal? PrMaxDiscount { get; set; }

    public string? PrText1 { get; set; }

    public string? PrText2 { get; set; }

    public string? PrText3 { get; set; }

    public string? PrText4 { get; set; }

    public string? PrText5 { get; set; }
}
