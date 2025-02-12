using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class PaymentSnc
{
    public int SPaId { get; set; }

    public int SPaVtId { get; set; }

    public int? SPaFeId { get; set; }

    public string SPaDate { get; set; } = null!;

    public string SPaDocNo { get; set; } = null!;

    public string? SPaTotalAmount { get; set; }

    public int SPaCdIdCur { get; set; }

    public int? SPaSoId { get; set; }

    public string SPaCurSymb { get; set; } = null!;

    public string? SPaRoundAmt { get; set; }

    public short SPaVoided { get; set; }

    public string? SPaSignFilename { get; set; }

    public short? SPaIsCreated { get; set; }

    public short? SPaSynched { get; set; }

    public string SPaVersion { get; set; } = null!;

    public int SPaSmId { get; set; }

    public int? SPaYyyy { get; set; }

    public int? SPaYyyymm { get; set; }

    public string? SPaVtUid { get; set; }

    public string? SPaUid { get; set; }
}
