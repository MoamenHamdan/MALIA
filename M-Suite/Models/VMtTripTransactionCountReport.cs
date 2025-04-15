using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VMtTripTransactionCountReport
{
    public string MvNumber { get; set; } = null!;

    public string UsShortName { get; set; } = null!;

    public string? PlCode { get; set; }

    public DateTime TripDate { get; set; }

    public string? DvSerial { get; set; }

    public int? NmOfTransactions { get; set; }

    public DateTime? ReturnDate { get; set; }
}
