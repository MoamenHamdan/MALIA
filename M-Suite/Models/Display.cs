using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class Display
{
    public int DspId { get; set; }

    public int? DspOrgId { get; set; }

    public int DspThpsId { get; set; }

    public string DspCode { get; set; } = null!;

    public string DspBarcode { get; set; } = null!;

    public string DspDescription { get; set; } = null!;

    public int? DspCdIdDsptp { get; set; }

    public int? CdId { get; set; }

    public string? DspSize { get; set; }

    public DateTime? DspInstallationDate { get; set; }

    public int? DspCdIdDspsts { get; set; }

    public int DpsUsIdCreated { get; set; }

    public int? DpsUsIdModified { get; set; }

    public DateTime? DpsCreationDate { get; set; }

    public DateTime? DpsUpdateDate { get; set; }
}
