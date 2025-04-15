using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class TransferOrderSnc
{
    public int SToId { get; set; }

    public int? SToBeId { get; set; }

    public int SToCdIdTos { get; set; }

    public int? SToWhId { get; set; }

    public int? SToWhIdFrom { get; set; }

    public int SToCdIdTrs { get; set; }

    public int? SToUsrIdCreated { get; set; }

    public int? SToUsrIdApprove { get; set; }

    public int? SToUsrIdDriver { get; set; }

    public DateTime? SToDate { get; set; }

    public string SToCode { get; set; } = null!;

    public int? SToStatus { get; set; }

    public DateTime? SToApprovalDate { get; set; }

    public int? SToIsExecuted { get; set; }

    public string? SToComment { get; set; }

    public string? SToSignFilename { get; set; }

    public string? SToStatusExp { get; set; }

    public string SToVersion { get; set; } = null!;

    public int? SToSynched { get; set; }

    public string SToSmId { get; set; } = null!;

    public int? SToIsCreated { get; set; }
}
