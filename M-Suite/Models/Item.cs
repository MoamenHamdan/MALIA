using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class Item
{
    public int ItId { get; set; }

    public int? ItItId { get; set; }

    public int ItUomId { get; set; }

    public int ItCdIdItg { get; set; }

    public int? ItCdIdIbd { get; set; }

    public int? ItCdIdIgp { get; set; }

    public int? ItCdIdIsg { get; set; }

    public int? ItCdIdItp { get; set; }

    public string ItCode { get; set; } = null!;

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

    public string? ItImpUid { get; set; }

    public int? ItOrder { get; set; }

    public short? ItIsBadReturn { get; set; }

    public virtual ICollection<Item> InverseItIt { get; set; } = new List<Item>();

    public virtual Item? ItIt { get; set; }

    public virtual Uom ItUom { get; set; } = null!;

    public virtual ICollection<ItemUom> ItemUoms { get; set; } = new List<ItemUom>();
}
