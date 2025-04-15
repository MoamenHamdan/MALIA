using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VQlkItem
{
    public int ItId { get; set; }

    public int? ItItId { get; set; }

    public int ItUomId { get; set; }

    public string ItCode { get; set; } = null!;

    public string Item { get; set; } = null!;

    public string ItDescriptionLan1 { get; set; } = null!;

    public string? ItDescriptionLan2 { get; set; }

    public string? ItDescriptionLan3 { get; set; }

    public decimal? ItWeight { get; set; }

    public short ItHasLot { get; set; }

    public short ItHasProductionDate { get; set; }

    public short ItHasExpiryDate { get; set; }

    public short? ItHasMultipleUom { get; set; }

    public short? ItHasSerial { get; set; }

    public short? ItIsDescription { get; set; }

    public short? ItIsSaleable { get; set; }

    public short? ItIsService { get; set; }

    public short? ItIsAsset { get; set; }

    public short ItActive { get; set; }
}
