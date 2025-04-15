using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class TransactionStatusSnc
{
    public int STsId { get; set; }

    public int? STsCuId { get; set; }

    public string? STsCustomer { get; set; }

    public string? STsType { get; set; }

    public string? STsDocumentNo { get; set; }

    public DateTime? STsDate { get; set; }

    public string? STsStatus { get; set; }

    public string? STsCustomerPhone { get; set; }

    public string? STsRemark { get; set; }

    public string STsVersion { get; set; } = null!;

    public string STsSmId { get; set; } = null!;
}
