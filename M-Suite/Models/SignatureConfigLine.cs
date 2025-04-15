using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class SignatureConfigLine
{
    public int SgclId { get; set; }

    public int? SgclSgcId { get; set; }

    public string? SgclDefaultLabel { get; set; }

    public string? SgclDefaultDescription { get; set; }

    public string? SgclDefaultSsrc { get; set; }

    public int? SgclDefaultSatisfaction { get; set; }

    public short? SgclWithLabel { get; set; }

    public short? SgclWithDescription { get; set; }

    public short? SgclWithSsrc { get; set; }

    public short? SgclWithSatisfaction { get; set; }

    public short? SgclMandatoryLabel { get; set; }

    public short? SgclMandatoryDescription { get; set; }

    public short? SgclMandatorySatisfaction { get; set; }

    public short? SgclMandatorySsrc { get; set; }

    public short? SgclCanModifyLabel { get; set; }

    public short? SgclCanModifyDescription { get; set; }

    public short? SgclCanModifySsrc { get; set; }

    public short? SgclCanModifySatisfaction { get; set; }

    public short? SgclIsNew { get; set; }

    public short? SgclCanDelete { get; set; }

    public virtual SignatureConfig? SgclSgc { get; set; }
}
