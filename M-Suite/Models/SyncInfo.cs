using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class SyncInfo
{
    public int SiId { get; set; }

    public int SiUsId { get; set; }

    public int SiCdIdSyt { get; set; }

    public int SiCdIdSrc { get; set; }

    public string? SiVersionSync { get; set; }

    public DateTime SiDownloadDate { get; set; }

    public DateTime? SiUploadDate { get; set; }

    public short? SiUploadFlag { get; set; }

    public DateTime? SiMergeDate { get; set; }

    public short? SiMergeFlag { get; set; }

    public DateTime? SiExportDate { get; set; }

    public short? SiExportFlag { get; set; }
}
