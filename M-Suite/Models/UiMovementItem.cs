using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class UiMovementItem
{
    public int UmviId { get; set; }

    public int UmviMvtId { get; set; }

    public int? UmviMssId { get; set; }

    public short? UmviMviId { get; set; }

    public short? UmviMviOrgId { get; set; }

    public short? UmviMviMvOrgId { get; set; }

    public short? UmviMviMvId { get; set; }

    public short? UmviMviItId { get; set; }

    public short? UmviMviMviId { get; set; }

    public short? UmviMviMvtoId { get; set; }

    public short? UmviMviUomId { get; set; }

    public short? UmviMviPlIdWhs { get; set; }

    public short? UmviMviLineSequence { get; set; }

    public short? UmviMviQuantity { get; set; }

    public short? UmviMviQuantity2 { get; set; }

    public short? UmviMviPrice { get; set; }

    public short? UmviMviDiscountPercentage { get; set; }

    public short? UmviMviDiscountAmount { get; set; }

    public short? UmviMviRemarks { get; set; }

    public short? UmviMviTotalAmount { get; set; }

    public short? UmviMviTotalDiscount { get; set; }

    public short? UmviMviTotalTax { get; set; }

    public short? UmviMviTotalAmountBc { get; set; }

    public short? UmviMviTotalDiscountBc { get; set; }

    public short? UmviMviTotalTaxBc { get; set; }

    public short? UmviBtnDelete { get; set; }

    public short? UmviBtnDetails { get; set; }

    public short? UmviBtnAddSimilar { get; set; }

    public virtual Movementstatus? UmviMss { get; set; }

    public virtual Movementtype1 UmviMvt { get; set; } = null!;
}
