using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class AppImage
{
    public int ImgId { get; set; }

    public int? ImgOrgId { get; set; }

    public string ImgName { get; set; } = null!;

    public int ImgCdIdImgref { get; set; }

    public int ImgUsId { get; set; }

    public DateTime ImgDatetime { get; set; }

    public string? ImgLatitude { get; set; }

    public string? ImgLongitude { get; set; }

    public int ImgFkValue { get; set; }

    public string? ImgDevicePath { get; set; }

    public string? ImgServerPath { get; set; }

    public int? ImgOrder { get; set; }

    public short? ImgActive { get; set; }

    public string? ImgText1 { get; set; }

    public string? ImgText2 { get; set; }

    public decimal? ImgNum1 { get; set; }

    public decimal? ImgNum2 { get; set; }

    public virtual Codesc ImgCdIdImgrefNavigation { get; set; } = null!;

    public virtual User ImgUs { get; set; } = null!;
}
