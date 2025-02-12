using System;
using System.Collections.Generic;
using M_Suite.Models;
using Microsoft.EntityFrameworkCore;

namespace M_Suite.Context;

public partial class MaliaContext : DbContext
{
    public MaliaContext()
    {
    }

    public MaliaContext(DbContextOptions<MaliaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<BusinessUnit> BusinessUnits { get; set; }

    public virtual DbSet<CallCycle> CallCycles { get; set; }

    public virtual DbSet<Company> Companies { get; set; }

    public virtual DbSet<CustomProperty> CustomProperties { get; set; }

    public virtual DbSet<CustomerSnc> CustomerSncs { get; set; }

    public virtual DbSet<Display> Displays { get; set; }

    public virtual DbSet<GeoLocation> GeoLocations { get; set; }

    public virtual DbSet<Inventory> Inventories { get; set; }

    public virtual DbSet<InventorySnc> InventorySncs { get; set; }

    public virtual DbSet<Item> Items { get; set; }

    public virtual DbSet<ItemList> ItemLists { get; set; }

    public virtual DbSet<ItemUom> ItemUoms { get; set; }

    public virtual DbSet<Menu> Menus { get; set; }

    public virtual DbSet<MenuPage> MenuPages { get; set; }

    public virtual DbSet<Payment> Payments { get; set; }

    public virtual DbSet<PaymentSnc> PaymentSncs { get; set; }

    public virtual DbSet<Profile> Profiles { get; set; }

    public virtual DbSet<Report> Reports { get; set; }

    public virtual DbSet<Models.Route> Routes { get; set; }

    public virtual DbSet<SalesSnc> SalesSncs { get; set; }

    public virtual DbSet<Transaction> Transactions { get; set; }

    public virtual DbSet<TransferSnc> TransferSncs { get; set; }

    public virtual DbSet<Uom> Uoms { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserProfile> UserProfiles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BusinessUnit>(entity =>
        {
            entity.HasKey(e => e.BuId)
                .HasName("PK_BUSINESS_ENTITY")
                .HasFillFactor(90);

            entity.ToTable("BUSINESS_UNIT", "cmn");

            entity.Property(e => e.BuId).HasColumnName("bu_id");
            entity.Property(e => e.BuBuId).HasColumnName("bu_bu_id");
            entity.Property(e => e.BuCode)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("bu_code");
            entity.Property(e => e.BuCpId).HasColumnName("bu_cp_id");
            entity.Property(e => e.BuDescriptionLan1)
                .HasMaxLength(100)
                .HasColumnName("bu_description_lan1");
            entity.Property(e => e.BuDescriptionLan2)
                .HasMaxLength(100)
                .HasColumnName("bu_description_lan2");
            entity.Property(e => e.BuDescriptionLan3)
                .HasMaxLength(100)
                .HasColumnName("bu_description_lan3");
            entity.Property(e => e.BuImpUid)
                .HasMaxLength(64)
                .HasColumnName("bu_imp_uid");
            entity.Property(e => e.BuLeId)
                .HasMaxLength(32)
                .HasColumnName("bu_le_id");
            entity.Property(e => e.BuOrgCode)
                .HasMaxLength(64)
                .HasColumnName("bu_org_code");
            entity.Property(e => e.BuOuId)
                .HasMaxLength(32)
                .HasColumnName("bu_ou_id");
            entity.Property(e => e.BuPath)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("bu_path");
            entity.Property(e => e.BuPrefix)
                .HasMaxLength(32)
                .HasColumnName("bu_prefix");

            entity.HasOne(d => d.BuBu).WithMany(p => p.InverseBuBu)
                .HasForeignKey(d => d.BuBuId)
                .HasConstraintName("FK_BU_REF_BU");

            entity.HasOne(d => d.BuCp).WithMany(p => p.BusinessUnits)
                .HasForeignKey(d => d.BuCpId)
                .HasConstraintName("FK_BUSINESS_REFERENCE_COMPANY");
        });

        modelBuilder.Entity<CallCycle>(entity =>
        {
            entity.HasKey(e => e.CcId).HasFillFactor(90);

            entity.ToTable("CALL_CYCLE", "cmn");

            entity.Property(e => e.CcId).HasColumnName("cc_id");
            entity.Property(e => e.CcActive).HasColumnName("cc_active");
            entity.Property(e => e.CcAutorenew).HasColumnName("cc_autorenew");
            entity.Property(e => e.CcCdIdCyt).HasColumnName("cc_cd_id_cyt");
            entity.Property(e => e.CcCycleLength).HasColumnName("cc_cycle_length");
            entity.Property(e => e.CcDescription)
                .HasMaxLength(200)
                .HasColumnName("cc_description");
            entity.Property(e => e.CcFromDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("cc_from_date");
            entity.Property(e => e.CcToDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("cc_to_date");
            entity.Property(e => e.CcUsId).HasColumnName("cc_us_id");
            entity.Property(e => e.CcWorkdays)
                .HasMaxLength(20)
                .HasColumnName("cc_workdays");

            entity.HasOne(d => d.CcUs).WithMany(p => p.CallCycles)
                .HasForeignKey(d => d.CcUsId)
                .HasConstraintName("FK_CC_REF_US");
        });

        modelBuilder.Entity<Company>(entity =>
        {
            entity.HasKey(e => e.CpId).HasFillFactor(90);

            entity.ToTable("COMPANY", "cmn");

            entity.Property(e => e.CpId).HasColumnName("cp_id");
            entity.Property(e => e.CpAddress)
                .HasMaxLength(20)
                .HasColumnName("cp_address");
            entity.Property(e => e.CpContactPerson)
                .HasMaxLength(50)
                .HasColumnName("cp_contact_person");
            entity.Property(e => e.CpEmail)
                .HasMaxLength(50)
                .HasColumnName("cp_email");
            entity.Property(e => e.CpLogo)
                .HasMaxLength(255)
                .HasColumnName("cp_logo");
            entity.Property(e => e.CpNameLan1)
                .HasMaxLength(100)
                .HasColumnName("cp_name_lan1");
            entity.Property(e => e.CpNameLan2)
                .HasMaxLength(100)
                .HasColumnName("cp_name_lan2");
            entity.Property(e => e.CpNameLan3)
                .HasMaxLength(100)
                .HasColumnName("cp_name_lan3");
            entity.Property(e => e.CpPhone)
                .HasMaxLength(20)
                .HasColumnName("cp_phone");
            entity.Property(e => e.CpPrintableName)
                .HasMaxLength(100)
                .HasColumnName("cp_printable_name");
            entity.Property(e => e.CpRegistryNo)
                .HasMaxLength(20)
                .HasColumnName("cp_registry_no");
            entity.Property(e => e.CpWebsite)
                .HasMaxLength(60)
                .HasColumnName("cp_website");
        });

        modelBuilder.Entity<CustomProperty>(entity =>
        {
            entity.HasKey(e => e.CprId).HasFillFactor(90);

            entity.ToTable("CUSTOM_PROPERTY", "cmn");

            entity.Property(e => e.CprId).HasColumnName("cpr_id");
            entity.Property(e => e.CprBuId).HasColumnName("cpr_bu_id");
            entity.Property(e => e.CprCdIdMod).HasColumnName("cpr_cd_id_mod");
            entity.Property(e => e.CprCdIdPrt).HasColumnName("cpr_cd_id_prt");
            entity.Property(e => e.CprCdIdPvt).HasColumnName("cpr_cd_id_pvt");
            entity.Property(e => e.CprCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cpr_code");
        });

        modelBuilder.Entity<CustomerSnc>(entity =>
        {
            entity.HasKey(e => new { e.SCuId, e.SCuSmId, e.SCuVersion }).HasFillFactor(90);

            entity.ToTable("CUSTOMER_SNC", "syn");

            entity.Property(e => e.SCuId).HasColumnName("s_cu_id");
            entity.Property(e => e.SCuSmId).HasColumnName("s_cu_sm_id");
            entity.Property(e => e.SCuVersion)
                .HasMaxLength(25)
                .HasColumnName("s_cu_version");
            entity.Property(e => e.SCuActive).HasColumnName("s_cu_active");
            entity.Property(e => e.SCuBarcode)
                .HasMaxLength(32)
                .HasColumnName("s_cu_barcode");
            entity.Property(e => e.SCuCdIdCcg).HasColumnName("s_cu_cd_id_ccg");
            entity.Property(e => e.SCuCdIdCgq).HasColumnName("s_cu_cd_id_cgq");
            entity.Property(e => e.SCuCdIdDay).HasColumnName("s_cu_cd_id_day");
            entity.Property(e => e.SCuCode)
                .HasMaxLength(32)
                .HasColumnName("s_cu_code");
            entity.Property(e => e.SCuContactName)
                .HasMaxLength(100)
                .HasColumnName("s_cu_contact_name");
            entity.Property(e => e.SCuContactNameAr)
                .HasMaxLength(100)
                .HasColumnName("s_cu_contact_name_ar");
            entity.Property(e => e.SCuDesiredTime)
                .HasMaxLength(64)
                .HasColumnName("s_cu_desired_time");
            entity.Property(e => e.SCuExpectedDlvDate).HasColumnName("s_cu_expected_dlv_date");
            entity.Property(e => e.SCuFirstName)
                .HasMaxLength(64)
                .HasColumnName("s_cu_first_name");
            entity.Property(e => e.SCuGeId).HasColumnName("s_cu_ge_id");
            entity.Property(e => e.SCuIsCreated).HasColumnName("s_cu_is_created");
            entity.Property(e => e.SCuIsModified).HasColumnName("s_cu_is_modified");
            entity.Property(e => e.SCuLastName)
                .HasMaxLength(64)
                .HasColumnName("s_cu_last_name");
            entity.Property(e => e.SCuMiddleName)
                .HasMaxLength(64)
                .HasColumnName("s_cu_middle_name");
            entity.Property(e => e.SCuName)
                .HasMaxLength(100)
                .HasColumnName("s_cu_name");
            entity.Property(e => e.SCuNameAr)
                .HasMaxLength(100)
                .HasColumnName("s_cu_name_ar");
            entity.Property(e => e.SCuRefId)
                .HasMaxLength(250)
                .HasColumnName("s_cu_ref_id");
            entity.Property(e => e.SCuText)
                .HasMaxLength(255)
                .HasColumnName("s_cu_text");
            entity.Property(e => e.SCuText1)
                .HasMaxLength(250)
                .HasColumnName("s_cu_text1");
            entity.Property(e => e.SCuText2)
                .HasMaxLength(250)
                .HasColumnName("s_cu_text2");
            entity.Property(e => e.SCuText3)
                .HasMaxLength(250)
                .HasColumnName("s_cu_text3");
            entity.Property(e => e.SCuUid)
                .HasMaxLength(128)
                .HasColumnName("s_cu_uid");
        });

        modelBuilder.Entity<Display>(entity =>
        {
            entity.HasKey(e => e.DspId).HasFillFactor(90);

            entity.ToTable("DISPLAY", "cmn");

            entity.Property(e => e.DspId)
                .ValueGeneratedNever()
                .HasColumnName("dsp_id");
            entity.Property(e => e.CdId).HasColumnName("cd_id");
            entity.Property(e => e.DpsCreationDate)
                .HasColumnType("datetime")
                .HasColumnName("dps_creation_date");
            entity.Property(e => e.DpsUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("dps_update_date");
            entity.Property(e => e.DpsUsIdCreated).HasColumnName("dps_us_id_created");
            entity.Property(e => e.DpsUsIdModified).HasColumnName("dps_us_id_modified");
            entity.Property(e => e.DspBarcode)
                .HasMaxLength(32)
                .HasColumnName("dsp_barcode");
            entity.Property(e => e.DspCdIdDspsts).HasColumnName("dsp_cd_id_dspsts");
            entity.Property(e => e.DspCdIdDsptp).HasColumnName("dsp_cd_id_dsptp");
            entity.Property(e => e.DspCode)
                .HasMaxLength(32)
                .HasColumnName("dsp_code");
            entity.Property(e => e.DspDescription)
                .HasMaxLength(255)
                .HasColumnName("dsp_description");
            entity.Property(e => e.DspInstallationDate)
                .HasColumnType("datetime")
                .HasColumnName("dsp_installation_date");
            entity.Property(e => e.DspOrgId).HasColumnName("dsp_org_id");
            entity.Property(e => e.DspSize)
                .HasMaxLength(64)
                .HasColumnName("dsp_size");
            entity.Property(e => e.DspThpsId).HasColumnName("dsp_thps_id");
        });

        modelBuilder.Entity<GeoLocation>(entity =>
        {
            entity.HasKey(e => e.GlId).HasFillFactor(90);

            entity.ToTable("GEO_LOCATION", "cmn");

            entity.Property(e => e.GlId).HasColumnName("gl_id");
            entity.Property(e => e.GlCdIdGeo).HasColumnName("gl_cd_id_geo");
            entity.Property(e => e.GlCode)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("gl_code");
            entity.Property(e => e.GlDescriptionLan1)
                .HasMaxLength(255)
                .HasColumnName("gl_description_lan1");
            entity.Property(e => e.GlDescriptionLan2)
                .HasMaxLength(255)
                .HasColumnName("gl_description_lan2");
            entity.Property(e => e.GlDescriptionLan3)
                .HasMaxLength(255)
                .HasColumnName("gl_description_lan3");
            entity.Property(e => e.GlGlId).HasColumnName("gl_gl_id");
            entity.Property(e => e.GlLevel).HasColumnName("gl_level");
        });

        modelBuilder.Entity<Inventory>(entity =>
        {
            entity.HasKey(e => e.IvId).HasFillFactor(90);

            entity.ToTable("INVENTORY", "whs");

            entity.Property(e => e.IvId).HasColumnName("iv_id");
            entity.Property(e => e.IvActive)
                .HasDefaultValue((short)1)
                .HasColumnName("iv_active");
            entity.Property(e => e.IvCdIdIvs).HasColumnName("iv_cd_id_ivs");
            entity.Property(e => e.IvCode)
                .HasMaxLength(32)
                .HasColumnName("iv_code");
            entity.Property(e => e.IvCreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("iv_create_date");
            entity.Property(e => e.IvDate)
                .HasColumnType("datetime")
                .HasColumnName("iv_date");
            entity.Property(e => e.IvDateEnd)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("iv_date_end");
            entity.Property(e => e.IvDateStart)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("iv_date_start");
            entity.Property(e => e.IvIvhId).HasColumnName("iv_ivh_id");
            entity.Property(e => e.IvModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("iv_modified_date");
            entity.Property(e => e.IvOrgId).HasColumnName("iv_org_id");
            entity.Property(e => e.IvRemarks)
                .HasMaxLength(4000)
                .HasColumnName("iv_remarks");
            entity.Property(e => e.IvUsId).HasColumnName("iv_us_id");

            entity.HasOne(d => d.IvUs).WithMany(p => p.Inventories)
                .HasForeignKey(d => d.IvUsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IVL_REF_US");
        });

        modelBuilder.Entity<InventorySnc>(entity =>
        {
            entity.HasKey(e => new { e.SIvId, e.SIvSmId, e.SIvVersion }).HasFillFactor(90);

            entity.ToTable("INVENTORY_SNC", "syn");

            entity.Property(e => e.SIvId).HasColumnName("s_iv_id");
            entity.Property(e => e.SIvSmId).HasColumnName("s_iv_sm_id");
            entity.Property(e => e.SIvVersion)
                .HasMaxLength(25)
                .HasColumnName("s_iv_version");
            entity.Property(e => e.SIvCode)
                .HasMaxLength(32)
                .HasColumnName("s_iv_code");
            entity.Property(e => e.SIvCuId).HasColumnName("s_iv_cu_id");
            entity.Property(e => e.SIvDate)
                .HasColumnType("datetime")
                .HasColumnName("s_iv_date");
            entity.Property(e => e.SIvDescription)
                .HasMaxLength(255)
                .HasColumnName("s_iv_description");
            entity.Property(e => e.SIvRivId).HasColumnName("s_iv_riv_id");
            entity.Property(e => e.SIvUid)
                .HasMaxLength(128)
                .HasColumnName("s_iv_uid");
            entity.Property(e => e.SIvVtId).HasColumnName("s_iv_vt_id");
            entity.Property(e => e.SIvVtUid)
                .HasMaxLength(128)
                .HasColumnName("s_iv_vt_uid");
        });

        modelBuilder.Entity<Item>(entity =>
        {
            entity.HasKey(e => e.ItId)
                .HasName("PK_PRODUCT")
                .HasFillFactor(90);

            entity.ToTable("ITEM", "cmn");

            entity.Property(e => e.ItId).HasColumnName("it_id");
            entity.Property(e => e.ItActive)
                .HasDefaultValue((short)1)
                .HasColumnName("it_active");
            entity.Property(e => e.ItCdIdIbd).HasColumnName("it_cd_id_ibd");
            entity.Property(e => e.ItCdIdIgp).HasColumnName("it_cd_id_igp");
            entity.Property(e => e.ItCdIdIsg).HasColumnName("it_cd_id_isg");
            entity.Property(e => e.ItCdIdItg).HasColumnName("it_cd_id_itg");
            entity.Property(e => e.ItCdIdItp).HasColumnName("it_cd_id_itp");
            entity.Property(e => e.ItCode)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("it_code");
            entity.Property(e => e.ItDescriptionLan1)
                .HasMaxLength(255)
                .HasColumnName("it_description_lan1");
            entity.Property(e => e.ItDescriptionLan2)
                .HasMaxLength(255)
                .HasColumnName("it_description_lan2");
            entity.Property(e => e.ItDescriptionLan3)
                .HasMaxLength(255)
                .HasColumnName("it_description_lan3");
            entity.Property(e => e.ItHasExpiryDate)
                .HasDefaultValue((short)-1)
                .HasColumnName("it_has_expiry_date");
            entity.Property(e => e.ItHasLot)
                .HasDefaultValue((short)-1)
                .HasColumnName("it_has_lot");
            entity.Property(e => e.ItHasMultipleUom).HasColumnName("it_has_multiple_uom");
            entity.Property(e => e.ItHasProductionDate)
                .HasDefaultValue((short)-1)
                .HasColumnName("it_has_production_date");
            entity.Property(e => e.ItHasSerial).HasColumnName("it_has_serial");
            entity.Property(e => e.ItImpUid)
                .HasMaxLength(128)
                .HasColumnName("it_imp_uid");
            entity.Property(e => e.ItIsAsset).HasColumnName("it_is_asset");
            entity.Property(e => e.ItIsBadReturn).HasColumnName("it_is_bad_return");
            entity.Property(e => e.ItIsDescription).HasColumnName("it_is_description");
            entity.Property(e => e.ItIsSaleable).HasColumnName("it_is_saleable");
            entity.Property(e => e.ItIsService).HasColumnName("it_is_service");
            entity.Property(e => e.ItItId).HasColumnName("it_it_id");
            entity.Property(e => e.ItOrder).HasColumnName("it_order");
            entity.Property(e => e.ItUomId).HasColumnName("it_uom_id");
            entity.Property(e => e.ItWeight)
                .HasDefaultValue(1m)
                .HasColumnType("numeric(12, 5)")
                .HasColumnName("it_weight");

            entity.HasOne(d => d.ItIt).WithMany(p => p.InverseItIt)
                .HasForeignKey(d => d.ItItId)
                .HasConstraintName("FK_ITEM_REFERENCE_ITEM");

            entity.HasOne(d => d.ItUom).WithMany(p => p.Items)
                .HasForeignKey(d => d.ItUomId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IT_REF_UOM");
        });

        modelBuilder.Entity<ItemList>(entity =>
        {
            entity.HasKey(e => e.ItlId).HasFillFactor(90);

            entity.ToTable("ITEM_LIST", "sls");

            entity.Property(e => e.ItlId).HasColumnName("itl_id");
            entity.Property(e => e.ItlBuId).HasColumnName("itl_bu_id");
            entity.Property(e => e.ItlCdIdItls).HasColumnName("itl_cd_id_itls");
            entity.Property(e => e.ItlCdIdItlt).HasColumnName("itl_cd_id_itlt");
            entity.Property(e => e.ItlCode)
                .HasMaxLength(32)
                .HasColumnName("itl_code");
            entity.Property(e => e.ItlCreationDate)
                .HasColumnType("datetime")
                .HasColumnName("itl_creation_date");
            entity.Property(e => e.ItlDescriptionLan1)
                .HasMaxLength(255)
                .HasColumnName("itl_description_lan1");
            entity.Property(e => e.ItlDescriptionLan2)
                .HasMaxLength(255)
                .HasColumnName("itl_description_lan2");
            entity.Property(e => e.ItlDescriptionLan3)
                .HasMaxLength(255)
                .HasColumnName("itl_description_lan3");
            entity.Property(e => e.ItlEndDate)
                .HasColumnType("datetime")
                .HasColumnName("itl_end_date");
            entity.Property(e => e.ItlOrgId).HasColumnName("itl_org_id");
            entity.Property(e => e.ItlPrId).HasColumnName("itl_pr_id");
            entity.Property(e => e.ItlStartDate)
                .HasColumnType("datetime")
                .HasColumnName("itl_start_date");
            entity.Property(e => e.ItlThpsId).HasColumnName("itl_thps_id");
            entity.Property(e => e.ItlUsId).HasColumnName("itl_us_id");
            entity.Property(e => e.ItlVtId).HasColumnName("itl_vt_id");
        });

        modelBuilder.Entity<ItemUom>(entity =>
        {
            entity.HasKey(e => e.ItuId).HasFillFactor(90);

            entity.ToTable("ITEM_UOM", "cmn");

            entity.Property(e => e.ItuId).HasColumnName("itu_id");
            entity.Property(e => e.ItuActive).HasColumnName("itu_active");
            entity.Property(e => e.ItuConvValue)
                .HasDefaultValue(1m)
                .HasColumnType("numeric(16, 5)")
                .HasColumnName("itu_conv_value");
            entity.Property(e => e.ItuConvValueIni)
                .HasColumnType("decimal(12, 5)")
                .HasColumnName("itu_conv_value_ini");
            entity.Property(e => e.ItuItId).HasColumnName("itu_it_id");
            entity.Property(e => e.ItuOracleUom)
                .HasMaxLength(64)
                .HasColumnName("itu_oracle_uom");
            entity.Property(e => e.ItuShortname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("itu_shortname");
            entity.Property(e => e.ItuUomId).HasColumnName("itu_uom_id");

            entity.HasOne(d => d.ItuIt).WithMany(p => p.ItemUoms)
                .HasForeignKey(d => d.ItuItId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ITU_REF_IT");

            entity.HasOne(d => d.ItuUom).WithMany(p => p.ItemUoms)
                .HasForeignKey(d => d.ItuUomId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ITU_REF_UOM");
        });

        modelBuilder.Entity<Menu>(entity =>
        {
            entity.HasKey(e => e.MnId).HasFillFactor(90);

            entity.ToTable("MENU", "cmn");

            entity.Property(e => e.MnId).HasColumnName("mn_id");
            entity.Property(e => e.MnActive)
                .HasDefaultValue((short)1)
                .HasColumnName("mn_active");
            entity.Property(e => e.MnCdIdMnu).HasColumnName("mn_cd_id_mnu");
            entity.Property(e => e.MnCode)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("mn_code");
            entity.Property(e => e.MnCommand)
                .HasMaxLength(255)
                .HasColumnName("mn_command");
            entity.Property(e => e.MnDescriptionLan1)
                .HasMaxLength(100)
                .HasColumnName("mn_description_lan1");
            entity.Property(e => e.MnDescriptionLan2)
                .HasMaxLength(100)
                .HasColumnName("mn_description_lan2");
            entity.Property(e => e.MnDescriptionLan3)
                .HasMaxLength(100)
                .HasColumnName("mn_description_lan3");
            entity.Property(e => e.MnIcon)
                .HasMaxLength(255)
                .HasColumnName("mn_icon");
            entity.Property(e => e.MnIsAction)
                .HasDefaultValue((short)-1)
                .HasColumnName("mn_is_action");
            entity.Property(e => e.MnIsFunctionality).HasColumnName("mn_is_functionality");
            entity.Property(e => e.MnIsSystem).HasColumnName("mn_is_system");
            entity.Property(e => e.MnLevel).HasColumnName("mn_level");
            entity.Property(e => e.MnMnId).HasColumnName("mn_mn_id");
            entity.Property(e => e.MnOrder).HasColumnName("mn_order");

            entity.HasOne(d => d.MnMn).WithMany(p => p.InverseMnMn)
                .HasForeignKey(d => d.MnMnId)
                .HasConstraintName("FK_MN_REF_MN");
        });

        modelBuilder.Entity<MenuPage>(entity =>
        {
            entity.HasKey(e => e.MnpId).HasFillFactor(90);

            entity.ToTable("MENU_PAGE", "cmn");

            entity.Property(e => e.MnpId).HasColumnName("mnp_id");
            entity.Property(e => e.MnpMaximized).HasColumnName("mnp_maximized");
            entity.Property(e => e.MnpMnId).HasColumnName("mnp_mn_id");
            entity.Property(e => e.MnpPagePath)
                .HasMaxLength(200)
                .HasColumnName("mnp_page_path");
        });

        modelBuilder.Entity<Payment>(entity =>
        {
            entity.HasKey(e => e.PaId).HasFillFactor(90);

            entity.ToTable("PAYMENT", "sls");

            entity.Property(e => e.PaId).HasColumnName("pa_id");
            entity.Property(e => e.PaApproved).HasColumnName("pa_approved");
            entity.Property(e => e.PaBuId).HasColumnName("pa_bu_id");
            entity.Property(e => e.PaCdIdCur).HasColumnName("pa_cd_id_cur");
            entity.Property(e => e.PaCdIdPat).HasColumnName("pa_cd_id_pat");
            entity.Property(e => e.PaCdIdSrc).HasColumnName("pa_cd_id_src");
            entity.Property(e => e.PaCreateDate)
                .HasDefaultValueSql("((1))")
                .HasColumnType("datetime")
                .HasColumnName("pa_create_date");
            entity.Property(e => e.PaDate)
                .HasColumnType("datetime")
                .HasColumnName("pa_date");
            entity.Property(e => e.PaJournalno)
                .HasMaxLength(255)
                .HasColumnName("pa_journalno");
            entity.Property(e => e.PaLinenumber).HasColumnName("pa_linenumber");
            entity.Property(e => e.PaModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("pa_modified_date");
            entity.Property(e => e.PaMvId).HasColumnName("pa_mv_id");
            entity.Property(e => e.PaNumber)
                .HasMaxLength(16)
                .HasColumnName("pa_number");
            entity.Property(e => e.PaOrgId).HasColumnName("pa_org_id");
            entity.Property(e => e.PaPssId).HasColumnName("pa_pss_id");
            entity.Property(e => e.PaPyId).HasColumnName("pa_py_id");
            entity.Property(e => e.PaRemarks)
                .HasMaxLength(255)
                .HasColumnName("pa_remarks");
            entity.Property(e => e.PaRoundAmount)
                .HasColumnType("numeric(16, 5)")
                .HasColumnName("pa_round_amount");
            entity.Property(e => e.PaSgdId).HasColumnName("pa_sgd_id");
            entity.Property(e => e.PaThpsId).HasColumnName("pa_thps_id");
            entity.Property(e => e.PaTotalAmount)
                .HasColumnType("numeric(16, 5)")
                .HasColumnName("pa_total_amount");
            entity.Property(e => e.PaTotalAmountBc)
                .HasColumnType("numeric(16, 5)")
                .HasColumnName("pa_total_amount_bc");
            entity.Property(e => e.PaUid)
                .HasMaxLength(128)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("pa_uid");
            entity.Property(e => e.PaUsId).HasColumnName("pa_us_id");
            entity.Property(e => e.PaVoid)
                .HasDefaultValue((short)-1)
                .HasColumnName("pa_void");
            entity.Property(e => e.PaVtId).HasColumnName("pa_vt_id");

            entity.HasOne(d => d.PaBu).WithMany(p => p.Payments)
                .HasForeignKey(d => d.PaBuId)
                .HasConstraintName("FK_PA_REF_BU");

            entity.HasOne(d => d.PaUs).WithMany(p => p.Payments)
                .HasForeignKey(d => d.PaUsId)
                .HasConstraintName("FK_PA_REF_US");
        });

        modelBuilder.Entity<PaymentSnc>(entity =>
        {
            entity.HasKey(e => new { e.SPaId, e.SPaSmId, e.SPaVersion }).HasFillFactor(90);

            entity.ToTable("PAYMENT_SNC", "syn");

            entity.Property(e => e.SPaId).HasColumnName("s_pa_id");
            entity.Property(e => e.SPaSmId).HasColumnName("s_pa_sm_id");
            entity.Property(e => e.SPaVersion)
                .HasMaxLength(25)
                .HasColumnName("s_pa_version");
            entity.Property(e => e.SPaCdIdCur).HasColumnName("s_pa_cd_id_cur");
            entity.Property(e => e.SPaCurSymb)
                .HasMaxLength(8)
                .HasColumnName("s_pa_cur_symb");
            entity.Property(e => e.SPaDate)
                .HasMaxLength(10)
                .HasColumnName("s_pa_date");
            entity.Property(e => e.SPaDocNo)
                .HasMaxLength(16)
                .HasColumnName("s_pa_doc_no");
            entity.Property(e => e.SPaFeId).HasColumnName("s_pa_fe_id");
            entity.Property(e => e.SPaIsCreated).HasColumnName("s_pa_is_created");
            entity.Property(e => e.SPaRoundAmt)
                .HasMaxLength(255)
                .HasColumnName("s_pa_round_amt");
            entity.Property(e => e.SPaSignFilename)
                .HasMaxLength(32)
                .HasColumnName("s_pa_sign_filename");
            entity.Property(e => e.SPaSoId).HasColumnName("s_pa_so_id");
            entity.Property(e => e.SPaSynched).HasColumnName("s_pa_synched");
            entity.Property(e => e.SPaTotalAmount)
                .HasMaxLength(255)
                .HasColumnName("s_pa_total_amount");
            entity.Property(e => e.SPaUid)
                .HasMaxLength(128)
                .HasColumnName("s_pa_uid");
            entity.Property(e => e.SPaVoided).HasColumnName("s_pa_voided");
            entity.Property(e => e.SPaVtId).HasColumnName("s_pa_vt_id");
            entity.Property(e => e.SPaVtUid)
                .HasMaxLength(128)
                .HasColumnName("s_pa_vt_uid");
            entity.Property(e => e.SPaYyyy).HasColumnName("s_pa_yyyy");
            entity.Property(e => e.SPaYyyymm).HasColumnName("s_pa_yyyymm");
        });

        modelBuilder.Entity<Profile>(entity =>
        {
            entity.HasKey(e => e.PrId).HasFillFactor(90);

            entity.ToTable("PROFILE", "cmn");

            entity.Property(e => e.PrId).HasColumnName("pr_id");
            entity.Property(e => e.PrActive).HasColumnName("pr_active");
            entity.Property(e => e.PrCode)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("pr_code");
            entity.Property(e => e.PrDescription)
                .HasMaxLength(50)
                .HasColumnName("pr_description");
        });

        modelBuilder.Entity<Report>(entity =>
        {
            entity.HasKey(e => e.RpId).HasFillFactor(90);

            entity.ToTable("REPORT", "cmn");

            entity.Property(e => e.RpId).HasColumnName("rp_id");
            entity.Property(e => e.RpActive).HasColumnName("rp_active");
            entity.Property(e => e.RpCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("rp_code");
            entity.Property(e => e.RpCompress).HasColumnName("rp_compress");
            entity.Property(e => e.RpCreateDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("rp_create_date");
            entity.Property(e => e.RpDestinationFile)
                .HasMaxLength(255)
                .HasColumnName("rp_destination_file");
            entity.Property(e => e.RpDestinationVirtualPath)
                .HasMaxLength(255)
                .HasColumnName("rp_destination_virtual_path");
            entity.Property(e => e.RpExcelSheetName)
                .HasMaxLength(50)
                .HasColumnName("rp_excel_sheet_name");
            entity.Property(e => e.RpFilePassword)
                .HasMaxLength(20)
                .HasColumnName("rp_file_password");
            entity.Property(e => e.RpGroup)
                .HasMaxLength(50)
                .HasColumnName("rp_group");
            entity.Property(e => e.RpIsRequested).HasColumnName("rp_is_requested");
            entity.Property(e => e.RpModifiedDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("rp_modified_date");
            entity.Property(e => e.RpPostSql).HasColumnName("rp_post_sql");
            entity.Property(e => e.RpPreSql).HasColumnName("rp_pre_sql");
            entity.Property(e => e.RpSendmail).HasColumnName("rp_sendmail");
            entity.Property(e => e.RpSourceFile)
                .HasMaxLength(255)
                .HasColumnName("rp_source_file");
            entity.Property(e => e.RpTempFile)
                .HasMaxLength(255)
                .HasColumnName("rp_temp_file");
            entity.Property(e => e.RpTitle)
                .HasMaxLength(100)
                .HasColumnName("rp_title");
            entity.Property(e => e.RpTsql).HasColumnName("rp_tsql");
            entity.Property(e => e.RpUsIdCreatedby).HasColumnName("rp_us_id_createdby");
            entity.Property(e => e.RpUsIdModifiedby).HasColumnName("rp_us_id_modifiedby");
        });

        modelBuilder.Entity<Models.Route>(entity =>
        {
            entity.HasKey(e => e.RtId).HasFillFactor(90);

            entity.ToTable("ROUTE", "cmn");

            entity.Property(e => e.RtId).HasColumnName("rt_id");
            entity.Property(e => e.RtCode)
                .HasMaxLength(32)
                .HasColumnName("rt_code");
            entity.Property(e => e.RtComments)
                .HasMaxLength(1000)
                .HasColumnName("rt_comments");
            entity.Property(e => e.RtCreationDate)
                .HasColumnType("datetime")
                .HasColumnName("rt_creation_date");
            entity.Property(e => e.RtDescriptionLan1).HasColumnName("rt_description_lan1");
            entity.Property(e => e.RtDescriptionLan2)
                .HasMaxLength(255)
                .HasColumnName("rt_description_lan2");
            entity.Property(e => e.RtDescriptionLan3)
                .HasMaxLength(255)
                .HasColumnName("rt_description_lan3");
            entity.Property(e => e.RtExecutionMode).HasColumnName("rt_execution_mode");
            entity.Property(e => e.RtFromDate).HasColumnName("rt_from_date");
            entity.Property(e => e.RtFromTime)
                .HasColumnType("smalldatetime")
                .HasColumnName("rt_from_time");
            entity.Property(e => e.RtPlId).HasColumnName("rt_pl_id");
            entity.Property(e => e.RtRtsId).HasColumnName("rt_rts_id");
            entity.Property(e => e.RtToDate).HasColumnName("rt_to_date");
            entity.Property(e => e.RtToTime)
                .HasColumnType("smalldatetime")
                .HasColumnName("rt_to_time");
            entity.Property(e => e.RtUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("rt_update_date");
            entity.Property(e => e.RtUsId).HasColumnName("rt_us_id");
            entity.Property(e => e.RtUsIdCr).HasColumnName("rt_us_id_cr");
            entity.Property(e => e.RtUsIdUp).HasColumnName("rt_us_id_up");

            entity.HasOne(d => d.RtUs).WithMany(p => p.Routes)
                .HasForeignKey(d => d.RtUsId)
                .HasConstraintName("FK_RT_REF_US");
        });

        modelBuilder.Entity<SalesSnc>(entity =>
        {
            entity.HasKey(e => new { e.SSoId, e.SSoSmId, e.SSoVersion }).HasFillFactor(90);

            entity.ToTable("SALES_SNC", "syn");

            entity.Property(e => e.SSoId).HasColumnName("s_so_id");
            entity.Property(e => e.SSoSmId).HasColumnName("s_so_sm_id");
            entity.Property(e => e.SSoVersion)
                .HasMaxLength(25)
                .HasColumnName("s_so_version");
            entity.Property(e => e.SSoCdIdCur).HasColumnName("s_so_cd_id_cur");
            entity.Property(e => e.SSoCdIdPmd).HasColumnName("s_so_cd_id_pmd");
            entity.Property(e => e.SSoCdIdPtm).HasColumnName("s_so_cd_id_ptm");
            entity.Property(e => e.SSoCdIdSpc).HasColumnName("s_so_cd_id_spc");
            entity.Property(e => e.SSoCdIdWhs).HasColumnName("s_so_cd_id_whs");
            entity.Property(e => e.SSoCuId).HasColumnName("s_so_cu_id");
            entity.Property(e => e.SSoCurSymb)
                .HasMaxLength(10)
                .HasColumnName("s_so_cur_symb");
            entity.Property(e => e.SSoDate)
                .HasColumnType("datetime")
                .HasColumnName("s_so_date");
            entity.Property(e => e.SSoDateDlvdue)
                .HasColumnType("datetime")
                .HasColumnName("s_so_date_dlvdue");
            entity.Property(e => e.SSoDeliveryDate)
                .HasMaxLength(64)
                .HasColumnName("s_so_delivery_date");
            entity.Property(e => e.SSoDiscountAmountLine)
                .HasColumnType("numeric(16, 5)")
                .HasColumnName("s_so_discount_amount_line");
            entity.Property(e => e.SSoDiscountCust)
                .HasColumnType("numeric(16, 5)")
                .HasColumnName("s_so_discount_cust");
            entity.Property(e => e.SSoDiscountLine)
                .HasColumnType("numeric(16, 5)")
                .HasColumnName("s_so_discount_line");
            entity.Property(e => e.SSoFeId).HasColumnName("s_so_fe_id");
            entity.Property(e => e.SSoInvoiceNo)
                .HasMaxLength(16)
                .HasColumnName("s_so_invoice_no");
            entity.Property(e => e.SSoIsCreated).HasColumnName("s_so_is_created");
            entity.Property(e => e.SSoLinesDiscAmt)
                .HasColumnType("decimal(16, 5)")
                .HasColumnName("s_so_lines_disc_amt");
            entity.Property(e => e.SSoLinesDiscPerc)
                .HasColumnType("decimal(16, 5)")
                .HasColumnName("s_so_lines_disc_perc");
            entity.Property(e => e.SSoPaymentType)
                .HasMaxLength(32)
                .HasColumnName("s_so_payment_type");
            entity.Property(e => e.SSoPtId).HasColumnName("s_so_pt_id");
            entity.Property(e => e.SSoRemarks)
                .HasMaxLength(255)
                .HasColumnName("s_so_remarks");
            entity.Property(e => e.SSoSalesDiscAmt)
                .HasColumnType("decimal(16, 5)")
                .HasColumnName("s_so_sales_disc_amt");
            entity.Property(e => e.SSoSalesDiscPerc)
                .HasColumnType("decimal(16, 5)")
                .HasColumnName("s_so_sales_disc_perc");
            entity.Property(e => e.SSoSignFile)
                .HasMaxLength(255)
                .HasColumnName("s_so_sign_file");
            entity.Property(e => e.SSoSoId).HasColumnName("s_so_so_id");
            entity.Property(e => e.SSoSubtotal)
                .HasMaxLength(255)
                .HasColumnName("s_so_subtotal");
            entity.Property(e => e.SSoSynched)
                .HasMaxLength(10)
                .HasColumnName("s_so_synched");
            entity.Property(e => e.SSoTotal)
                .HasMaxLength(255)
                .HasColumnName("s_so_total");
            entity.Property(e => e.SSoType)
                .HasMaxLength(10)
                .HasColumnName("s_so_type");
            entity.Property(e => e.SSoUid)
                .HasMaxLength(128)
                .HasColumnName("s_so_uid");
            entity.Property(e => e.SSoVat)
                .HasColumnType("numeric(16, 5)")
                .HasColumnName("s_so_vat");
            entity.Property(e => e.SSoVoided).HasColumnName("s_so_voided");
            entity.Property(e => e.SSoVtId).HasColumnName("s_so_vt_id");
            entity.Property(e => e.SSoVtUid)
                .HasMaxLength(128)
                .HasColumnName("s_so_vt_uid");
            entity.Property(e => e.SSoYyyy).HasColumnName("s_so_yyyy");
            entity.Property(e => e.SSoYyyymm).HasColumnName("s_so_yyyymm");
        });

        modelBuilder.Entity<Transaction>(entity =>
        {
            entity.HasKey(e => e.TsId).HasFillFactor(90);

            entity.ToTable("TRANSACTION", "sls");

            entity.Property(e => e.TsId).HasColumnName("ts_id");
            entity.Property(e => e.TsAttribute01)
                .HasMaxLength(50)
                .HasColumnName("ts_attribute_01");
            entity.Property(e => e.TsAttribute02)
                .HasMaxLength(50)
                .HasColumnName("ts_attribute_02");
            entity.Property(e => e.TsAttribute03)
                .HasMaxLength(50)
                .HasColumnName("ts_attribute_03");
            entity.Property(e => e.TsBuId).HasColumnName("ts_bu_id");
            entity.Property(e => e.TsCdIdCms).HasColumnName("ts_cd_id_cms");
            entity.Property(e => e.TsCdIdCur).HasColumnName("ts_cd_id_cur");
            entity.Property(e => e.TsCdIdSrc).HasColumnName("ts_cd_id_src");
            entity.Property(e => e.TsCreateDate)
                .HasDefaultValueSql("((1))")
                .HasColumnType("datetime")
                .HasColumnName("ts_create_date");
            entity.Property(e => e.TsCurRate)
                .HasColumnType("numeric(16, 5)")
                .HasColumnName("ts_cur_rate");
            entity.Property(e => e.TsDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ts_date");
            entity.Property(e => e.TsDiscount)
                .HasColumnType("numeric(16, 5)")
                .HasColumnName("ts_discount");
            entity.Property(e => e.TsDiscountAmount)
                .HasColumnType("numeric(16, 5)")
                .HasColumnName("ts_discount_amount");
            entity.Property(e => e.TsDueDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ts_due_date");
            entity.Property(e => e.TsExportedDate)
                .HasColumnType("datetime")
                .HasColumnName("ts_exported_date");
            entity.Property(e => e.TsInvCurRate)
                .HasColumnType("numeric(16, 5)")
                .HasColumnName("ts_inv_cur_rate");
            entity.Property(e => e.TsModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("ts_modified_date");
            entity.Property(e => e.TsNumber)
                .HasMaxLength(40)
                .HasColumnName("ts_number");
            entity.Property(e => e.TsOrgId).HasColumnName("ts_org_id");
            entity.Property(e => e.TsOurReference)
                .HasMaxLength(10)
                .HasColumnName("ts_our_reference");
            entity.Property(e => e.TsPtId).HasColumnName("ts_pt_id");
            entity.Property(e => e.TsRemarks)
                .HasMaxLength(255)
                .HasColumnName("ts_remarks");
            entity.Property(e => e.TsSgdId).HasColumnName("ts_sgd_id");
            entity.Property(e => e.TsTheirReference)
                .HasMaxLength(30)
                .HasColumnName("ts_their_reference");
            entity.Property(e => e.TsThpsIdBill).HasColumnName("ts_thps_id_bill");
            entity.Property(e => e.TsThpsIdShip).HasColumnName("ts_thps_id_ship");
            entity.Property(e => e.TsTotal)
                .HasColumnType("numeric(16, 5)")
                .HasColumnName("ts_total");
            entity.Property(e => e.TsTotalBc)
                .HasColumnType("numeric(16, 5)")
                .HasColumnName("ts_total_bc");
            entity.Property(e => e.TsTotalDiscount)
                .HasColumnType("numeric(16, 5)")
                .HasColumnName("ts_total_discount");
            entity.Property(e => e.TsTotalDiscountBc)
                .HasColumnType("numeric(16, 5)")
                .HasColumnName("ts_total_discount_bc");
            entity.Property(e => e.TsTotalFinal)
                .HasColumnType("numeric(38, 14)")
                .HasColumnName("ts_total_final");
            entity.Property(e => e.TsTotalTax)
                .HasColumnType("numeric(16, 5)")
                .HasColumnName("ts_total_tax");
            entity.Property(e => e.TsTotalTaxBc)
                .HasColumnType("numeric(16, 5)")
                .HasColumnName("ts_total_tax_bc");
            entity.Property(e => e.TsTssId).HasColumnName("ts_tss_id");
            entity.Property(e => e.TsTstId).HasColumnName("ts_tst_id");
            entity.Property(e => e.TsUid)
                .HasMaxLength(128)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("ts_uid");
            entity.Property(e => e.TsUsId).HasColumnName("ts_us_id");
            entity.Property(e => e.TsUsIdCreatedby).HasColumnName("ts_us_id_createdby");
            entity.Property(e => e.TsVtId).HasColumnName("ts_vt_id");

            entity.HasOne(d => d.TsBu).WithMany(p => p.Transactions)
                .HasForeignKey(d => d.TsBuId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TS_REF_BU");

            entity.HasOne(d => d.TsUs).WithMany(p => p.Transactions)
                .HasForeignKey(d => d.TsUsId)
                .HasConstraintName("FK_TS_REF_US");
        });

        modelBuilder.Entity<TransferSnc>(entity =>
        {
            entity.HasKey(e => new { e.STrId, e.STrSmId, e.STrVersion }).HasFillFactor(90);

            entity.ToTable("TRANSFER_SNC", "syn");

            entity.Property(e => e.STrId).HasColumnName("s_tr_id");
            entity.Property(e => e.STrSmId).HasColumnName("s_tr_sm_id");
            entity.Property(e => e.STrVersion)
                .HasMaxLength(25)
                .HasColumnName("s_tr_version");
            entity.Property(e => e.STrCode)
                .HasMaxLength(16)
                .HasColumnName("s_tr_code");
            entity.Property(e => e.STrDate)
                .HasColumnType("datetime")
                .HasColumnName("s_tr_date");
            entity.Property(e => e.STrInOut)
                .HasMaxLength(16)
                .HasColumnName("s_tr_in_out");
            entity.Property(e => e.STrIsCreated).HasColumnName("s_tr_is_created");
            entity.Property(e => e.STrRemarks)
                .HasMaxLength(100)
                .HasColumnName("s_tr_remarks");
            entity.Property(e => e.STrSignFilename)
                .HasMaxLength(100)
                .HasColumnName("s_tr_sign_filename");
            entity.Property(e => e.STrSmIdFrom).HasColumnName("s_tr_sm_id_from");
            entity.Property(e => e.STrSmIdTo).HasColumnName("s_tr_sm_id_to");
            entity.Property(e => e.STrSynched).HasColumnName("s_tr_synched");
            entity.Property(e => e.STrUid)
                .HasMaxLength(128)
                .HasColumnName("s_tr_uid");
            entity.Property(e => e.STrWhIdFrom).HasColumnName("s_tr_wh_id_from");
            entity.Property(e => e.STrWhIdTo).HasColumnName("s_tr_wh_id_to");
        });

        modelBuilder.Entity<Uom>(entity =>
        {
            entity.HasKey(e => e.UomId).HasFillFactor(90);

            entity.ToTable("UOM", "cmn");

            entity.Property(e => e.UomId).HasColumnName("uom_id");
            entity.Property(e => e.UomCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("uom_code");
            entity.Property(e => e.UomIsBase).HasColumnName("uom_is_base");
            entity.Property(e => e.UomIsSaleable)
                .HasDefaultValue(1)
                .HasColumnName("uom_is_saleable");
            entity.Property(e => e.UomNameLan1)
                .HasMaxLength(50)
                .HasColumnName("uom_name_lan1");
            entity.Property(e => e.UomNameLan2)
                .HasMaxLength(50)
                .HasColumnName("uom_name_lan2");
            entity.Property(e => e.UomNameLan3)
                .HasMaxLength(50)
                .HasColumnName("uom_name_lan3");
            entity.Property(e => e.UomOrder)
                .HasMaxLength(64)
                .HasColumnName("uom_order");
            entity.Property(e => e.UomRoundingPrecision).HasColumnName("uom_rounding_precision");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UsId)
                .HasName("PK_USERS")
                .HasFillFactor(90);

            entity.ToTable("USER", "cmn");

            entity.Property(e => e.UsId).HasColumnName("us_id");
            entity.Property(e => e.UsActive)
                .HasDefaultValue((short)1)
                .HasColumnName("us_active");
            entity.Property(e => e.UsCdIdGen).HasColumnName("us_cd_id_gen");
            entity.Property(e => e.UsCdIdTtl).HasColumnName("us_cd_id_ttl");
            entity.Property(e => e.UsCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("us_code");
            entity.Property(e => e.UsDbUser)
                .HasMaxLength(50)
                .HasColumnName("us_db_user");
            entity.Property(e => e.UsDeleted).HasColumnName("us_deleted");
            entity.Property(e => e.UsEmail)
                .HasMaxLength(100)
                .HasColumnName("us_email");
            entity.Property(e => e.UsExpiryDate)
                .HasColumnType("datetime")
                .HasColumnName("us_expiry_date");
            entity.Property(e => e.UsFirstName)
                .HasMaxLength(50)
                .HasColumnName("us_first_name");
            entity.Property(e => e.UsImported).HasColumnName("us_imported");
            entity.Property(e => e.UsLastName)
                .HasMaxLength(50)
                .HasColumnName("us_last_name");
            entity.Property(e => e.UsLogin)
                .HasMaxLength(20)
                .HasColumnName("us_login");
            entity.Property(e => e.UsPassword)
                .HasMaxLength(12)
                .HasColumnName("us_password");
            entity.Property(e => e.UsPrefix)
                .HasMaxLength(32)
                .HasColumnName("us_prefix");
            entity.Property(e => e.UsReadonly).HasColumnName("us_readonly");
            entity.Property(e => e.UsReceiveNotification).HasColumnName("us_receive_notification");
            entity.Property(e => e.UsRoute)
                .HasMaxLength(64)
                .HasColumnName("us_route");
            entity.Property(e => e.UsShortName)
                .HasMaxLength(50)
                .HasColumnName("us_short_name");
            entity.Property(e => e.UsThpId).HasColumnName("us_thp_id");
            entity.Property(e => e.UsToken).HasColumnName("us_token");
            entity.Property(e => e.UsType)
                .HasMaxLength(255)
                .HasColumnName("us_type");
            entity.Property(e => e.UsUsId).HasColumnName("us_us_id");

            entity.HasOne(d => d.UsUs).WithMany(p => p.InverseUsUs)
                .HasForeignKey(d => d.UsUsId)
                .HasConstraintName("FK_USER_REFERENCE_USER");
        });

        modelBuilder.Entity<UserProfile>(entity =>
        {
            entity.HasKey(e => e.UspId).HasFillFactor(90);

            entity.ToTable("USER_PROFILE", "cmn");

            entity.Property(e => e.UspId).HasColumnName("usp_id");
            entity.Property(e => e.UspPrId).HasColumnName("usp_pr_id");
            entity.Property(e => e.UspUsId).HasColumnName("usp_us_id");

            entity.HasOne(d => d.UspPr).WithMany(p => p.UserProfiles)
                .HasForeignKey(d => d.UspPrId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USP_REF_PR");

            entity.HasOne(d => d.UspUs).WithMany(p => p.UserProfiles)
                .HasForeignKey(d => d.UspUsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USP_REF_US");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
