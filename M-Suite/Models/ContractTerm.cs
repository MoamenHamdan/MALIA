using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ContractTerm
{
    public int CntId { get; set; }

    public int CntCnId { get; set; }

    public int CntCdIdCtv { get; set; }

    public string CntCode { get; set; } = null!;

    public string? CntDescriptionLan1 { get; set; }

    public string? CntDescriptionLan2 { get; set; }

    public string? CntDescriptionLan3 { get; set; }

    public int? CntCntId { get; set; }

    public virtual Codesc CntCdIdCtvNavigation { get; set; } = null!;

    public virtual Contract CntCn { get; set; } = null!;
}
