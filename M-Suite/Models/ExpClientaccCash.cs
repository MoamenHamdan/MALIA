using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ExpClientaccCash
{
    public string? TrxDate { get; set; }

    public string? ActDate { get; set; }

    public string TrxNo { get; set; } = null!;

    public string JvRef { get; set; } = null!;

    public string Type { get; set; } = null!;

    public string Batch { get; set; } = null!;

    public string AccNo { get; set; } = null!;

    public string AuxType { get; set; } = null!;

    public string AuxCode { get; set; } = null!;

    public string? AuxName { get; set; }

    public string? Currency { get; set; }

    public string Dc { get; set; } = null!;

    public string Label { get; set; } = null!;

    public decimal? FAmount { get; set; }

    public decimal? FLocal { get; set; }

    public decimal? SLocal { get; set; }

    public string? BnkName { get; set; }

    public string? ChqNo { get; set; }

    public string? Maturity { get; set; }

    public int? DocRef { get; set; }

    public int? Costcode { get; set; }

    public int? Costname { get; set; }

    public int? Subcostcode { get; set; }

    public int? Subcostname { get; set; }

    public int? Vat { get; set; }

    public string? Salesman { get; set; }

    public int UsId { get; set; }

    public string CmpSeq { get; set; } = null!;

    public string BrCode { get; set; } = null!;

    public DateTime VtTimeIn { get; set; }

    public string? VtVersion { get; set; }

    public int BLineno { get; set; }

    public int PaId { get; set; }

    public int? ChqRv { get; set; }

    public int? FkChAccountNoPdcbank { get; set; }

    public int? FkAuxbCodePdcbank { get; set; }
}
