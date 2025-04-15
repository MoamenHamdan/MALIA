using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ReconciliationDetailSnc
{
    public int SRcdId { get; set; }

    public int SRcdRcId { get; set; }

    public int SRcdCdIdRct { get; set; }

    public int SRcdPrId { get; set; }

    public decimal? SRcdUnitPerPack { get; set; }

    public decimal? SRcdPerpQty { get; set; }

    public decimal? SRcdTotalUnit { get; set; }

    public decimal? SRcdUnitsQty { get; set; }

    public decimal? SRcdPackQty { get; set; }

    public decimal? SRcdVariance { get; set; }

    public short? SRcdSynched { get; set; }

    public int SRcdSmId { get; set; }

    public string SRcdVersion { get; set; } = null!;

    public string? SRcdLotNb { get; set; }

    public DateTime? SRcdExpiryDate { get; set; }

    public DateTime? SRcdProductionDate { get; set; }

    public string? SRcdRcUid { get; set; }
}
