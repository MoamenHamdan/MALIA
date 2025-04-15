using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class SurveyQuestion
{
    public int SrqId { get; set; }

    public int SrqSrId { get; set; }

    public int? SrqSrqId { get; set; }

    public int? SrqCdIdAnt { get; set; }

    public int? SrqSaId { get; set; }

    public string SrqCode { get; set; } = null!;

    public string? SrqBarcode { get; set; }

    public string SrqQuestionLan1 { get; set; } = null!;

    public int? SrqIdValue { get; set; }

    public string? SrqIdTable { get; set; }

    public short? SrqActive { get; set; }

    public short? SrqIsRequired { get; set; }

    public short? SrqOrder { get; set; }

    public short? SrqMultipleSelection { get; set; }

    public int? SrqParentSadId { get; set; }

    public string? SrqParentAnswer { get; set; }

    public short? SrqRequireBarcode { get; set; }

    public string? SrqQuestionLan2 { get; set; }

    public string? SrqQuestionLan3 { get; set; }

    public int? SrqItref { get; set; }

    public virtual ICollection<InspectionSurvey> InspectionSurveys { get; set; } = new List<InspectionSurvey>();

    public virtual Codesc? SrqCdIdAntNavigation { get; set; }

    public virtual Surveyanswer? SrqSa { get; set; }

    public virtual Survey SrqSr { get; set; } = null!;

    public virtual ICollection<SurveyResultAnswer> SurveyResultAnswers { get; set; } = new List<SurveyResultAnswer>();
}
