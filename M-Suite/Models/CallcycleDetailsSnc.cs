using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class CallcycleDetailsSnc
{
    public int SCcdId { get; set; }

    public int? SCcdCcId { get; set; }

    public int SCcdSmId { get; set; }

    public int? SCcdCuId { get; set; }

    public int? SCcdVtId { get; set; }

    public DateTime? SCcdDate { get; set; }

    public int? SCcdDateInt { get; set; }

    public int? SCcdSeq { get; set; }

    public int SCcdVisitState { get; set; }

    public int? SCcdDaynb { get; set; }

    public int? SCcdSynched { get; set; }

    public DateTime? SCcdUpdateDate { get; set; }

    public string SCcdVersion { get; set; } = null!;
}
