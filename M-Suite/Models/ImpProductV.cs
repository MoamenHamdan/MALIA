using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ImpProductV
{
    public int? IItItId { get; set; }

    public int IItUomId { get; set; }

    public string IItCode { get; set; } = null!;

    public string? IItDescriptionLan1 { get; set; }

    public string? IItDescriptionLan2 { get; set; }

    public string? IItDescriptionLan3 { get; set; }

    public int? IItWeight { get; set; }

    public int IItHasLot { get; set; }

    public int IItHasProductionDate { get; set; }

    public int IItHasExpiryDate { get; set; }

    public int IItActive { get; set; }

    public int IItHasMultipleUom { get; set; }

    public int IItHasSerial { get; set; }

    public int IItIsDescription { get; set; }

    public int IItIsSaleable { get; set; }

    public int IItIsService { get; set; }

    public int IItIsAsset { get; set; }

    public int IItCdIdItg { get; set; }

    public int? IItCdIdIbd { get; set; }

    public int? IItCdIdIgp { get; set; }

    public int? IItCdIdIsg { get; set; }

    public int? IItCdIdItp { get; set; }

    public int? IItId { get; set; }
}
