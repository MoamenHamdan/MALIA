using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class MovementType
{
    public int MvtId { get; set; }

    public int? MvtCdIdTpt { get; set; }

    public int? MvtCdIdMod { get; set; }

    public string? MvtCode { get; set; }

    public string? MvtDescriptionLan1 { get; set; }

    public string? MvtDescriptionLan2 { get; set; }

    public string? MvtDescriptionLan3 { get; set; }

    public string? MvtNameLan1 { get; set; }

    public string? MvtNameLan2 { get; set; }

    public string? MvtNameLan3 { get; set; }

    public string? MvtNotes { get; set; }

    public short MvtUpdateQuantityFrom { get; set; }

    public short MvtUpdateQuantityTo { get; set; }

    public short MvtCheckAvailability { get; set; }

    public short? MvtMvtIdSource { get; set; }

    public short? MvtAutoSequence { get; set; }

    public short? MvtManageSerial { get; set; }

    public short? MvtShowPrice { get; set; }

    public short MvtAllowPriceChange { get; set; }

    public short MvtAllowDiscountAmountChange { get; set; }

    public short MvtAllowDiscountChange { get; set; }

    public string? MvtPrintingCode { get; set; }

    public short? MvtCheckCreditLimit { get; set; }

    public short? MvtPrintCopies { get; set; }

    public string? MvtStatusFcCode { get; set; }

    public short? MvtDqIdWhsSelection { get; set; }

    public int? MvtDqUomSelection { get; set; }

    public int? MvtDqItemSelection { get; set; }

    public short? MvtApplyConstraints { get; set; }

    public short? MvtUpdateCost { get; set; }

    public short? MvtAccountingPost { get; set; }
}
