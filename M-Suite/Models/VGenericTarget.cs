using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VGenericTarget
{
    public int VgtId { get; set; }

    public int VgtTaYear { get; set; }

    public DateTime VgtTaCreateDate { get; set; }

    public string VgtTaCode { get; set; } = null!;

    public string VgtTaDescription { get; set; } = null!;

    public int VgtTaUsId { get; set; }

    public int? VgtTaBuId { get; set; }

    public int VgtTaCdIdTrt { get; set; }

    public int? VgtTaCdIdTrc { get; set; }

    public int? VgtTaCdIdCur { get; set; }

    public int? VgtCodCdId3 { get; set; }

    public int? VgtTaCdIdTrs1 { get; set; }

    public int? VgtTaCdIdTrs2 { get; set; }

    public int? VgtTaCdIdTrs3 { get; set; }

    public int? VgtTaCdIdTrs4 { get; set; }

    public int? VgtTaCdIdTrs5 { get; set; }

    public int? VgtTaCdIdTrs6 { get; set; }

    public short? VgtTaActive { get; set; }

    public int VgtTdId { get; set; }

    public int VgtTdTaId { get; set; }

    public int? VgtTdGlId { get; set; }

    public int? VgtTdItId { get; set; }

    public int? VgtTdCdIdIbd { get; set; }

    public int? VgtTdCdIdIgp { get; set; }

    public int? VgtTdUsId { get; set; }

    public int? VgtTdThpsId { get; set; }

    public decimal? VgtTdJan { get; set; }

    public decimal? VgtTdFeb { get; set; }

    public decimal? VgtTdMar { get; set; }

    public decimal? VgtTdApr { get; set; }

    public decimal? VgtTdMai { get; set; }

    public decimal? VgtTdJun { get; set; }

    public decimal? VgtTdJul { get; set; }

    public decimal? VgtTdAug { get; set; }

    public decimal? VgtTdSep { get; set; }

    public decimal? VgtTdOct { get; set; }

    public decimal? VgtTdNov { get; set; }

    public decimal? VgtTdDec { get; set; }

    public decimal? VgtTdTotal { get; set; }

    public string? VgtLevel1Code { get; set; }

    public string? VgtLevel2Code { get; set; }

    public string? VgtLevel3Code { get; set; }

    public string? VgtLevel1Description { get; set; }

    public string? VgtLevel2Description { get; set; }

    public string? VgtLevel3Description { get; set; }

    public string? VgtLevel1TitleDescription { get; set; }

    public string? VgtLevel2TitleDescription { get; set; }

    public string? VgtLevel3TitleDescription { get; set; }

    public string? VgtTypeCode { get; set; }

    public string? VgtTypeDescription { get; set; }

    public string? VgtTrcCode { get; set; }

    public string? VgtTrcDescription { get; set; }

    public string? VgtGeoLocation { get; set; }

    public string? VgtItem { get; set; }

    public string? VgtItemBrand { get; set; }

    public string? VgtItemGroup { get; set; }

    public string? VgtCustomer { get; set; }

    public string? VgtSalesrep { get; set; }

    public int? VgtLevel1Id { get; set; }

    public int? VgtLevel2Id { get; set; }

    public int? VgtLevel3Id { get; set; }

    public decimal? VgtTdJanAchieved { get; set; }

    public decimal? VgtTdFebAchieved { get; set; }

    public decimal? VgtTdMarAchieved { get; set; }

    public decimal? VgtTdAprAchieved { get; set; }

    public decimal? VgtTdMayAchieved { get; set; }

    public decimal? VgtTdJunAchieved { get; set; }

    public decimal? VgtTdJulAchieved { get; set; }

    public decimal? VgtTdAugAchieved { get; set; }

    public decimal? VgtTdSepAchieved { get; set; }

    public decimal? VgtTdOctAchieved { get; set; }

    public decimal? VgtTdNovAchieved { get; set; }

    public decimal? VgtTdDecAchieved { get; set; }

    public decimal? VgtTdTotalAchieved { get; set; }
}
