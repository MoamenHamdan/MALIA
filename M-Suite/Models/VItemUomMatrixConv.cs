using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VItemUomMatrixConv
{
    public int IuxItId { get; set; }

    public int IuxUomIdF { get; set; }

    public string? IuxShortnameF { get; set; }

    public int? IuxConv { get; set; }

    public int IuxUomIdT { get; set; }

    public string? IuxShortnameT { get; set; }

    public int? IuxConvInv { get; set; }
}
