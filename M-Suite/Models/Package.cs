using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class Package
{
    public int PckId { get; set; }

    public int? PckPckId { get; set; }

    public string? PckCode { get; set; }

    public string? PckDescriptionLan1 { get; set; }

    public string? PckDescriptionLan2 { get; set; }

    public string? PckDescriptionLan3 { get; set; }

    public string PckBarcode { get; set; } = null!;

    public int? PckCdIdPckt { get; set; }

    public decimal? PckWidth { get; set; }

    public decimal? PckHeight { get; set; }

    public decimal? PckDepth { get; set; }

    public decimal? PckArea { get; set; }

    public decimal? PckVolume { get; set; }

    public decimal? PckWeight { get; set; }

    public int PckUsIdCr { get; set; }

    public DateTime PckCreationDate { get; set; }

    public int? PckUsIdUp { get; set; }

    public DateTime? PckUpdateDate { get; set; }

    public virtual ICollection<OperationPackaging> OperationPackagings { get; set; } = new List<OperationPackaging>();
}
