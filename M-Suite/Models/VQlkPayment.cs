using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VQlkPayment
{
    public int PaId { get; set; }

    public string? PaVtId { get; set; }

    public int? MvId { get; set; }

    public int? PaCdIdSrc { get; set; }

    public int PaCdIdCur { get; set; }

    public int? PaCdIdPat { get; set; }

    public int? PaUsId { get; set; }

    public int? PaBuId { get; set; }

    public int? PaSgdId { get; set; }

    public DateTime PaDate { get; set; }

    public string PaNumber { get; set; } = null!;

    public decimal PaTotalAmount { get; set; }

    public decimal? PaTotalAmountBc { get; set; }

    public decimal? PaRoundAmount { get; set; }

    public short? PaVoid { get; set; }

    public short? PaApproved { get; set; }

    public DateTime? PaCreateDate { get; set; }

    public DateTime? PaModifiedDate { get; set; }

    public int? PaThpsId { get; set; }

    public string? PssCode { get; set; }

    public string? PssDescriptionLan1 { get; set; }

    public string? PssDescriptionLan2 { get; set; }

    public string? PssDescriptionLan3 { get; set; }

    public string? PyCode { get; set; }

    public string? PyDescriptionLan1 { get; set; }

    public string? PyDescriptionLan2 { get; set; }

    public string? PyDescriptionLan3 { get; set; }

    public int? PaYear { get; set; }

    public int? PaMonth { get; set; }

    public int? PaDay { get; set; }

    public int? PaDateNum { get; set; }

    public string? ThpsUsVtBu { get; set; }
}
