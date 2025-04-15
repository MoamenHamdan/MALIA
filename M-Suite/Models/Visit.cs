using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class Visit
{
    public int VtId { get; set; }

    public int? VtOrgId { get; set; }

    public int? VtCdIdSrc { get; set; }

    public int? VtCcdId { get; set; }

    public int VtUsId { get; set; }

    public int? VtThpsId { get; set; }

    public DateTime VtTimeIn { get; set; }

    public DateTime VtTimeOut { get; set; }

    public string VtOperation { get; set; } = null!;

    public string? VtRemarks { get; set; }

    public string? VtVersion { get; set; }

    public string? VtLongitude { get; set; }

    public string? VtLatitude { get; set; }

    public short? VtIsScanned { get; set; }

    public short? VtInGeofence { get; set; }

    public string? VtUid { get; set; }

    public string? VtAttribute1 { get; set; }

    public virtual ICollection<Inspection> Inspections { get; set; } = new List<Inspection>();

    public virtual ICollection<NoVisit> NoVisits { get; set; } = new List<NoVisit>();

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();

    public virtual ICollection<SalesassetInventory> SalesassetInventories { get; set; } = new List<SalesassetInventory>();

    public virtual ICollection<ServiceTicket> ServiceTickets { get; set; } = new List<ServiceTicket>();

    public virtual ICollection<Survey2Result> Survey2Results { get; set; } = new List<Survey2Result>();

    public virtual ICollection<SurveyResult> SurveyResults { get; set; } = new List<SurveyResult>();

    public virtual ICollection<ThpsInventory> ThpsInventories { get; set; } = new List<ThpsInventory>();

    public virtual ICollection<TransactionDelivery> TransactionDeliveries { get; set; } = new List<TransactionDelivery>();

    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();

    public virtual ICollection<VisitReason> VisitReasons { get; set; } = new List<VisitReason>();

    public virtual CallCycleDetail? VtCcd { get; set; }

    public virtual Codesc? VtCdIdSrcNavigation { get; set; }

    public virtual ThirdpartySite? VtThps { get; set; }

    public virtual User VtUs { get; set; } = null!;
}
