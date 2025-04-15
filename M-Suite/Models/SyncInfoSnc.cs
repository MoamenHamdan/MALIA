using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class SyncInfoSnc
{
    public int SSiId { get; set; }

    public int SSiUsId { get; set; }

    public int SSiCdIdSyt { get; set; }

    public int SSiCdIdSrc { get; set; }

    public string SSiVersionSync { get; set; } = null!;

    public DateTime SSiDownloadDate { get; set; }

    public DateTime? SSiUploadDate { get; set; }

    public short? SSiUploadFlag { get; set; }

    public DateTime? SSiMergeDate { get; set; }

    public short? SSiMergeFlag { get; set; }

    public DateTime? SSiExportDate { get; set; }

    public short? SSiExportFlag { get; set; }

    public int SSiUsIdSync { get; set; }
}
