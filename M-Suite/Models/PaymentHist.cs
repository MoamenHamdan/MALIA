using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class PaymentHist
{
    public int Pk { get; set; }

    public int? PaBuId { get; set; }

    public string? PhDate { get; set; }

    public string PhDocNo { get; set; } = null!;

    public string? PhTotalAmount { get; set; }

    public int PhCdIdCur { get; set; }

    public string PhCurSymb { get; set; } = null!;

    public decimal PhRoundAmt { get; set; }

    public string PhSignFilename { get; set; } = null!;

    public int? PhSmId { get; set; }

    public int? PhBeId { get; set; }

    public int PhCdIdPat { get; set; }

    public int PhUtId { get; set; }

    public string PhReference { get; set; } = null!;

    public DateTime PhDatetime { get; set; }

    public int? PhCuId { get; set; }
}
