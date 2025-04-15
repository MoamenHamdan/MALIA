using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class Target
{
    public int TaId { get; set; }

    public int TaYear { get; set; }

    public DateTime TaCreateDate { get; set; }

    public string TaCode { get; set; } = null!;

    public string TaDescription { get; set; } = null!;

    public int TaUsId { get; set; }

    public int? TaBuId { get; set; }

    public int TaCdIdTrt { get; set; }

    public int? TaCdIdTrc { get; set; }

    public int? TaCdIdCur { get; set; }

    public int? CodCdId3 { get; set; }

    public int? TaCdIdTrs1 { get; set; }

    public int? TaCdIdTrs2 { get; set; }

    public int? TaCdIdTrs3 { get; set; }

    public int? TaCdIdTrs4 { get; set; }

    public int? TaCdIdTrs5 { get; set; }

    public int? TaCdIdTrs6 { get; set; }

    public short? TaActive { get; set; }

    public virtual Codesc? CodCdId3Navigation { get; set; }

    public virtual Codesc? TaCdIdCurNavigation { get; set; }

    public virtual Codesc? TaCdIdTrcNavigation { get; set; }

    public virtual Codesc? TaCdIdTrs1Navigation { get; set; }

    public virtual Codesc? TaCdIdTrs2Navigation { get; set; }

    public virtual Codesc? TaCdIdTrs3Navigation { get; set; }

    public virtual Codesc? TaCdIdTrs4Navigation { get; set; }

    public virtual Codesc? TaCdIdTrs5Navigation { get; set; }

    public virtual Codesc TaCdIdTrtNavigation { get; set; } = null!;

    public virtual ICollection<TargetDetail> TargetDetails { get; set; } = new List<TargetDetail>();
}
