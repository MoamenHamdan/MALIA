using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class Report
{
    public int RpId { get; set; }

    public string? RpCode { get; set; }

    public string? RpTitle { get; set; }

    public string? RpPreSql { get; set; }

    public string RpTsql { get; set; } = null!;

    public string? RpPostSql { get; set; }

    public short RpActive { get; set; }

    public short? RpSendmail { get; set; }

    public short? RpCompress { get; set; }

    public short? RpIsRequested { get; set; }

    public string? RpFilePassword { get; set; }

    public string? RpSourceFile { get; set; }

    public string? RpDestinationFile { get; set; }

    public string? RpDestinationVirtualPath { get; set; }

    public string? RpTempFile { get; set; }

    public string? RpGroup { get; set; }

    public string? RpExcelSheetName { get; set; }

    public DateTime RpCreateDate { get; set; }

    public DateTime? RpModifiedDate { get; set; }

    public int RpUsIdCreatedby { get; set; }

    public int? RpUsIdModifiedby { get; set; }
}
