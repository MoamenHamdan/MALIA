using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class DeliverySnc
{
    public int SDvId { get; set; }

    public int? SDvVtId { get; set; }

    public int SDvCuId { get; set; }

    public string? SDvDate { get; set; }

    public string SDvCode { get; set; } = null!;

    public short SDvState { get; set; }

    public string? SDvRemarks { get; set; }

    public string? SDvSignFilename { get; set; }

    public short? SDvVoided { get; set; }

    public short? SDvIsCreated { get; set; }

    public short? SDvSynched { get; set; }

    public int? SDvFeId { get; set; }

    public int? SDvSoId { get; set; }

    public string SDvVersion { get; set; } = null!;

    public int? SDvRefid { get; set; }

    public int SDvSmId { get; set; }

    public string? SDvVtUid { get; set; }

    public string? SDvSoUid { get; set; }
}
