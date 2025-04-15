using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class Survey
{
    public int SrId { get; set; }

    public int? SrBuId { get; set; }

    public int? SrCdIdSrt { get; set; }

    public int? SrCdIdSra { get; set; }

    public string SrCode { get; set; } = null!;

    public string SrNameLan1 { get; set; } = null!;

    public string? SrNameLan2 { get; set; }

    public string? SrNameLan3 { get; set; }

    public string? SrDescriptionLan1 { get; set; }

    public string? SrDescriptionLan2 { get; set; }

    public string? SrDescriptionLan3 { get; set; }

    public short? SrReadBarcode { get; set; }

    public short? SrActive { get; set; }

    public short? SrAllUsers { get; set; }

    public short? SrMandatory { get; set; }

    public DateTime? SrFromDate { get; set; }

    public DateTime? SrToDate { get; set; }

    public virtual ICollection<InspectionList> InspectionLists { get; set; } = new List<InspectionList>();

    public virtual BusinessUnit? SrBu { get; set; }

    public virtual Codesc? SrCdIdSraNavigation { get; set; }

    public virtual Codesc? SrCdIdSrtNavigation { get; set; }

    public virtual ICollection<SurveyQuestion> SurveyQuestions { get; set; } = new List<SurveyQuestion>();

    public virtual ICollection<SurveyResult> SurveyResults { get; set; } = new List<SurveyResult>();

    public virtual ICollection<SurveyThirdparty> SurveyThirdparties { get; set; } = new List<SurveyThirdparty>();

    public virtual ICollection<SurveyUser> SurveyUsers { get; set; } = new List<SurveyUser>();
}
