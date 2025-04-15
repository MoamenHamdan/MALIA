using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ExpmFmImportsqldatum
{
    public DateTime? TrxDate { get; set; }

    public DateTime? ActDate { get; set; }

    public decimal? TrxNo { get; set; }

    public string? JvRef { get; set; }

    public string? Type { get; set; }

    public string? Batch { get; set; }

    public string? Batchnam { get; set; }

    public string? Acc { get; set; }

    public string? Name { get; set; }

    public string? AuxType { get; set; }

    public string? AuxCode { get; set; }

    public string? AuxName { get; set; }

    public string? Currency { get; set; }

    public string? PrjCode { get; set; }

    public string? PrjName { get; set; }

    public string? BrCode { get; set; }

    public string? BrName { get; set; }

    public string? Label { get; set; }

    public string? Dc { get; set; }

    public decimal? FAmount { get; set; }

    public decimal? FLocal { get; set; }

    public decimal? SLocal { get; set; }

    public string? BnkName { get; set; }

    public string? ChqNo { get; set; }

    public DateTime? Maturity { get; set; }

    public string? DocRef { get; set; }

    public string? Costcode { get; set; }

    public string? Costname { get; set; }

    public string? Subcostcode { get; set; }

    public string? Subcostname { get; set; }

    public decimal? Vat { get; set; }

    public int? Salesman { get; set; }

    public int? Processed { get; set; }

    public int? CmpSeq { get; set; }

    public int? BLineno { get; set; }

    public string? VtBatchNo { get; set; }

    public int? IsSent { get; set; }

    public int? PaId { get; set; }

    public int? ChqRv { get; set; }

    public string? FkChAccountNoPdcbank { get; set; }

    public string? FkAuxbCodePdcbank { get; set; }
}
