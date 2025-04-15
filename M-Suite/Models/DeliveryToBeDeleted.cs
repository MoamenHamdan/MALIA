using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class DeliveryToBeDeleted
{
    public int DvId { get; set; }

    public int? DvVtId { get; set; }

    public int DvCuId { get; set; }

    public string? DvDate { get; set; }

    public string DvCode { get; set; } = null!;

    public int DvState { get; set; }

    public string? DvRemarks { get; set; }

    public string? DvSignFilename { get; set; }

    public int? DvVoided { get; set; }

    public int? DvIsCreated { get; set; }

    public int? DvSynched { get; set; }

    public int? DvFeId { get; set; }

    public int? DvSoId { get; set; }
}
