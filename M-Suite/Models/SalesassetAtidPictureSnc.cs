using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class SalesassetAtidPictureSnc
{
    public int SAtidpId { get; set; }

    public int SAtidpAtidId { get; set; }

    public int SAtidpSmId { get; set; }

    public string SAtidpFilename { get; set; } = null!;

    public string SAtidpVersion { get; set; } = null!;
}
