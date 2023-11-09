﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class AccountingContext : DbContext
{
    public AccountingContext()
    {
    }

    public AccountingContext(DbContextOptions<AccountingContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AccReportOption> AccReportOptions { get; set; }

    public virtual DbSet<AccRptCircular> AccRptCirculars { get; set; }

    public virtual DbSet<AccRptCircularsFormDetail> AccRptCircularsFormDetails { get; set; }

    public virtual DbSet<AccRptCircularsReport> AccRptCircularsReports { get; set; }

    public virtual DbSet<AccSysOption> AccSysOptions { get; set; }

    public virtual DbSet<AccVoucherNo> AccVoucherNos { get; set; }

    public virtual DbSet<AccVoucherTempOption> AccVoucherTempOptions { get; set; }

    public virtual DbSet<Account> Accounts { get; set; }

    public virtual DbSet<AccountObject> AccountObjects { get; set; }

    public virtual DbSet<AccountZone> AccountZones { get; set; }

    public virtual DbSet<AccountingCutDate> AccountingCutDates { get; set; }

    public virtual DbSet<AccountingMarkDate> AccountingMarkDates { get; set; }

    public virtual DbSet<AccumulationCustomer> AccumulationCustomers { get; set; }

    public virtual DbSet<AlertDate> AlertDates { get; set; }

    public virtual DbSet<Attrib> Attribs { get; set; }

    public virtual DbSet<AttribGood> AttribGoods { get; set; }

    public virtual DbSet<AttribRange> AttribRanges { get; set; }

    public virtual DbSet<AutoBusinessVoucher> AutoBusinessVouchers { get; set; }

    public virtual DbSet<Bank> Banks { get; set; }

    public virtual DbSet<BankAccount> BankAccounts { get; set; }

    public virtual DbSet<Barcode> Barcodes { get; set; }

    public virtual DbSet<Branch> Branches { get; set; }

    public virtual DbSet<ChangePrice> ChangePrices { get; set; }

    public virtual DbSet<ChangePriceDetail> ChangePriceDetails { get; set; }

    public virtual DbSet<CheckStatistic> CheckStatistics { get; set; }

    public virtual DbSet<CheckStatisticsDetail> CheckStatisticsDetails { get; set; }

    public virtual DbSet<Contract> Contracts { get; set; }

    public virtual DbSet<ContractAppendix> ContractAppendices { get; set; }

    public virtual DbSet<ContractDetail> ContractDetails { get; set; }

    public virtual DbSet<ContractTermsOfPayment> ContractTermsOfPayments { get; set; }

    public virtual DbSet<Control> Controls { get; set; }

    public virtual DbSet<ControlForm> ControlForms { get; set; }

    public virtual DbSet<Currency> Currencies { get; set; }

    public virtual DbSet<CusStaffInCharge> CusStaffInCharges { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<CustomerPassword> CustomerPasswords { get; set; }

    public virtual DbSet<CustomersType> CustomersTypes { get; set; }

    public virtual DbSet<DateCode> DateCodes { get; set; }

    public virtual DbSet<DoubleCode> DoubleCodes { get; set; }

    public virtual DbSet<Exchange> Exchanges { get; set; }

    public virtual DbSet<ExpireInfor> ExpireInfors { get; set; }

    public virtual DbSet<ExtPrice> ExtPrices { get; set; }

    public virtual DbSet<ExtendTran> ExtendTrans { get; set; }

    public virtual DbSet<Fee> Fees { get; set; }

    public virtual DbSet<FeeAllocation> FeeAllocations { get; set; }

    public virtual DbSet<FeeGroup> FeeGroups { get; set; }

    public virtual DbSet<FixedAsset> FixedAssets { get; set; }

    public virtual DbSet<FixedAssetGroup> FixedAssetGroups { get; set; }

    public virtual DbSet<Form> Forms { get; set; }

    public virtual DbSet<FullTransactionAccounting> FullTransactionAccountings { get; set; }

    public virtual DbSet<GetUnitExchange> GetUnitExchanges { get; set; }

    public virtual DbSet<Good> Goods { get; set; }

    public virtual DbSet<GoodFlg> GoodFlgs { get; set; }

    public virtual DbSet<GoodServiceCalalog> GoodServiceCalalogs { get; set; }

    public virtual DbSet<GoodServiceGroup> GoodServiceGroups { get; set; }

    public virtual DbSet<HisExpPrice> HisExpPrices { get; set; }

    public virtual DbSet<HisImpPrice> HisImpPrices { get; set; }

    public virtual DbSet<HrCriteriaSalary> HrCriteriaSalaries { get; set; }

    public virtual DbSet<HrDayOff> HrDayOffs { get; set; }

    public virtual DbSet<HrDepartment> HrDepartments { get; set; }

    public virtual DbSet<HrDepartmentCriteriaSalary> HrDepartmentCriteriaSalaries { get; set; }

    public virtual DbSet<HrDepartmentLostGoodsSalary> HrDepartmentLostGoodsSalaries { get; set; }

    public virtual DbSet<HrDepartmentResponsibilitySalary> HrDepartmentResponsibilitySalaries { get; set; }

    public virtual DbSet<HrDepartmentSaleSalary> HrDepartmentSaleSalaries { get; set; }

    public virtual DbSet<HrDepartmentWorkSchedule> HrDepartmentWorkSchedules { get; set; }

    public virtual DbSet<HrLostGoodsSalary> HrLostGoodsSalaries { get; set; }

    public virtual DbSet<HrOtherIncomeDeduction> HrOtherIncomeDeductions { get; set; }

    public virtual DbSet<HrOverTime> HrOverTimes { get; set; }

    public virtual DbSet<HrPersonalIncomeTax> HrPersonalIncomeTaxes { get; set; }

    public virtual DbSet<HrResponsibilitySalary> HrResponsibilitySalaries { get; set; }

    public virtual DbSet<HrSalarySheet> HrSalarySheets { get; set; }

    public virtual DbSet<HrSalarySheetDetail> HrSalarySheetDetails { get; set; }

    public virtual DbSet<HrSaleRate> HrSaleRates { get; set; }

    public virtual DbSet<HrSaleSalary> HrSaleSalaries { get; set; }

    public virtual DbSet<HrTimeSheet> HrTimeSheets { get; set; }

    public virtual DbSet<HrWorkSchedule> HrWorkSchedules { get; set; }

    public virtual DbSet<HrWorkingTime> HrWorkingTimes { get; set; }

    public virtual DbSet<ImpExpAccountAlias> ImpExpAccountAliases { get; set; }

    public virtual DbSet<ImpExpMethod> ImpExpMethods { get; set; }

    public virtual DbSet<ImpExpMethodDetail> ImpExpMethodDetails { get; set; }

    public virtual DbSet<ImpExpMethodGroup> ImpExpMethodGroups { get; set; }

    public virtual DbSet<ImpExpMethodReport> ImpExpMethodReports { get; set; }

    public virtual DbSet<ImpExpMethodType> ImpExpMethodTypes { get; set; }

    public virtual DbSet<Incident> Incidents { get; set; }

    public virtual DbSet<IncidentGroup> IncidentGroups { get; set; }

    public virtual DbSet<Inventory> Inventories { get; set; }

    public virtual DbSet<Inventorylastday> Inventorylastdays { get; set; }

    public virtual DbSet<Inventorymark20190601> Inventorymark20190601s { get; set; }

    public virtual DbSet<Inventorymark20200701> Inventorymark20200701s { get; set; }

    public virtual DbSet<Inventorymark20200801> Inventorymark20200801s { get; set; }

    public virtual DbSet<Inventorymark20200901> Inventorymark20200901s { get; set; }

    public virtual DbSet<Inventorymark20201001> Inventorymark20201001s { get; set; }

    public virtual DbSet<Inventorymark20201101> Inventorymark20201101s { get; set; }

    public virtual DbSet<Inventorymark20201201> Inventorymark20201201s { get; set; }

    public virtual DbSet<Inventorymark20210101> Inventorymark20210101s { get; set; }

    public virtual DbSet<Inventorymark20210201> Inventorymark20210201s { get; set; }

    public virtual DbSet<Inventorymark20210301> Inventorymark20210301s { get; set; }

    public virtual DbSet<Inventorymark20210401> Inventorymark20210401s { get; set; }

    public virtual DbSet<Inventorymark20210501> Inventorymark20210501s { get; set; }

    public virtual DbSet<Inventorymark20210601> Inventorymark20210601s { get; set; }

    public virtual DbSet<Inventorymark20210701> Inventorymark20210701s { get; set; }

    public virtual DbSet<Inventorymark20210801> Inventorymark20210801s { get; set; }

    public virtual DbSet<Inventorymark20210901> Inventorymark20210901s { get; set; }

    public virtual DbSet<Inventorymark20211001> Inventorymark20211001s { get; set; }

    public virtual DbSet<Inventorymark20211014> Inventorymark20211014s { get; set; }

    public virtual DbSet<Inventorymark20211201> Inventorymark20211201s { get; set; }

    public virtual DbSet<Inventorymark20220101> Inventorymark20220101s { get; set; }

    public virtual DbSet<Inventorymark20220805> Inventorymark20220805s { get; set; }

    public virtual DbSet<Inventorystart> Inventorystarts { get; set; }

    public virtual DbSet<ListScale> ListScales { get; set; }

    public virtual DbSet<ListShelf> ListShelves { get; set; }

    public virtual DbSet<ListVat> ListVats { get; set; }

    public virtual DbSet<Log> Logs { get; set; }

    public virtual DbSet<LogDetail> LogDetails { get; set; }

    public virtual DbSet<Manufacture> Manufactures { get; set; }

    public virtual DbSet<Menu> Menus { get; set; }

    public virtual DbSet<Mpermission> Mpermissions { get; set; }

    public virtual DbSet<NegTransDetail> NegTransDetails { get; set; }

    public virtual DbSet<ObjectCategory> ObjectCategories { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderConditionSchedule> OrderConditionSchedules { get; set; }

    public virtual DbSet<OrderDetail> OrderDetails { get; set; }

    public virtual DbSet<OrganizationUnit> OrganizationUnits { get; set; }

    public virtual DbSet<OriginalTransaction> OriginalTransactions { get; set; }

    public virtual DbSet<OriginalTransactionRefer> OriginalTransactionRefers { get; set; }

    public virtual DbSet<OuterTran> OuterTrans { get; set; }

    public virtual DbSet<Packet> Packets { get; set; }

    public virtual DbSet<PacketDetail> PacketDetails { get; set; }

    public virtual DbSet<Permission> Permissions { get; set; }

    public virtual DbSet<Price> Prices { get; set; }

    public virtual DbSet<ProGroup> ProGroups { get; set; }

    public virtual DbSet<Promotion> Promotions { get; set; }

    public virtual DbSet<PromotionByZone> PromotionByZones { get; set; }

    public virtual DbSet<PromotionDetail> PromotionDetails { get; set; }

    public virtual DbSet<Provision> Provisions { get; set; }

    public virtual DbSet<QtyMinMax> QtyMinMaxes { get; set; }

    public virtual DbSet<QtyMinMaxDetail> QtyMinMaxDetails { get; set; }

    public virtual DbSet<ReRetailTransDetail> ReRetailTransDetails { get; set; }

    public virtual DbSet<ReportCategory> ReportCategories { get; set; }

    public virtual DbSet<RetailRateByGroupId> RetailRateByGroupIds { get; set; }

    public virtual DbSet<RetailTran> RetailTrans { get; set; }

    public virtual DbSet<RetailTranDetail> RetailTranDetails { get; set; }

    public virtual DbSet<RetailTranDetailTemp> RetailTranDetailTemps { get; set; }

    public virtual DbSet<RetailTranPromoDetail> RetailTranPromoDetails { get; set; }

    public virtual DbSet<RetailTransTemp> RetailTransTemps { get; set; }

    public virtual DbSet<Rmpermission> Rmpermissions { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<RoleZone> RoleZones { get; set; }

    public virtual DbSet<Rpermission> Rpermissions { get; set; }

    public virtual DbSet<Server> Servers { get; set; }

    public virtual DbSet<Shelf> Shelves { get; set; }

    public virtual DbSet<Station> Stations { get; set; }

    public virtual DbSet<Stock> Stocks { get; set; }

    public virtual DbSet<StockBranch> StockBranches { get; set; }

    public virtual DbSet<SysCode> SysCodes { get; set; }

    public virtual DbSet<SysParam> SysParams { get; set; }

    public virtual DbSet<SysParamValue> SysParamValues { get; set; }

    public virtual DbSet<Sysmarkdate> Sysmarkdates { get; set; }

    public virtual DbSet<Systranscutdate> Systranscutdates { get; set; }

    public virtual DbSet<Tool> Tools { get; set; }

    public virtual DbSet<ToolGroup> ToolGroups { get; set; }

    public virtual DbSet<TransByPacket> TransByPackets { get; set; }

    public virtual DbSet<TransDetail> TransDetails { get; set; }

    public virtual DbSet<TransDetailTest> TransDetailTests { get; set; }

    public virtual DbSet<TransDocumentType> TransDocumentTypes { get; set; }

    public virtual DbSet<TransType> TransTypes { get; set; }

    public virtual DbSet<Transaction> Transactions { get; set; }

    public virtual DbSet<TransactionAccounting> TransactionAccountings { get; set; }

    public virtual DbSet<TransactionDiscountDetail> TransactionDiscountDetails { get; set; }

    public virtual DbSet<TransactionEnvironmentalTaxDetail> TransactionEnvironmentalTaxDetails { get; set; }

    public virtual DbSet<TransactionExpiredDateDetail> TransactionExpiredDateDetails { get; set; }

    public virtual DbSet<TransactionFeeDetail> TransactionFeeDetails { get; set; }

    public virtual DbSet<TransactionImportTaxDetail> TransactionImportTaxDetails { get; set; }

    public virtual DbSet<TransactionLotNumberDetail> TransactionLotNumberDetails { get; set; }

    public virtual DbSet<TransactionObjectRelate> TransactionObjectRelates { get; set; }

    public virtual DbSet<TransactionObjectRelateMark20180810> TransactionObjectRelateMark20180810s { get; set; }

    public virtual DbSet<TransactionOtherTaxDetail> TransactionOtherTaxDetails { get; set; }

    public virtual DbSet<TransactionPromotionDetail> TransactionPromotionDetails { get; set; }

    public virtual DbSet<TransactionSpecialConsumeDetail> TransactionSpecialConsumeDetails { get; set; }

    public virtual DbSet<TransactionTaxInvoiceInfor> TransactionTaxInvoiceInfors { get; set; }

    public virtual DbSet<TransactionTransportDetail> TransactionTransportDetails { get; set; }

    public virtual DbSet<TransactionsSerialNumber> TransactionsSerialNumbers { get; set; }

    public virtual DbSet<TransactionsTest> TransactionsTests { get; set; }

    public virtual DbSet<Unit> Units { get; set; }

    public virtual DbSet<UnitExchange> UnitExchanges { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserRole> UserRoles { get; set; }

    public virtual DbSet<UserStation> UserStations { get; set; }

    public virtual DbSet<UserZone> UserZones { get; set; }

    public virtual DbSet<Voucher> Vouchers { get; set; }

    public virtual DbSet<VoucherDefine> VoucherDefines { get; set; }

    public virtual DbSet<VoucherDetail> VoucherDetails { get; set; }

    public virtual DbSet<VoucherMark20190601> VoucherMark20190601s { get; set; }

    public virtual DbSet<VoucherTypeCategory> VoucherTypeCategories { get; set; }

    public virtual DbSet<VouchersObjectRelate> VouchersObjectRelates { get; set; }

    public virtual DbSet<VouchersObjectRelateMark20190601> VouchersObjectRelateMark20190601s { get; set; }

    public virtual DbSet<WarrantyInfor> WarrantyInfors { get; set; }

    public virtual DbSet<Zone> Zones { get; set; }

    public virtual DbSet<ZzHrmcheckInOut> ZzHrmcheckInOuts { get; set; }

    public virtual DbSet<ZzHrmcriteriaList> ZzHrmcriteriaLists { get; set; }

    public virtual DbSet<ZzHrmdepartment> ZzHrmdepartments { get; set; }

    public virtual DbSet<ZzHrmholiday> ZzHrmholidays { get; set; }

    public virtual DbSet<ZzHrmschedule> ZzHrmschedules { get; set; }

    public virtual DbSet<ZzHrmshift> ZzHrmshifts { get; set; }

    public virtual DbSet<ZzHrmstaffCriteriaInfor> ZzHrmstaffCriteriaInfors { get; set; }

    public virtual DbSet<ZzHrmstaffInfor> ZzHrmstaffInfors { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=192.168.0.9;Database=ACCOUNTING;User Id=sa;Password=datphat@hanoi;Trusted_Connection=False;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AccReportOption>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.FormId, e.ZoneId, e.ObjectCategoryCode });

            entity.ToTable("AccReportOption");

            entity.Property(e => e.UserId)
                .HasMaxLength(5)
                .HasColumnName("UserID");
            entity.Property(e => e.FormId)
                .HasMaxLength(100)
                .HasColumnName("FormID");
            entity.Property(e => e.ZoneId)
                .HasMaxLength(2)
                .HasComment("ID chi nhánh")
                .HasColumnName("ZoneID");
            entity.Property(e => e.ObjectCategoryCode).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsDefault).HasComment("Là tùy chọn mặc định. Khi thêm mới Tùy chọn theo chi nhánh, theo User thì copy từ Tùy chọn này");
            entity.Property(e => e.IsGroupBy).HasComment("Nhóm theo điều kiện lọc");
            entity.Property(e => e.IsReportBy).HasComment("Nhóm theo điều kiện lọc");
            entity.Property(e => e.ObjectCategoryName).HasMaxLength(200);
            entity.Property(e => e.ObjectValue).HasMaxLength(4000);
            entity.Property(e => e.Sort).HasDefaultValueSql("((0))");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<AccRptCircular>(entity =>
        {
            entity.HasKey(e => e.CircularsNumber).HasName("PK_Circulars");

            entity.Property(e => e.CircularsNumber).HasMaxLength(200);
            entity.Property(e => e.IssuedDate).HasMaxLength(8);
            entity.Property(e => e.Issuedby).HasMaxLength(200);
            entity.Property(e => e.SignerBy).HasMaxLength(50);
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
        });

        modelBuilder.Entity<AccRptCircularsFormDetail>(entity =>
        {
            entity.HasKey(e => new { e.CircularsNumber, e.FormNumber }).HasName("PK_CircularsFormDetails");

            entity.Property(e => e.CircularsNumber).HasMaxLength(200);
            entity.Property(e => e.FormNumber).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.FormName).HasMaxLength(200);
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<AccRptCircularsReport>(entity =>
        {
            entity.HasKey(e => e.CircularsKey);

            entity.ToTable("AccRptCircularsReport");

            entity.Property(e => e.CircularsKey).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CircularsNumber).HasMaxLength(50);
            entity.Property(e => e.Code).HasMaxLength(10);
            entity.Property(e => e.ConditionAcount).HasMaxLength(100);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(10);
            entity.Property(e => e.DescriptionDetail).HasMaxLength(200);
            entity.Property(e => e.FontColor)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'Black')")
                .IsFixedLength()
                .HasComment("Màu chữ");
            entity.Property(e => e.FontSize)
                .HasDefaultValueSql("((10))")
                .HasComment("Cỡ font chữ");
            entity.Property(e => e.FontStyle)
                .HasMaxLength(1)
                .HasDefaultValueSql("(N'N')")
                .IsFixedLength()
                .HasComment("N là bình thường, I là nghiêng, B là đậm, U là gạch chân");
            entity.Property(e => e.FormNumber).HasMaxLength(50);
            entity.Property(e => e.FormulaCurrent).HasMaxLength(500);
            entity.Property(e => e.FormulaLast).HasMaxLength(500);
            entity.Property(e => e.IncidentSign)
                .HasMaxLength(1000)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Negative)
                .HasMaxLength(1)
                .HasDefaultValueSql("('')")
                .IsFixedLength();
            entity.Property(e => e.RptOrder).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .HasDefaultValueSql("((0))")
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.TypeOper)
                .HasMaxLength(2)
                .HasDefaultValueSql("(N'PS')")
                .IsFixedLength();
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ValueSign)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')");
        });

        modelBuilder.Entity<AccSysOption>(entity =>
        {
            entity.HasKey(e => e.UserOptionId);

            entity.ToTable("AccSysOption");

            entity.Property(e => e.UserOptionId)
                .HasDefaultValueSql("(newid())")
                .HasComment("PK - ID của tùy chọn")
                .HasColumnName("UserOptionID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .HasComment("Diễn giải: option này để làm gì, có value range nào.");
            entity.Property(e => e.IsDefault).HasComment("Là tùy chọn mặc định. Khi thêm mới Tùy chọn theo chi nhánh, theo User thì copy từ Tùy chọn này");
            entity.Property(e => e.IsGlobalOption).HasComment("Là tùy chọn chung toàn hệ thống");
            entity.Property(e => e.IsUserOption)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasComment("Là tùy chọn theo Người dùng");
            entity.Property(e => e.Lock).HasComment("Khóa");
            entity.Property(e => e.OptionName)
                .HasMaxLength(50)
                .HasComment("Mã của tùy chọn");
            entity.Property(e => e.OptionValue).HasComment("Giá trị của tùy chọn đó");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .HasDefaultValueSql("((1))")
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .HasDefaultValueSql("((0))")
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.UserId)
                .HasMaxLength(5)
                .HasComment("ID của người dùng")
                .HasColumnName("UserID");
            entity.Property(e => e.ValueType).HasComment("Kiểu giá trị (Thiết lập theo EnumDataType trên chương trình)");
            entity.Property(e => e.ZoneId)
                .HasMaxLength(2)
                .HasComment("ID chi nhánh")
                .HasColumnName("ZoneID");
        });

        modelBuilder.Entity<AccVoucherNo>(entity =>
        {
            entity.HasKey(e => new { e.ZoneId, e.AccVoucherNoId });

            entity.ToTable("AccVoucherNo");

            entity.Property(e => e.ZoneId)
                .HasMaxLength(2)
                .HasColumnName("ZoneID");
            entity.Property(e => e.AccVoucherNoId)
                .HasDefaultValueSql("(newid())")
                .HasComment("Mã ID chi phí")
                .HasColumnName("AccVoucherNoID");
            entity.Property(e => e.AccVoucherNoName).HasMaxLength(200);
            entity.Property(e => e.AccVoucherNoSign).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description)
                .HasMaxLength(1000)
                .HasComment("Mô tả chi phí");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<AccVoucherTempOption>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.FormId, e.ZoneId, e.VoucherTempName });

            entity.ToTable("AccVoucherTempOption");

            entity.Property(e => e.UserId)
                .HasMaxLength(5)
                .HasColumnName("UserID");
            entity.Property(e => e.FormId)
                .HasMaxLength(100)
                .HasColumnName("FormID");
            entity.Property(e => e.ZoneId)
                .HasMaxLength(2)
                .HasComment("ID chi nhánh")
                .HasColumnName("ZoneID");
            entity.Property(e => e.VoucherTempName).HasMaxLength(100);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsDefault).HasComment("Là tùy chọn mặc định. Khi thêm mới Tùy chọn theo chi nhánh, theo User thì copy từ Tùy chọn này");
            entity.Property(e => e.Sort).HasDefaultValueSql("((0))");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.VoucherTempIcon)
                .HasMaxLength(100)
                .HasDefaultValueSql("(newid())");
            entity.Property(e => e.VoucherTempPath)
                .HasMaxLength(100)
                .HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<Account>(entity =>
        {
            entity.HasKey(e => new { e.ZoneId, e.AccountId, e.AccountNumber }).HasName("PK_Account");

            entity.ToTable(tb => tb.HasComment("Danh mục tài khoản"));

            entity.Property(e => e.ZoneId)
                .HasMaxLength(2)
                .HasColumnName("ZoneID");
            entity.Property(e => e.AccountId)
                .HasMaxLength(100)
                .HasDefaultValueSql("(newid())")
                .HasComment("PK Tài khoản")
                .HasColumnName("AccountID");
            entity.Property(e => e.AccountNumber)
                .HasMaxLength(20)
                .HasComment("Số hiệu tài khoản");
            entity.Property(e => e.AccountCategoryKind).HasComment("Tính chất tài khoản: 0: Dư nợ; 1: Dư có; 2: Lưỡng tính");
            entity.Property(e => e.AccountName)
                .HasMaxLength(128)
                .HasComment("Tên tài khoản");
            entity.Property(e => e.AccountNameEnglish)
                .HasMaxLength(128)
                .HasComment("Tên tài khoản bằng tiếng anh");
            entity.Property(e => e.AccountObjectType)
                .HasDefaultValueSql("((0))")
                .HasComment("Loại đối tượng: 0 - Nhà cung cấp, 1- Khách hàng, 2- Nhân viên");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasComment("Diễn giải");
            entity.Property(e => e.DetailByAccountObject).HasComment("Chi tiết theo đối tượng");
            entity.Property(e => e.DetailByBankAccount).HasComment("Chi tiết theo tài khoản ngân hàng");
            entity.Property(e => e.DetailByContract).HasComment("Chi tiết theo hợp đồng");
            entity.Property(e => e.DetailByContractKind)
                .HasDefaultValueSql("((0))")
                .HasComment("0 = Chỉ cảnh báo; 1 = Bắt buộc nhập");
            entity.Property(e => e.DetailByDepartment).HasComment("Chi tiết theo đơn vị");
            entity.Property(e => e.DetailByDepartmentKind)
                .HasDefaultValueSql("((0))")
                .HasComment("0 = Chỉ cảnh báo; 1 = Bắt buộc nhập");
            entity.Property(e => e.DetailByExpenseItem).HasComment("Chi tiết theo Khoản mục CP");
            entity.Property(e => e.DetailByExpenseItemKind)
                .HasDefaultValueSql("((0))")
                .HasComment("0 = Chỉ cảnh báo; 1 = Bắt buộc nhập");
            entity.Property(e => e.DetailByJob).HasComment("Chi tiết theo đối tượng tập hợp chi phí");
            entity.Property(e => e.DetailByJobKind)
                .HasDefaultValueSql("((0))")
                .HasComment("0 = Chỉ cảnh báo; 1 = Bắt buộc nhập");
            entity.Property(e => e.DetailByListItem).HasComment("Chi tiết theo mã thống kê");
            entity.Property(e => e.DetailByListItemKind)
                .HasDefaultValueSql("((0))")
                .HasComment("0 = Chỉ cảnh báo; 1 = Bắt buộc nhập");
            entity.Property(e => e.DetailByOrder).HasComment("Chi tiết theo đơn hàng");
            entity.Property(e => e.DetailByOrderKind)
                .HasDefaultValueSql("((0))")
                .HasComment("0 = Chỉ cảnh báo; 1 = Bắt buộc nhập");
            entity.Property(e => e.DetailByProjectWork).HasComment("Chi tiết theo công trình vụ việc");
            entity.Property(e => e.DetailByProjectWorkKind)
                .HasDefaultValueSql("((0))")
                .HasComment("0 = Chỉ cảnh báo; 1 = Bắt buộc nhập");
            entity.Property(e => e.DetailByPucontract).HasColumnName("DetailByPUContract");
            entity.Property(e => e.DetailByPucontractKind)
                .HasDefaultValueSql("((0))")
                .HasColumnName("DetailByPUContractKind");
            entity.Property(e => e.Grade)
                .HasDefaultValueSql("((1))")
                .HasComment("Cấp bậc");
            entity.Property(e => e.Inactive).HasComment("Ngừng theo dõi");
            entity.Property(e => e.IsParent).HasComment("Là TK tổng hợp");
            entity.Property(e => e.IsPostableInForeignCurrency).HasComment("Có hạch toán ngoại tệ");
            entity.Property(e => e.ParentId)
                .HasMaxLength(100)
                .HasComment("TK Tổng hợp")
                .HasColumnName("ParentID");
            entity.Property(e => e.PmscodeId)
                .HasMaxLength(100)
                .HasColumnName("PMSCodeID");
            entity.Property(e => e.SortCodeId)
                .HasMaxLength(100)
                .HasComment("Cột dùng để sort trên báo cáo. Không sử dụng trên giao diện.")
                .HasColumnName("SortCodeID");
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<AccountObject>(entity =>
        {
            entity.HasKey(e => new { e.ZoneId, e.AccountId, e.AccountNumber, e.ObjectId }).HasName("PK_AcountObject");

            entity.ToTable("AccountObject");

            entity.Property(e => e.ZoneId)
                .HasMaxLength(2)
                .HasColumnName("ZoneID");
            entity.Property(e => e.AccountId)
                .HasMaxLength(100)
                .HasDefaultValueSql("(newid())")
                .HasComment("PK Tài khoản")
                .HasColumnName("AccountID");
            entity.Property(e => e.AccountNumber)
                .HasMaxLength(20)
                .HasComment("Số hiệu tài khoản");
            entity.Property(e => e.ObjectId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("ObjectID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .HasDefaultValueSql("((0))")
                .IsFixedLength()
                .HasComment("0: chả làm gì  1: cảnh báo 2: bắt buộc");
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<AccountZone>(entity =>
        {
            entity.HasKey(e => new { e.ZoneId, e.AccountId, e.AccountNumber }).HasName("PK_ZoneAcount");

            entity.ToTable("AccountZone");

            entity.Property(e => e.ZoneId)
                .HasMaxLength(2)
                .HasColumnName("ZoneID");
            entity.Property(e => e.AccountId)
                .HasMaxLength(100)
                .HasDefaultValueSql("(newid())")
                .HasComment("PK Tài khoản")
                .HasColumnName("AccountID");
            entity.Property(e => e.AccountNumber)
                .HasMaxLength(20)
                .HasComment("Số hiệu tài khoản");
            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<AccountingCutDate>(entity =>
        {
            entity.HasKey(e => new { e.ZoneId, e.AccountingCutDate1 });

            entity.ToTable("AccountingCutDate");

            entity.Property(e => e.ZoneId)
                .HasMaxLength(2)
                .HasColumnName("ZoneID");
            entity.Property(e => e.AccountingCutDate1)
                .HasMaxLength(8)
                .HasColumnName("AccountingCutDate");
            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.FromDate).HasMaxLength(8);
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.ToDate).HasMaxLength(8);
        });

        modelBuilder.Entity<AccountingMarkDate>(entity =>
        {
            entity.HasKey(e => new { e.ZoneId, e.TransDate }).HasName("PK_AccountingMarkdate");

            entity.ToTable("AccountingMarkDate");

            entity.Property(e => e.ZoneId)
                .HasMaxLength(2)
                .HasColumnName("ZoneID");
            entity.Property(e => e.TransDate).HasMaxLength(8);
            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.Fromdate).HasMaxLength(8);
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.ToDate).HasMaxLength(8);
        });

        modelBuilder.Entity<AccumulationCustomer>(entity =>
        {
            entity.HasKey(e => new { e.ZoneId, e.TransactionId, e.CustomerId });

            entity.ToTable("AccumulationCustomer");

            entity.Property(e => e.ZoneId)
                .HasMaxLength(2)
                .HasColumnName("ZoneID");
            entity.Property(e => e.TransactionId)
                .HasMaxLength(20)
                .HasColumnName("TransactionID");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(10)
                .HasColumnName("CustomerID");
            entity.Property(e => e.Accumulation).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Payed).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.PromotionId)
                .HasMaxLength(20)
                .HasColumnName("PromotionID");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.TotalExpPrice).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.TotalExpPriceVat)
                .HasColumnType("decimal(22, 8)")
                .HasColumnName("TotalExpPriceVAT");
            entity.Property(e => e.TransDate).HasMaxLength(8);
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<AlertDate>(entity =>
        {
            entity.HasKey(e => new { e.StockId, e.GoodId });

            entity.Property(e => e.StockId)
                .HasMaxLength(5)
                .HasColumnName("StockID");
            entity.Property(e => e.GoodId)
                .HasMaxLength(9)
                .HasColumnName("GoodID");
            entity.Property(e => e.NoOfDate).HasDefaultValueSql("((0))");
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");

            entity.HasOne(d => d.Good).WithMany(p => p.AlertDates)
                .HasForeignKey(d => d.GoodId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AlertDates_Goods");

            entity.HasOne(d => d.Stock).WithMany(p => p.AlertDates)
                .HasForeignKey(d => d.StockId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AlertDates_Stocks");
        });

        modelBuilder.Entity<Attrib>(entity =>
        {
            entity.HasKey(e => e.AttribCode);

            entity.Property(e => e.AttribCode).HasMaxLength(6);
            entity.Property(e => e.AttribName).HasMaxLength(50);
            entity.Property(e => e.AttribUnitId)
                .HasMaxLength(5)
                .HasColumnName("AttribUnitID");
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
        });

        modelBuilder.Entity<AttribGood>(entity =>
        {
            entity.HasKey(e => e.GoodId);

            entity.Property(e => e.GoodId)
                .HasMaxLength(9)
                .HasColumnName("GoodID");
            entity.Property(e => e.AttribCode).HasMaxLength(6);
            entity.Property(e => e.AttribValue).HasMaxLength(4000);
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");

            entity.HasOne(d => d.AttribCodeNavigation).WithMany(p => p.AttribGoods)
                .HasForeignKey(d => d.AttribCode)
                .HasConstraintName("FK_AttribGoods_Attribs");

            entity.HasOne(d => d.Good).WithOne(p => p.AttribGood)
                .HasForeignKey<AttribGood>(d => d.GoodId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AttribGoods_Goods");
        });

        modelBuilder.Entity<AttribRange>(entity =>
        {
            entity.HasKey(e => new { e.AttribCode, e.AttribValue });

            entity.ToTable("AttribRange");

            entity.Property(e => e.AttribCode).HasMaxLength(6);
            entity.Property(e => e.AttribValue).HasMaxLength(50);
            entity.Property(e => e.AttribDisplay).HasMaxLength(20);
            entity.Property(e => e.Condition).HasMaxLength(4000);
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");

            entity.HasOne(d => d.AttribCodeNavigation).WithMany(p => p.AttribRanges)
                .HasForeignKey(d => d.AttribCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AttribRange_Attribs");
        });

        modelBuilder.Entity<AutoBusinessVoucher>(entity =>
        {
            entity.HasKey(e => e.AutoBusinessId);

            entity.ToTable("AutoBusinessVoucher", tb => tb.HasComment("Định khoản tự động"));

            entity.HasIndex(e => e.Absign, "IX_AutoBusinessVoucher").IsUnique();

            entity.Property(e => e.AutoBusinessId)
                .HasMaxLength(50)
                .HasColumnName("AutoBusinessID");
            entity.Property(e => e.Absign)
                .HasMaxLength(50)
                .HasColumnName("ABSign");
            entity.Property(e => e.AutoBusinessName)
                .HasMaxLength(255)
                .HasComment("Tên định khoản tự động");
            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreditAccount)
                .HasMaxLength(20)
                .HasComment("Tài khoản có");
            entity.Property(e => e.DebitAccount)
                .HasMaxLength(20)
                .HasComment("Tài khoản nợ");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasComment("Diễn giải");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.VoucherType)
                .HasMaxLength(50)
                .HasComment("Loại chứng từ: 0 = Thu tiền mặt; 1 = Chi tiền mặt; 2 = Thu tiền gửi; 3 = Chi tiền gửi");
        });

        modelBuilder.Entity<Bank>(entity =>
        {
            entity.HasKey(e => e.BankId).HasName("PK_Bank_1");

            entity.ToTable("Bank", tb => tb.HasComment("Danh mục ngân hàng"));

            entity.Property(e => e.BankId)
                .HasDefaultValueSql("(newid())")
                .HasComment("Khoá chính")
                .HasColumnName("BankID");
            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .HasComment("Địa điểm hội sở chính");
            entity.Property(e => e.BankCode)
                .HasMaxLength(20)
                .HasComment("Tên viết tắt");
            entity.Property(e => e.BankName)
                .HasMaxLength(128)
                .HasComment("Tên ngân hàng đầy đủ");
            entity.Property(e => e.BankNameEnglish)
                .HasMaxLength(128)
                .HasComment("Tên ngân hàng đầy đủ tiếng anh");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasComment("Người tạo");
            entity.Property(e => e.CreatedDate)
                .HasComment("Ngày tạo")
                .HasColumnType("datetime");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasComment("Diễn giải");
            entity.Property(e => e.Icon).HasComment("Icon");
            entity.Property(e => e.Inactive).HasComment("Ngừng theo dõi");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasComment("Người sửa");
            entity.Property(e => e.UpdatedDate)
                .HasComment("Ngày sửa")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<BankAccount>(entity =>
        {
            entity.HasKey(e => e.BankAccountNumber).HasName("PK_BankAccount_1");

            entity.ToTable("BankAccount", tb => tb.HasComment("Danh mục Tài khoản ngân hàng"));

            entity.Property(e => e.BankAccountNumber)
                .HasMaxLength(50)
                .HasComment("Số tài khoản ngân hàng");
            entity.Property(e => e.AccountHolder)
                .HasMaxLength(128)
                .HasComment("Chủ tài khoản");
            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .HasComment("Địa chỉ nơi mở");
            entity.Property(e => e.BankBrand).HasMaxLength(250);
            entity.Property(e => e.BankId)
                .HasDefaultValueSql("(newid())")
                .HasComment("Ngân hàng")
                .HasColumnName("BankID");
            entity.Property(e => e.BankName)
                .HasMaxLength(255)
                .HasComment("Nơi mở: ví dụ Ngân hàng VCB chi nhánh 01");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')")
                .HasComment("Mã ngân hàng của Khách hàng, nếu trống thì là mã của đơn vị đang sử dụng phần mềm.")
                .HasColumnName("CustomerID");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasComment("Diễn giải");
            entity.Property(e => e.Inactive).HasComment("Ngừng theo dõi");
            entity.Property(e => e.MainFlag)
                .HasDefaultValueSql("((0))")
                .HasComment("Cờ báo là tài khoản chính mặc định được sử dụng cho đơn vị tổ chức đó.");
            entity.Property(e => e.ProvinceOrCity).HasMaxLength(100);
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .HasDefaultValueSql("((0))")
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.SystemFlag)
                .HasDefaultValueSql("((0))")
                .HasComment("Cờ báo là tài khoản của hệ thống công ty đang sử dụng phần mềm 0 là của khách hàng, 1 là của hệ thống");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Bank).WithMany(p => p.BankAccounts)
                .HasForeignKey(d => d.BankId)
                .HasConstraintName("FK_BankAccount_Bank");
        });

        modelBuilder.Entity<Barcode>(entity =>
        {
            entity.HasKey(e => e.Barcode1).HasName("PK_Barcodes_1");

            entity.Property(e => e.Barcode1)
                .HasMaxLength(20)
                .HasColumnName("Barcode");
            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.GoodId)
                .HasMaxLength(9)
                .HasColumnName("GoodID");
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<Branch>(entity =>
        {
            entity.Property(e => e.BranchId)
                .HasMaxLength(5)
                .HasColumnName("BranchID");
            entity.Property(e => e.BranchName).HasMaxLength(100);
            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Note).HasMaxLength(200);
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<ChangePrice>(entity =>
        {
            entity.HasKey(e => e.ChangePriceId).HasName("PK_ChangePrice_1");

            entity.ToTable("ChangePrice");

            entity.Property(e => e.ChangePriceId).HasMaxLength(20);
            entity.Property(e => e.ApproverDate).HasMaxLength(8);
            entity.Property(e => e.ApproverTime).HasMaxLength(6);
            entity.Property(e => e.ApproverUser).HasMaxLength(50);
            entity.Property(e => e.ChangeListDate).HasMaxLength(8);
            entity.Property(e => e.ChangeListTime).HasMaxLength(6);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.TransCode)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UserList).HasMaxLength(50);
        });

        modelBuilder.Entity<ChangePriceDetail>(entity =>
        {
            entity.HasKey(e => new { e.ChangePriceId, e.TransactionId, e.ImportId, e.GoodId }).HasName("PK_ChangePriceDetail_1");

            entity.ToTable("ChangePriceDetail");

            entity.Property(e => e.ChangePriceId).HasMaxLength(20);
            entity.Property(e => e.TransactionId)
                .HasMaxLength(20)
                .HasColumnName("TransactionID");
            entity.Property(e => e.ImportId)
                .HasMaxLength(10)
                .HasColumnName("ImportID");
            entity.Property(e => e.GoodId)
                .HasMaxLength(9)
                .HasColumnName("GoodID");
            entity.Property(e => e.AutoNewRetailPrice).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.AutoNewRetailPriceVat)
                .HasColumnType("decimal(22, 8)")
                .HasColumnName("AutoNewRetailPriceVAT");
            entity.Property(e => e.AutoNewWholePrice).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.AutoNewWholePriceVat)
                .HasColumnType("decimal(22, 8)")
                .HasColumnName("AutoNewWholePriceVAT");
            entity.Property(e => e.BranchId)
                .HasMaxLength(5)
                .HasColumnName("BranchID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.GroupId)
                .HasMaxLength(6)
                .HasColumnName("GroupID");
            entity.Property(e => e.ImpPrice).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.ImpPriceVat)
                .HasColumnType("decimal(22, 8)")
                .HasColumnName("ImpPriceVAT");
            entity.Property(e => e.ItemId)
                .ValueGeneratedOnAdd()
                .HasColumnName("ItemID");
            entity.Property(e => e.LastRetailPrice).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.LastRetailPriceVat)
                .HasColumnType("decimal(22, 8)")
                .HasColumnName("LastRetailPriceVAT");
            entity.Property(e => e.LastWholePrice).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.LastWholePriceVat)
                .HasColumnType("decimal(22, 8)")
                .HasColumnName("LastWholePriceVAT");
            entity.Property(e => e.MaxPercentRetailPrice).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.MaxPercentWhole).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.MinPercentRetailPrice).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.MinPercentWhole).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.NewRetailPrice).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.NewRetailPriceVat)
                .HasColumnType("decimal(22, 8)")
                .HasColumnName("NewRetailPriceVAT");
            entity.Property(e => e.NewRetailProfitRate).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.NewWholePrice).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.NewWholePriceVat)
                .HasColumnType("decimal(22, 8)")
                .HasColumnName("NewWholePriceVAT");
            entity.Property(e => e.NewWholeProfitRate).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.OldRetailProfitRate).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.OldWholeProfitRate).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.PercentRetailPrice).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.PercentWhole).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.Time).HasMaxLength(6);
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<CheckStatistic>(entity =>
        {
            entity.HasKey(e => e.TransactionId).HasName("PK_Inventory_2");

            entity.Property(e => e.TransactionId)
                .HasMaxLength(20)
                .HasColumnName("TransactionID");
            entity.Property(e => e.AllowTran).HasDefaultValueSql("((0))");
            entity.Property(e => e.Condition).HasMaxLength(4000);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Note).HasMaxLength(200);
            entity.Property(e => e.RealFile).HasColumnType("ntext");
            entity.Property(e => e.StationId)
                .HasMaxLength(3)
                .HasColumnName("StationID");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.StockId)
                .HasMaxLength(5)
                .HasColumnName("StockID");
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.TransDate).HasMaxLength(8);
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<CheckStatisticsDetail>(entity =>
        {
            entity.HasKey(e => new { e.TranId, e.FullGoodId }).HasName("PK_InventDetail");

            entity.ToTable("CheckStatisticsDetail");

            entity.Property(e => e.TranId)
                .HasMaxLength(20)
                .HasColumnName("TranID");
            entity.Property(e => e.FullGoodId)
                .HasMaxLength(13)
                .HasColumnName("FullGoodID");
            entity.Property(e => e.AverPrice).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.AverPriceVat).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.GoodId)
                .HasMaxLength(9)
                .HasColumnName("GoodID");
            entity.Property(e => e.ItemId)
                .ValueGeneratedOnAdd()
                .HasColumnName("ItemID");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");

            entity.HasOne(d => d.Good).WithMany(p => p.CheckStatisticsDetails)
                .HasForeignKey(d => d.GoodId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CheckStatisticsDetail_Goods");

            entity.HasOne(d => d.Tran).WithMany(p => p.CheckStatisticsDetails)
                .HasForeignKey(d => d.TranId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InventDetail_Inventory");
        });

        modelBuilder.Entity<Contract>(entity =>
        {
            entity.HasKey(e => e.ContractId).HasName("PK_Contract");

            entity.HasIndex(e => e.ContractNumber, "IX_Contracts").IsUnique();

            entity.Property(e => e.ContractId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("ContractID");
            entity.Property(e => e.AgentName)
                .HasMaxLength(50)
                .HasComment("Người đại diện");
            entity.Property(e => e.AgentPosition)
                .HasMaxLength(50)
                .HasComment("Chức vụ Người đại diện");
            entity.Property(e => e.AppendixNumber).HasComment("Số lượng phụ lục Hợp Đồng");
            entity.Property(e => e.ConTractGroupType)
                .HasDefaultValueSql("((0))")
                .HasComment("Loại hợp đồng 1 HĐ Mua, 2 HĐ bán.");
            entity.Property(e => e.ConTractType)
                .HasDefaultValueSql("((0))")
                .HasComment("Loại hợp đồng, nếu là 0 là  hợp đồng bình thường, nếu là 1 là hợp đồng nguyên tắc, chi tiết hàng hóa theo phụ lục hợp đồng");
            entity.Property(e => e.ContractDebtLimit).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.ContractDebtLimitOc)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("ContractDebtLimitOC");
            entity.Property(e => e.ContractDetail)
                .HasDefaultValueSql("('')")
                .HasComment("Mô tả chi tiết hợp đồng nếu có")
                .HasColumnType("ntext");
            entity.Property(e => e.ContractExpiredDate).HasMaxLength(8);
            entity.Property(e => e.ContractName).HasMaxLength(100);
            entity.Property(e => e.ContractNumber).HasMaxLength(50);
            entity.Property(e => e.ContractSignDate).HasMaxLength(8);
            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CurrencyId)
                .HasMaxLength(3)
                .HasColumnName("CurrencyID");
            entity.Property(e => e.CustomBranchCode)
                .HasMaxLength(6)
                .HasComment("Mã HS Code đối với Hải quan");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(20)
                .HasColumnName("CustomerID");
            entity.Property(e => e.EnableSchedule).HasDefaultValueSql("((0))");
            entity.Property(e => e.ExchangeRate)
                .HasComment("Tỉ giá hối đoái")
                .HasColumnType("decimal(22, 8)");
            entity.Property(e => e.ExtentDate)
                .HasMaxLength(8)
                .HasDefaultValueSql("((0))")
                .HasComment("Ngày ra hạn");
            entity.Property(e => e.ExtentNumberDay)
                .HasDefaultValueSql("((0))")
                .HasComment("Số ngày ra hạn thêm hợp đồng");
            entity.Property(e => e.ScheduleType)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.ScheduleValue).HasMaxLength(100);
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .HasDefaultValueSql("((1))")
                .IsFixedLength()
                .HasComment("Trạng thái: 0 đã thanh lý không còn hiệu lực, 1 còn hiệu lực,2: chưa thanh lý nhưng quá hạn.");
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.TotalContractAmount).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.TotalContractAmountOc)
                .HasColumnType("decimal(22, 8)")
                .HasColumnName("TotalContractAmountOC");
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ZoneId)
                .HasMaxLength(5)
                .HasColumnName("ZoneID");
        });

        modelBuilder.Entity<ContractAppendix>(entity =>
        {
            entity.HasKey(e => new { e.ContractId, e.AppendixContractId });

            entity.ToTable("ContractAppendix");

            entity.Property(e => e.ContractId).HasColumnName("ContractID");
            entity.Property(e => e.AppendixContractId)
                .HasDefaultValueSql("(newid())")
                .HasComment("ID phụ lục hợp đồng.")
                .HasColumnName("AppendixContractID");
            entity.Property(e => e.AppendixDebtLimit).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.AppendixDebtLimitOc)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("AppendixDebtLimitOC");
            entity.Property(e => e.AppendixDetail)
                .HasDefaultValueSql("('')")
                .HasComment("Mô tả chi tiết phụ lục hợp đồng nếu có")
                .HasColumnType("ntext");
            entity.Property(e => e.AppendixExpiredDate)
                .HasMaxLength(8)
                .HasComment("Ngày hết hạn phụ lục");
            entity.Property(e => e.AppendixName).HasMaxLength(100);
            entity.Property(e => e.AppendixNumber)
                .HasMaxLength(50)
                .HasComment("Số phụ lục HĐ = Số HĐ+ Số thứ tự của phụ lục (Cộng String)");
            entity.Property(e => e.AppendixSignDate).HasMaxLength(8);
            entity.Property(e => e.AppendixStatus)
                .HasMaxLength(1)
                .HasDefaultValueSql("((1))")
                .IsFixedLength()
                .HasComment("Trạng thái: 0 đã thanh lý không còn hiệu lực, 1 còn hiệu lực,2: chưa thanh lý nhưng quá hạn.");
            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EnableSchedule).HasDefaultValueSql("((0))");
            entity.Property(e => e.ExtentDate)
                .HasMaxLength(8)
                .HasDefaultValueSql("((0))")
                .HasComment("Ngày ra hạn");
            entity.Property(e => e.ExtentNumberDay)
                .HasDefaultValueSql("((0))")
                .HasComment("Số ngày ra hạn thêm hợp đồng");
            entity.Property(e => e.ScheduleType)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.ScheduleValue).HasMaxLength(100);
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.TotalAppendixAmount).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.TotalAppendixAmountOc)
                .HasColumnType("decimal(22, 8)")
                .HasColumnName("TotalAppendixAmountOC");
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ZoneId)
                .HasMaxLength(5)
                .HasColumnName("ZoneID");
        });

        modelBuilder.Entity<ContractDetail>(entity =>
        {
            entity.HasKey(e => new { e.ContractId, e.GoodId, e.AppendixContractId });

            entity.Property(e => e.ContractId).HasColumnName("ContractID");
            entity.Property(e => e.GoodId)
                .HasMaxLength(9)
                .HasColumnName("GoodID");
            entity.Property(e => e.AppendixContractId)
                .HasComment("ID phụ lục hợp đồng, nếu không có phụ lục thì để trống")
                .HasColumnName("AppendixContractID");
            entity.Property(e => e.BigUnitId)
                .HasMaxLength(5)
                .HasColumnName("BigUnitID");
            entity.Property(e => e.BranchId)
                .HasMaxLength(5)
                .HasDefaultValueSql("('')")
                .HasComment("Ngành hàng cung cấp")
                .HasColumnName("BranchID");
            entity.Property(e => e.ContainNumber)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasComment("Số Hiệu Container");
            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ExchangeRate).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.Hscode)
                .HasMaxLength(10)
                .HasColumnName("HSCode");
            entity.Property(e => e.ImpPrice).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.ImpPriceOc)
                .HasColumnType("decimal(22, 8)")
                .HasColumnName("ImpPriceOC");
            entity.Property(e => e.ImpPriceVat)
                .HasColumnType("decimal(22, 8)")
                .HasColumnName("ImpPriceVAT");
            entity.Property(e => e.ImpPriceVatoc)
                .HasColumnType("decimal(22, 8)")
                .HasColumnName("ImpPriceVATOC");
            entity.Property(e => e.ItemtName)
                .HasMaxLength(200)
                .HasDefaultValueSql("('')")
                .HasComment("Mô tả hàng hóa");
            entity.Property(e => e.LocationInStock)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasComment("Vị trí trong kho");
            entity.Property(e => e.PackageQty)
                .HasDefaultValueSql("((0))")
                .HasComment("Số lượng kiện");
            entity.Property(e => e.Quantity).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.TaxVatAmount)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(22, 8)");
            entity.Property(e => e.TaxVatAmountOc)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(22, 8)")
                .HasColumnName("TaxVatAmountOC");
            entity.Property(e => e.TaxVatRate)
                .HasDefaultValueSql("((0))")
                .HasComment("Thuế suất GTGT")
                .HasColumnType("decimal(22, 8)");
            entity.Property(e => e.TotalAmount).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.TotalAmountOc)
                .HasColumnType("decimal(22, 8)")
                .HasColumnName("TotalAmountOC");
            entity.Property(e => e.TotalAmountVat)
                .HasColumnType("decimal(22, 8)")
                .HasColumnName("TotalAmountVAT");
            entity.Property(e => e.TotalAmountVatoc)
                .HasColumnType("decimal(22, 8)")
                .HasColumnName("TotalAmountVATOC");
            entity.Property(e => e.UnitId)
                .HasMaxLength(5)
                .HasColumnName("UnitID");
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.VatId)
                .HasMaxLength(2)
                .HasDefaultValueSql("((0))")
                .HasColumnName("VatID");
        });

        modelBuilder.Entity<ContractTermsOfPayment>(entity =>
        {
            entity.HasKey(e => new { e.ContractId, e.AppendixContractId, e.NumberPayments }).HasName("PK_TermsOfPayment");

            entity.ToTable("ContractTermsOfPayment");

            entity.Property(e => e.ContractId).HasColumnName("ContractID");
            entity.Property(e => e.AppendixContractId)
                .HasComment("ID phụ lục hợp đồng, nếu không có phụ lục thì = ContractID")
                .HasColumnName("AppendixContractID");
            entity.Property(e => e.NumberPayments)
                .HasDefaultValueSql("((1))")
                .HasComment("Số lần thanh toán, mặc định là 1 lần và PaymentPercentage =100%");
            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DayPaymentByImp)
                .HasDefaultValueSql("((0))")
                .HasComment("Số ngày thanh toán sau khi nhập hàng, 0 - Thanh toán ngay, >0 số ngày sẽ thanh toán sau khi nhập hàng.");
            entity.Property(e => e.ItemId)
                .ValueGeneratedOnAdd()
                .HasColumnName("ItemID");
            entity.Property(e => e.PaymentAmount).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.PaymentAmountOc)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("PaymentAmountOC");
            entity.Property(e => e.PaymentDate).HasMaxLength(8);
            entity.Property(e => e.PaymentPercentage).HasDefaultValueSql("((100))");
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.TermsPaymentName).HasMaxLength(200);
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<Control>(entity =>
        {
            entity.Property(e => e.ControlId)
                .HasMaxLength(50)
                .HasColumnName("ControlID");
            entity.Property(e => e.ControlName).HasMaxLength(100);
            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Icon).HasMaxLength(100);
            entity.Property(e => e.Note).HasMaxLength(200);
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<ControlForm>(entity =>
        {
            entity.HasKey(e => new { e.ControlId, e.FormId });

            entity.ToTable("ControlForm");

            entity.Property(e => e.ControlId)
                .HasMaxLength(50)
                .HasColumnName("ControlID");
            entity.Property(e => e.FormId)
                .HasMaxLength(100)
                .HasColumnName("FormID");
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");

            entity.HasOne(d => d.Control).WithMany(p => p.ControlForms)
                .HasForeignKey(d => d.ControlId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ControlForm_Controls");

            entity.HasOne(d => d.Form).WithMany(p => p.ControlForms)
                .HasForeignKey(d => d.FormId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ControlForm_Forms");
        });

        modelBuilder.Entity<Currency>(entity =>
        {
            entity.Property(e => e.CurrencyId)
                .HasMaxLength(3)
                .HasColumnName("CurrencyID");
            entity.Property(e => e.CreatedBy).HasColumnType("datetime");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CurrencyName).HasMaxLength(50);
            entity.Property(e => e.DisplayName).HasMaxLength(50);
            entity.Property(e => e.Note).HasMaxLength(200);
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.UpdatedBy).HasColumnType("datetime");
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<CusStaffInCharge>(entity =>
        {
            entity.HasKey(e => e.CustomerId).HasName("PK_StaffInCharge");

            entity.ToTable("CusStaffInCharge");

            entity.Property(e => e.CustomerId)
                .HasMaxLength(10)
                .HasColumnName("CustomerID");
            entity.Property(e => e.StaffInChargeId)
                .HasMaxLength(10)
                .HasColumnName("StaffInChargeID");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.Property(e => e.CustomerId)
                .HasMaxLength(10)
                .HasColumnName("CustomerID");
            entity.Property(e => e.Address).HasMaxLength(200);
            entity.Property(e => e.Agent).HasMaxLength(100);
            entity.Property(e => e.AttendanceId)
                .HasMaxLength(4)
                .HasDefaultValueSql("('')")
                .HasComment("Nếu IsStaff =1 thì điền thêm số chấm công")
                .HasColumnName("AttendanceID");
            entity.Property(e => e.BankAccount).HasMaxLength(100);
            entity.Property(e => e.BankAddress).HasMaxLength(100);
            entity.Property(e => e.Birthday).HasMaxLength(8);
            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CusCardNo).HasMaxLength(20);
            entity.Property(e => e.CustomerName).HasMaxLength(100);
            entity.Property(e => e.DateStartWorking)
                .HasMaxLength(8)
                .HasDefaultValueSql("('')")
                .HasComment("Nếu IsStaff =1 thì khai thêm ngày Bắt đầu làm việc");
            entity.Property(e => e.DebtDay).HasDefaultValueSql("((0))");
            entity.Property(e => e.DebtLimit)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(18, 6)");
            entity.Property(e => e.DepartmentId)
                .HasMaxLength(50)
                .HasColumnName("DepartmentID");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.EnableSchedule).HasDefaultValueSql("((0))");
            entity.Property(e => e.EndDate).HasMaxLength(8);
            entity.Property(e => e.Fax).HasMaxLength(100);
            entity.Property(e => e.IdcardDate).HasMaxLength(8);
            entity.Property(e => e.IdcardLocation).HasMaxLength(200);
            entity.Property(e => e.IdcardNo).HasMaxLength(20);
            entity.Property(e => e.IsCustomers)
                .HasDefaultValueSql("((0))")
                .HasComment("Là khách hàng? 0 no  1 Yes");
            entity.Property(e => e.IsStaff)
                .HasDefaultValueSql("((0))")
                .HasComment("Là Nhân viên công ty, 0 - No, 1 Yes");
            entity.Property(e => e.IsSupply)
                .HasDefaultValueSql("((0))")
                .HasComment("Là Nhà cung cấp hàng hóa 0 - No,1 Yes");
            entity.Property(e => e.LaborContractNo)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasComment("Số hợp đồng lao động");
            entity.Property(e => e.Mobile).HasMaxLength(100);
            entity.Property(e => e.Note).HasMaxLength(200);
            entity.Property(e => e.ScheduleDetail)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .IsFixedLength();
            entity.Property(e => e.ScheduleType)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.ScheduleValue).HasMaxLength(100);
            entity.Property(e => e.StartDate).HasMaxLength(8);
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.Taxcode).HasMaxLength(20);
            entity.Property(e => e.Telephone).HasMaxLength(100);
            entity.Property(e => e.Title).HasMaxLength(50);
            entity.Property(e => e.TypeId)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TypeID");
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.UserId)
                .HasMaxLength(5)
                .HasDefaultValueSql("('')")
                .HasComment("Nếu IsStaff =1 thì có thể có UserID")
                .HasColumnName("UserID");
            entity.Property(e => e.ZoneId)
                .HasMaxLength(2)
                .HasColumnName("ZoneID");

            entity.HasOne(d => d.Type).WithMany(p => p.Customers)
                .HasForeignKey(d => d.TypeId)
                .HasConstraintName("FK_Customers_CustomersType");
        });

        modelBuilder.Entity<CustomerPassword>(entity =>
        {
            entity.HasKey(e => e.CustomerId);

            entity.ToTable("CustomerPassword");

            entity.Property(e => e.CustomerId)
                .HasMaxLength(10)
                .HasColumnName("CustomerID");
            entity.Property(e => e.Password).HasMaxLength(50);
        });

        modelBuilder.Entity<CustomersType>(entity =>
        {
            entity.HasKey(e => e.TypeId);

            entity.ToTable("CustomersType");

            entity.Property(e => e.TypeId)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TypeID");
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.TypeName).HasMaxLength(50);
        });

        modelBuilder.Entity<DateCode>(entity =>
        {
            entity.HasKey(e => new { e.ExpireDate, e.ExpireCode });

            entity.ToTable("DateCode");

            entity.Property(e => e.ExpireDate).HasMaxLength(8);
            entity.Property(e => e.ExpireCode).HasMaxLength(4);
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
        });

        modelBuilder.Entity<DoubleCode>(entity =>
        {
            entity.HasKey(e => new { e.GoodId, e.Barcode }).HasName("PK_DoubleCodes_1");

            entity.Property(e => e.GoodId)
                .HasMaxLength(9)
                .HasColumnName("GoodID");
            entity.Property(e => e.Barcode).HasMaxLength(20);
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");

            entity.HasOne(d => d.Good).WithMany(p => p.DoubleCodes)
                .HasForeignKey(d => d.GoodId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DoubleCodes_Goods");
        });

        modelBuilder.Entity<Exchange>(entity =>
        {
            entity.HasKey(e => new { e.CurrencyId, e.TranDate });

            entity.Property(e => e.CurrencyId)
                .HasMaxLength(3)
                .HasColumnName("CurrencyID");
            entity.Property(e => e.TranDate).HasMaxLength(8);
            entity.Property(e => e.CreatedBy).HasMaxLength(4);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ExchangeRate).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.UpdatedBy).HasMaxLength(4);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<ExpireInfor>(entity =>
        {
            entity.HasKey(e => new { e.ExpireId, e.TransactionId, e.GoodId, e.ExpireDate, e.LotNumber, e.ImportId, e.ExportId }).HasName("PK_ExpireInfor_1");

            entity.ToTable("ExpireInfor");

            entity.Property(e => e.ExpireId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("ExpireID");
            entity.Property(e => e.TransactionId)
                .HasMaxLength(20)
                .HasColumnName("TransactionID");
            entity.Property(e => e.GoodId)
                .HasMaxLength(9)
                .HasColumnName("GoodID");
            entity.Property(e => e.ExpireDate).HasMaxLength(8);
            entity.Property(e => e.LotNumber).HasMaxLength(20);
            entity.Property(e => e.ImportId)
                .HasMaxLength(10)
                .HasColumnName("ImportID");
            entity.Property(e => e.ExportId)
                .HasMaxLength(10)
                .HasColumnName("ExportID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ItemId)
                .ValueGeneratedOnAdd()
                .HasColumnName("ItemID");
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.TransDate).HasMaxLength(8);
        });

        modelBuilder.Entity<ExtPrice>(entity =>
        {
            entity.HasKey(e => new { e.GoodId, e.TypeId });

            entity.Property(e => e.GoodId)
                .HasMaxLength(9)
                .HasColumnName("GoodID");
            entity.Property(e => e.TypeId)
                .HasMaxLength(5)
                .HasColumnName("TypeID");
            entity.Property(e => e.ExtPrice1)
                .HasColumnType("decimal(22, 8)")
                .HasColumnName("ExtPrice");
            entity.Property(e => e.ExtPriceVat)
                .HasColumnType("decimal(22, 8)")
                .HasColumnName("ExtPriceVAT");
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .HasDefaultValueSql("((0))")
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");

            entity.HasOne(d => d.Good).WithMany(p => p.ExtPrices)
                .HasForeignKey(d => d.GoodId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ExtPrices_Goods");
        });

        modelBuilder.Entity<ExtendTran>(entity =>
        {
            entity.HasKey(e => new { e.TransactionId, e.UserId }).HasName("PK_ExRetailTrans");

            entity.Property(e => e.TransactionId)
                .HasMaxLength(20)
                .HasColumnName("TransactionID");
            entity.Property(e => e.UserId)
                .HasMaxLength(4)
                .HasColumnName("UserID");
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
        });

        modelBuilder.Entity<Fee>(entity =>
        {
            entity.HasKey(e => new { e.ZoneId, e.FeeId }).HasName("PK_Fee_2");

            entity.ToTable("Fee");

            entity.Property(e => e.ZoneId)
                .HasMaxLength(2)
                .HasColumnName("ZoneID");
            entity.Property(e => e.FeeId)
                .HasDefaultValueSql("(newid())")
                .HasComment("Mã ID chi phí")
                .HasColumnName("FeeID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description)
                .HasMaxLength(1000)
                .HasComment("Mô tả chi phí");
            entity.Property(e => e.FeeGroupId)
                .HasDefaultValueSql("(newid())")
                .HasComment("Mã ID chi phí")
                .HasColumnName("FeeGroupID");
            entity.Property(e => e.FeeName).HasMaxLength(200);
            entity.Property(e => e.FeeSign).HasMaxLength(50);
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<FeeAllocation>(entity =>
        {
            entity.HasKey(e => new { e.ZoneId, e.FeeAllocationId });

            entity.ToTable("FeeAllocation");

            entity.Property(e => e.ZoneId)
                .HasMaxLength(2)
                .HasColumnName("ZoneID");
            entity.Property(e => e.FeeAllocationId)
                .HasDefaultValueSql("(newid())")
                .HasComment("Mã ID chi phí")
                .HasColumnName("FeeAllocationID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description)
                .HasMaxLength(1000)
                .HasComment("Mô tả chi phí");
            entity.Property(e => e.FeeAllocationName).HasMaxLength(200);
            entity.Property(e => e.FeeAllocationSign).HasMaxLength(50);
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<FeeGroup>(entity =>
        {
            entity.HasKey(e => new { e.FeeGroupId, e.ZoneId }).HasName("PK_Fee");

            entity.ToTable("FeeGroup");

            entity.HasIndex(e => e.FeeGroupSign, "IX_Fee").IsUnique();

            entity.Property(e => e.FeeGroupId)
                .HasDefaultValueSql("(newid())")
                .HasComment("Mã ID chi phí")
                .HasColumnName("FeeGroupID");
            entity.Property(e => e.ZoneId)
                .HasMaxLength(2)
                .HasColumnName("ZoneID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description)
                .HasMaxLength(1000)
                .HasComment("Mô tả chi phí");
            entity.Property(e => e.FeeGroupName)
                .HasMaxLength(200)
                .HasComment("Tên chi phí");
            entity.Property(e => e.FeeGroupSign)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasComment("Kí Hiệu viết tắt mã chi phí");
            entity.Property(e => e.ParentFeeGroupId)
                .HasComment("Mã ID Chi Phí Cha")
                .HasColumnName("ParentFeeGroupID");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<FixedAsset>(entity =>
        {
            entity.HasKey(e => new { e.ZoneId, e.FixedAssetId });

            entity.ToTable("FixedAsset");

            entity.Property(e => e.ZoneId)
                .HasMaxLength(2)
                .HasColumnName("ZoneID");
            entity.Property(e => e.FixedAssetId)
                .HasDefaultValueSql("(newid())")
                .HasComment("Mã ID Tài sản")
                .HasColumnName("FixedAssetID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description)
                .HasMaxLength(1000)
                .HasComment("Mô tả Tài sản");
            entity.Property(e => e.FixedAssetGroupId)
                .HasDefaultValueSql("(newid())")
                .HasComment("Mã ID Tài sản")
                .HasColumnName("FixedAssetGroupID");
            entity.Property(e => e.FixedAssetName).HasMaxLength(200);
            entity.Property(e => e.FixedAssetSign).HasMaxLength(50);
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<FixedAssetGroup>(entity =>
        {
            entity.HasKey(e => new { e.FixedAssetGroupId, e.ZoneId });

            entity.Property(e => e.FixedAssetGroupId)
                .HasDefaultValueSql("(newid())")
                .HasComment("Mã ID Tài sản")
                .HasColumnName("FixedAssetGroupID");
            entity.Property(e => e.ZoneId)
                .HasMaxLength(2)
                .HasColumnName("ZoneID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description)
                .HasMaxLength(1000)
                .HasComment("Mô tả Tài sản");
            entity.Property(e => e.FixedAssetGroupName)
                .HasMaxLength(200)
                .HasComment("Tên Tài sản");
            entity.Property(e => e.FixedAssetGroupSign)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasComment("Kí Hiệu viết tắt mã Tài sản");
            entity.Property(e => e.ParentFixedAssetGroupId)
                .HasComment("Mã ID Tài sản Cha")
                .HasColumnName("ParentFixedAssetGroupID");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<Form>(entity =>
        {
            entity.HasKey(e => e.FormId).HasName("PK_Forms_1");

            entity.Property(e => e.FormId)
                .HasMaxLength(100)
                .HasColumnName("FormID");
            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FormName).HasMaxLength(300);
            entity.Property(e => e.MenuId)
                .HasMaxLength(50)
                .HasColumnName("MenuID");
            entity.Property(e => e.Note).HasMaxLength(200);
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Menu).WithMany(p => p.Forms)
                .HasForeignKey(d => d.MenuId)
                .HasConstraintName("FK_Forms_Menus");
        });

        modelBuilder.Entity<FullTransactionAccounting>(entity =>
        {
            entity.HasKey(e => new { e.ZoneId, e.TransDate, e.TransactionId, e.Type, e.Account }).HasName("PK__FullTran__6BC7CBF958098B1B");

            entity.ToTable("FullTransactionAccounting");

            entity.Property(e => e.ZoneId)
                .HasMaxLength(2)
                .HasColumnName("ZoneID");
            entity.Property(e => e.TransDate).HasMaxLength(8);
            entity.Property(e => e.TransactionId)
                .HasMaxLength(20)
                .HasColumnName("TransactionID");
            entity.Property(e => e.Type).HasMaxLength(1);
            entity.Property(e => e.Account).HasMaxLength(20);
            entity.Property(e => e.CreditAmount).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.DateWriteBook).HasMaxLength(8);
            entity.Property(e => e.DebitAmount).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.SyncTime).HasMaxLength(14);
            entity.Property(e => e.TransCode).HasMaxLength(10);
            entity.Property(e => e.WritedOnBook).HasMaxLength(8);
        });

        modelBuilder.Entity<GetUnitExchange>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("getUnitExchange");

            entity.Property(e => e.BigUnitId)
                .HasMaxLength(5)
                .HasColumnName("BigUnitID");
            entity.Property(e => e.BigUnitName).HasMaxLength(20);
            entity.Property(e => e.GoodId)
                .HasMaxLength(9)
                .HasColumnName("GoodID");
            entity.Property(e => e.UnitId)
                .HasMaxLength(5)
                .HasColumnName("UnitID");
            entity.Property(e => e.UnitName).HasMaxLength(20);
        });

        modelBuilder.Entity<Good>(entity =>
        {
            entity.Property(e => e.GoodId)
                .HasMaxLength(9)
                .HasColumnName("GoodID");
            entity.Property(e => e.AverImpPrice).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.AverImpPriceVat).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.BigUnitId)
                .HasMaxLength(5)
                .HasColumnName("BigUnitID");
            entity.Property(e => e.BranchId)
                .HasMaxLength(5)
                .HasColumnName("BranchID");
            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Enable).HasDefaultValueSql("((1))");
            entity.Property(e => e.ExpRetailPrice).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.ExpRetailPriceVat).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.ExpVat).HasMaxLength(2);
            entity.Property(e => e.ExpWholePrice).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.ExpWholePriceVat).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.FullName).HasMaxLength(100);
            entity.Property(e => e.GoodSupId)
                .HasMaxLength(15)
                .HasColumnName("GoodSupID");
            entity.Property(e => e.GroupId)
                .HasMaxLength(6)
                .HasColumnName("GroupID");
            entity.Property(e => e.HasExpireDate).HasDefaultValueSql("((0))");
            entity.Property(e => e.HasSerial).HasDefaultValueSql("((0))");
            entity.Property(e => e.ImageName).HasMaxLength(100);
            entity.Property(e => e.ImagePath).HasMaxLength(300);
            entity.Property(e => e.ImpPrice).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.ImpPriceVat).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.ImpVat).HasMaxLength(2);
            entity.Property(e => e.LastImpPrice).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.LastImpPriceVat).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.ManufactureId)
                .HasMaxLength(4)
                .HasColumnName("ManufactureID");
            entity.Property(e => e.Note).HasMaxLength(200);
            entity.Property(e => e.NumberExpireDay).HasDefaultValueSql("((0))");
            entity.Property(e => e.NumberWarrantyDay).HasDefaultValueSql("((0))");
            entity.Property(e => e.ShortName).HasMaxLength(50);
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SupplierId)
                .HasMaxLength(10)
                .HasColumnName("SupplierID");
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.UnitId)
                .HasMaxLength(5)
                .HasColumnName("UnitID");
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Warranty).HasDefaultValueSql("((0))");

            entity.HasOne(d => d.Branch).WithMany(p => p.Goods)
                .HasForeignKey(d => d.BranchId)
                .HasConstraintName("FK_Goods_Branches");

            entity.HasOne(d => d.Group).WithMany(p => p.Goods)
                .HasForeignKey(d => d.GroupId)
                .HasConstraintName("FK_Goods_Groups");

            entity.HasOne(d => d.ImpVatNavigation).WithMany(p => p.Goods)
                .HasForeignKey(d => d.ImpVat)
                .HasConstraintName("FK_Goods_ListVat");

            entity.HasOne(d => d.Supplier).WithMany(p => p.Goods)
                .HasForeignKey(d => d.SupplierId)
                .HasConstraintName("FK_Goods_Customers");

            entity.HasOne(d => d.Unit).WithMany(p => p.Goods)
                .HasForeignKey(d => d.UnitId)
                .HasConstraintName("FK_Goods_Units");
        });

        modelBuilder.Entity<GoodFlg>(entity =>
        {
            entity.HasKey(e => new { e.GoodId, e.FlagOnDate });

            entity.ToTable("GoodFlg");

            entity.Property(e => e.GoodId)
                .HasMaxLength(9)
                .HasColumnName("GoodID");
            entity.Property(e => e.FlagOnDate)
                .HasMaxLength(8)
                .HasDefaultValueSql("(CONVERT([varchar](8),getdate(),(112)))");
            entity.Property(e => e.FlagOffDate)
                .HasMaxLength(8)
                .HasDefaultValueSql("((99999999))");
            entity.Property(e => e.FlagOnBy).HasMaxLength(20);
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .HasDefaultValueSql("((0))")
                .IsFixedLength();
        });

        modelBuilder.Entity<GoodServiceCalalog>(entity =>
        {
            entity.HasKey(e => e.GoodServiceId);

            entity.ToTable("GoodServiceCalalog");

            entity.Property(e => e.GoodServiceId)
                .HasDefaultValueSql("(newid())")
                .HasComment("PK Mã danh mục dịch vụ")
                .HasColumnName("GoodServiceID");
            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Enable).HasDefaultValueSql("((1))");
            entity.Property(e => e.GoodServiceFullName)
                .HasMaxLength(500)
                .HasComment("Tên của Danh mục dịch vụ");
            entity.Property(e => e.GoodServiceGroupId)
                .HasMaxLength(6)
                .HasComment("Mã nhóm danh mục dịch vụ")
                .HasColumnName("GoodServiceGroupID");
            entity.Property(e => e.GoodServiceSign)
                .HasMaxLength(50)
                .HasComment("Kí hiệu của danh mục dịch vụ");
            entity.Property(e => e.GoodServiceSupId)
                .HasMaxLength(15)
                .HasComment("Mã NCC của nhà cung cấp danh mục dịch vụ")
                .HasColumnName("GoodServiceSupID");
            entity.Property(e => e.Note).HasMaxLength(200);
            entity.Property(e => e.Price).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.UnitId)
                .HasMaxLength(5)
                .HasColumnName("UnitID");
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.VatId)
                .HasMaxLength(2)
                .HasColumnName("VatID");
        });

        modelBuilder.Entity<GoodServiceGroup>(entity =>
        {
            entity.ToTable("GoodServiceGroup");

            entity.Property(e => e.GoodServiceGroupId)
                .HasMaxLength(6)
                .HasColumnName("GoodServiceGroupID");
            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Enable).HasDefaultValueSql("((1))");
            entity.Property(e => e.GoodServiceName).HasMaxLength(100);
            entity.Property(e => e.Note).HasMaxLength(200);
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<HisExpPrice>(entity =>
        {
            entity.HasKey(e => new { e.ZoneId, e.GoodId, e.CreatedDate });

            entity.ToTable("HisExpPrice");

            entity.Property(e => e.ZoneId)
                .HasMaxLength(2)
                .HasColumnName("ZoneID");
            entity.Property(e => e.GoodId)
                .HasMaxLength(9)
                .HasColumnName("GoodID");
            entity.Property(e => e.CreatedDate)
                .HasMaxLength(8)
                .HasDefaultValueSql("(getdate())");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.ExpRetailPrice).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.ExpRetailPriceVat).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.ExpWholePrice).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.ExpWholePriceVat).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");

            entity.HasOne(d => d.Good).WithMany(p => p.HisExpPrices)
                .HasForeignKey(d => d.GoodId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HisExpPrice_Goods");

            entity.HasOne(d => d.Zone).WithMany(p => p.HisExpPrices)
                .HasForeignKey(d => d.ZoneId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HisExpPrice_Zones");
        });

        modelBuilder.Entity<HisImpPrice>(entity =>
        {
            entity.HasKey(e => new { e.ZoneId, e.GoodId, e.TransactionId, e.ImpPrice });

            entity.ToTable("HisImpPrice");

            entity.Property(e => e.ZoneId)
                .HasMaxLength(2)
                .HasColumnName("ZoneID");
            entity.Property(e => e.GoodId)
                .HasMaxLength(9)
                .HasColumnName("GoodID");
            entity.Property(e => e.TransactionId)
                .HasMaxLength(20)
                .HasColumnName("TransactionID");
            entity.Property(e => e.ImpPrice).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasMaxLength(8)
                .HasDefaultValueSql("(getdate())");
            entity.Property(e => e.ExpRetailPrice).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.ExpRetailPriceVat).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.ExpWholePrice).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.ExpWholePriceVat).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.ImpPriceVat).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");

            entity.HasOne(d => d.Good).WithMany(p => p.HisImpPrices)
                .HasForeignKey(d => d.GoodId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HisImpPrice_Goods");

            entity.HasOne(d => d.Zone).WithMany(p => p.HisImpPrices)
                .HasForeignKey(d => d.ZoneId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HisImpPrice_Zones");
        });

        modelBuilder.Entity<HrCriteriaSalary>(entity =>
        {
            entity.HasKey(e => e.CriteriaSalaryId);

            entity.Property(e => e.CriteriaSalaryId)
                .HasMaxLength(50)
                .HasColumnName("CriteriaSalaryID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CriteriaSalaryName).HasMaxLength(100);
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<HrDayOff>(entity =>
        {
            entity.HasKey(e => e.IdAuto);

            entity.Property(e => e.IdAuto)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(10)
                .HasColumnName("CustomerID");
            entity.Property(e => e.DayOff)
                .HasMaxLength(8)
                .HasComment("Ngày trong tháng");
            entity.Property(e => e.Note).HasMaxLength(200);
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.TimeOffBegin).HasMaxLength(6);
            entity.Property(e => e.TimeOffEnd)
                .HasMaxLength(6)
                .HasComment("");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<HrDepartment>(entity =>
        {
            entity.HasKey(e => e.DepartmentId);

            entity.Property(e => e.DepartmentId)
                .HasMaxLength(50)
                .HasColumnName("DepartmentID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DepartmentName)
                .HasMaxLength(200)
                .HasDefaultValueSql("(newid())");
            entity.Property(e => e.MortgageProfitRate)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(22, 8)");
            entity.Property(e => e.SalaryBase)
                .HasDefaultValueSql("((0))")
                .HasComment("Số tiền nguyên tệ")
                .HasColumnType("decimal(22, 8)");
            entity.Property(e => e.SalaryInsurance)
                .HasDefaultValueSql("((0))")
                .HasComment("Số tiền nguyên tệ")
                .HasColumnType("decimal(22, 8)");
            entity.Property(e => e.SalaryProfitRate)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(22, 8)");
            entity.Property(e => e.SalarySaleByWorkday).HasDefaultValueSql("((1))");
            entity.Property(e => e.SaleForOvertime)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(22, 8)");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<HrDepartmentCriteriaSalary>(entity =>
        {
            entity.HasKey(e => new { e.DepartmentId, e.CriteriaSalaryId });

            entity.ToTable("HrDepartmentCriteriaSalary");

            entity.Property(e => e.DepartmentId)
                .HasMaxLength(50)
                .HasColumnName("DepartmentID");
            entity.Property(e => e.CriteriaSalaryId)
                .HasMaxLength(50)
                .HasColumnName("CriteriaSalaryID");
            entity.Property(e => e.CriteriaSalaryValue).HasColumnType("decimal(22, 8)");
        });

        modelBuilder.Entity<HrDepartmentLostGoodsSalary>(entity =>
        {
            entity.HasKey(e => new { e.DepartmentId, e.LostGoodsSalaryId });

            entity.ToTable("HrDepartmentLostGoodsSalary");

            entity.Property(e => e.DepartmentId)
                .HasMaxLength(50)
                .HasColumnName("DepartmentID");
            entity.Property(e => e.LostGoodsSalaryId)
                .HasMaxLength(50)
                .HasColumnName("LostGoodsSalaryID");
            entity.Property(e => e.LostGoodsSalaryValue).HasColumnType("decimal(22, 8)");
        });

        modelBuilder.Entity<HrDepartmentResponsibilitySalary>(entity =>
        {
            entity.HasKey(e => new { e.DepartmentId, e.ResponsibilitySalaryId });

            entity.ToTable("HrDepartmentResponsibilitySalary");

            entity.Property(e => e.DepartmentId)
                .HasMaxLength(50)
                .HasColumnName("DepartmentID");
            entity.Property(e => e.ResponsibilitySalaryId)
                .HasMaxLength(50)
                .HasColumnName("ResponsibilitySalaryID");
            entity.Property(e => e.ResponsibilitySalaryValue).HasColumnType("decimal(22, 8)");
        });

        modelBuilder.Entity<HrDepartmentSaleSalary>(entity =>
        {
            entity.HasKey(e => new { e.DepartmentId, e.SaleSalaryId });

            entity.ToTable("HrDepartmentSaleSalary");

            entity.Property(e => e.DepartmentId)
                .HasMaxLength(50)
                .HasColumnName("DepartmentID");
            entity.Property(e => e.SaleSalaryId)
                .HasMaxLength(50)
                .HasColumnName("SaleSalaryID");
        });

        modelBuilder.Entity<HrDepartmentWorkSchedule>(entity =>
        {
            entity.HasKey(e => new { e.DepartmentId, e.WorkScheduleId }).HasName("PK_DepartmentWorkSchedule");

            entity.ToTable("HrDepartmentWorkSchedule");

            entity.Property(e => e.DepartmentId)
                .HasMaxLength(50)
                .HasColumnName("DepartmentID");
            entity.Property(e => e.WorkScheduleId)
                .HasMaxLength(50)
                .HasColumnName("WorkScheduleID");
        });

        modelBuilder.Entity<HrLostGoodsSalary>(entity =>
        {
            entity.HasKey(e => e.LostGoodsSalaryId);

            entity.Property(e => e.LostGoodsSalaryId)
                .HasMaxLength(50)
                .HasColumnName("LostGoodsSalaryID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.LostGoodsSalaryName).HasMaxLength(100);
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<HrOtherIncomeDeduction>(entity =>
        {
            entity.HasKey(e => e.SyncTime);

            entity.ToTable("HrOtherIncomeDeduction");

            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(10)
                .HasColumnName("CustomerID");
            entity.Property(e => e.IncomeDeductionMonth)
                .HasMaxLength(8)
                .HasComment("Ngày trong tháng");
            entity.Property(e => e.IncomeDeductionType)
                .HasMaxLength(50)
                .HasComment("có 5 loại: tiền thiếu thu ngân (TIENTHIEUTHUNGAN), Tiền phạt vi phạm quy chế (TIENPHATQUYCHE), Trừ tiền thiếu thế chấp (TIENTHIEUTHECHAP), Tiền thưởng (TIENTHUONG), Thu nhập khác (THUNHAPKHAC)");
            entity.Property(e => e.IncomeDeductionValue).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.Note).HasMaxLength(200);
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<HrOverTime>(entity =>
        {
            entity.HasKey(e => e.IdAuto);

            entity.Property(e => e.IdAuto)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(10)
                .HasColumnName("CustomerID");
            entity.Property(e => e.DepartmentIdApply).HasMaxLength(50);
            entity.Property(e => e.Note).HasMaxLength(200);
            entity.Property(e => e.OverTimeBegin).HasMaxLength(6);
            entity.Property(e => e.OverTimeDay)
                .HasMaxLength(8)
                .HasComment("Ngày trong tháng");
            entity.Property(e => e.OverTimeEnd)
                .HasMaxLength(6)
                .HasComment("");
            entity.Property(e => e.SalaryRateApply)
                .HasDefaultValueSql("((100))")
                .HasColumnType("decimal(22, 8)");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<HrPersonalIncomeTax>(entity =>
        {
            entity.HasKey(e => e.TaxLevel);

            entity.ToTable("HrPersonalIncomeTax");

            entity.Property(e => e.TaxLevel).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IncomeFrom).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.IncomeTo).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.TaxRate).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<HrResponsibilitySalary>(entity =>
        {
            entity.HasKey(e => e.ResponsibilitySalaryId);

            entity.Property(e => e.ResponsibilitySalaryId)
                .HasMaxLength(50)
                .HasColumnName("ResponsibilitySalaryID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ResponsibilitySalaryName).HasMaxLength(100);
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<HrSalarySheet>(entity =>
        {
            entity.HasKey(e => e.SalarySheetId);

            entity.Property(e => e.SalarySheetId)
                .HasMaxLength(20)
                .HasColumnName("SalarySheetID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DepartmentId)
                .HasMaxLength(50)
                .HasColumnName("DepartmentID");
            entity.Property(e => e.Description).HasMaxLength(4000);
            entity.Property(e => e.FeeId)
                .HasDefaultValueSql("(newid())")
                .HasComment("Mã ID chi phí")
                .HasColumnName("FeeID");
            entity.Property(e => e.ImpExpMethodCode)
                .HasMaxLength(50)
                .HasComment("Mã phương thức Nhập xuất");
            entity.Property(e => e.ImpExpMethodId)
                .HasComment("Key Mã phương thức nhập xuất")
                .HasColumnName("ImpExpMethodID");
            entity.Property(e => e.ImpExpMethodName)
                .HasMaxLength(500)
                .HasComment("Tên phương thức nhập xuất.");
            entity.Property(e => e.SalaryMonth)
                .HasMaxLength(8)
                .HasComment("Ngày hạch toán");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .HasDefaultValueSql("((0))")
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.TransCode)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.TransDate).HasMaxLength(8);
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ZoneId)
                .HasMaxLength(2)
                .HasColumnName("ZoneID");
        });

        modelBuilder.Entity<HrSalarySheetDetail>(entity =>
        {
            entity.HasKey(e => e.SalaryDetailId);

            entity.ToTable("HrSalarySheetDetail");

            entity.Property(e => e.SalaryDetailId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("SalaryDetailID");
            entity.Property(e => e.ActuallyReceived).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.BaseSalary).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.CashShortOfCashier).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CriteriaSalary).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(10)
                .HasColumnName("CustomerID");
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.HealthInsuranceCom).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.HealthInsuranceEmp).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.LostGoodsKeeping).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.LostGoodsSalary).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.MortgageProfit).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.NumOfDayOfSalary).HasComment("Thời gian đi muộn về sớm tính theo phút");
            entity.Property(e => e.NumOfOtherWorkingDays)
                .HasComment("Thời gian đi muộn về sớm tính theo phút")
                .HasColumnType("decimal(22, 8)");
            entity.Property(e => e.NumOfOverTime).HasComment("Thời gian đi muộn về sớm tính theo phút");
            entity.Property(e => e.NumOfTardinessLeaveEarly).HasComment("Thời gian đi muộn về sớm tính theo phút");
            entity.Property(e => e.NumOfTardinessLeaveEarlyOrg).HasComment("Thời gian đi muộn về sớm tính theo phút");
            entity.Property(e => e.NumOfWorkingDays).HasComment("Thời gian đi muộn về sớm tính theo phút");
            entity.Property(e => e.OtherIncome).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.OverTimeSalary).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.PersonalIncomeTax).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.PrizeMoney).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.ResponsibilityKeeping).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.ResponsibilitySalary).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.RuleViolation).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.SalaryProfit).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.SalarySheetId)
                .HasMaxLength(20)
                .HasColumnName("SalarySheetID");
            entity.Property(e => e.SaleSalary).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.ShortOfMortgage).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.SocialInsuranceCom).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.SocialInsuranceEmp).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.TardinessLeaveEarlyPenalty).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.The13thMonthSalary).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.Time)
                .HasMaxLength(6)
                .HasDefaultValueSql("([dbo].[GetStringSysTime]())");
            entity.Property(e => e.TotalBenefit).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.TotalCostOfSalary).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.TransDate).HasMaxLength(8);
            entity.Property(e => e.UnemploymentInsuranceCom).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.UnemploymentInsuranceEmp).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.UnionExpenses).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.UnionExpensesEmp).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<HrSaleRate>(entity =>
        {
            entity.HasKey(e => new { e.SaleTime, e.DepartmentId }).HasName("PK_SaleRates");

            entity.Property(e => e.SaleTime)
                .HasMaxLength(8)
                .HasComment("Ngày hạch toán");
            entity.Property(e => e.DepartmentId)
                .HasMaxLength(50)
                .HasColumnName("DepartmentID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.SaleActual)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(22, 8)");
            entity.Property(e => e.SaleContract)
                .HasDefaultValueSql("((0))")
                .HasComment("Số tiền nguyên tệ")
                .HasColumnType("decimal(22, 8)");
            entity.Property(e => e.SaleRate)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(22, 8)");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<HrSaleSalary>(entity =>
        {
            entity.HasKey(e => e.SaleSalaryId);

            entity.Property(e => e.SaleSalaryId)
                .HasMaxLength(50)
                .HasColumnName("SaleSalaryID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.SaleSalaryName).HasMaxLength(100);
            entity.Property(e => e.SaleSalaryRate).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.SaleSalaryValue).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<HrTimeSheet>(entity =>
        {
            entity.HasKey(e => new { e.TimekeepingMonth, e.DepartmentId, e.CustomerId, e.TimekeepingDate });

            entity.Property(e => e.TimekeepingMonth)
                .HasMaxLength(8)
                .HasComment("Ngày hạch toán");
            entity.Property(e => e.DepartmentId)
                .HasMaxLength(50)
                .HasColumnName("DepartmentID");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(10)
                .HasColumnName("CustomerID");
            entity.Property(e => e.TimekeepingDate)
                .HasMaxLength(8)
                .HasComment("Ngày trong tháng");
            entity.Property(e => e.CheckForSalary)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DepartmentIdOvertime)
                .HasMaxLength(50)
                .HasDefaultValueSql("(newid())");
            entity.Property(e => e.OvertimeForSalary).HasComment("Thời gian đi muộn về sớm tính theo phút");
            entity.Property(e => e.SalaryRateOvertime).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.TardinessLeaveEarly).HasComment("Thời gian đi muộn về sớm tính theo phút");
            entity.Property(e => e.TardinessLeaveEarlyForSalary).HasComment("Thời gian đi muộn về sớm tính theo phút");
            entity.Property(e => e.TimeIn).HasMaxLength(6);
            entity.Property(e => e.TimeInOvertime).HasMaxLength(6);
            entity.Property(e => e.TimeOut)
                .HasMaxLength(6)
                .HasComment("");
            entity.Property(e => e.TimeOutOvertime)
                .HasMaxLength(6)
                .HasComment("");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<HrWorkSchedule>(entity =>
        {
            entity.HasKey(e => e.WorkScheduleId).HasName("PK_WorkSchedules");

            entity.Property(e => e.WorkScheduleId)
                .HasMaxLength(50)
                .HasColumnName("WorkScheduleID");
            entity.Property(e => e.BreakTimeEnd).HasMaxLength(6);
            entity.Property(e => e.BreakTimeStart).HasMaxLength(6);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.WorkScheduleIn).HasMaxLength(6);
            entity.Property(e => e.WorkScheduleName).HasMaxLength(100);
            entity.Property(e => e.WorkScheduleOut).HasMaxLength(6);
        });

        modelBuilder.Entity<HrWorkingTime>(entity =>
        {
            entity.HasKey(e => new { e.WorkingTime, e.DepartmentId });

            entity.Property(e => e.WorkingTime)
                .HasMaxLength(8)
                .HasComment("Ngày hạch toán");
            entity.Property(e => e.DepartmentId)
                .HasMaxLength(50)
                .HasColumnName("DepartmentID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.NumOfWorkingDay)
                .HasDefaultValueSql("((0))")
                .HasComment("Số tiền nguyên tệ");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<ImpExpAccountAlias>(entity =>
        {
            entity.HasKey(e => e.AccountItemAlias).HasName("PK_ImpExpAcountAlias");

            entity.ToTable("ImpExpAccountAlias");

            entity.Property(e => e.AccountItemAlias)
                .HasMaxLength(100)
                .HasComment("Định Danh khoản mục hạch toán");
            entity.Property(e => e.AccountItemAliasId)
                .HasDefaultValueSql("(newid())")
                .HasComment("Định Danh khoản mục hạch toán")
                .HasColumnName("AccountItemAliasID");
            entity.Property(e => e.AccountItemName)
                .HasMaxLength(500)
                .HasComment("Tên khoản mục hạch toán");
            entity.Property(e => e.ColumnCode)
                .HasMaxLength(100)
                .HasComment("Tên Cột trong bảng");
            entity.Property(e => e.ColumnName)
                .HasMaxLength(100)
                .HasComment("Tên Cột trong bảng");
            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.TableName)
                .HasMaxLength(100)
                .HasComment("Bảng dữ liệu");
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<ImpExpMethod>(entity =>
        {
            entity.ToTable("ImpExpMethod");

            entity.Property(e => e.ImpExpMethodId)
                .HasDefaultValueSql("(newid())")
                .HasComment("Key Mã phương thức nhập xuất")
                .HasColumnName("ImpExpMethodID");
            entity.Property(e => e.CostFormula)
                .HasMaxLength(1000)
                .HasComment("Công thức tính giá vốn");
            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ImpExpMethodCode)
                .HasMaxLength(50)
                .HasComment("Mã phương thức Nhập xuất");
            entity.Property(e => e.ImpExpMethodGroupId)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasComment("Mã nhóm phương thức nhập xuất.")
                .HasColumnName("ImpExpMethodGroupID");
            entity.Property(e => e.ImpExpMethodName)
                .HasMaxLength(500)
                .HasComment("Tên phương thức nhập xuất.");
            entity.Property(e => e.ImpExpMethodType)
                .HasMaxLength(10)
                .HasDefaultValueSql("('NK')")
                .HasComment("Loại phương thức nhập xuất.");
            entity.Property(e => e.OrderOnBook)
                .HasDefaultValueSql("((0))")
                .HasComment("Thứ tự trên sổ.");
            entity.Property(e => e.RevenueFormula)
                .HasMaxLength(1000)
                .HasComment("Công thức tính doanh thu");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.Type)
                .HasDefaultValueSql("((0))")
                .HasComment("Loại phương thức, mặc định là 0- phương thức nhập xuất, 1- phương thức kết chuyển");
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<ImpExpMethodDetail>(entity =>
        {
            entity.HasKey(e => new { e.ImpExpMethodId, e.ImExpMethodCode, e.AccountItemAlias });

            entity.Property(e => e.ImpExpMethodId)
                .HasComment("Key Mã phương thức nhập xuất")
                .HasColumnName("ImpExpMethodID");
            entity.Property(e => e.ImExpMethodCode)
                .HasMaxLength(50)
                .HasComment("Mã phương thức Nhập xuất");
            entity.Property(e => e.AccountItemAlias).HasMaxLength(100);
            entity.Property(e => e.AccountItemAliasId)
                .HasComment("Định Danh khoản mục hạch toán")
                .HasColumnName("AccountItemAliasID");
            entity.Property(e => e.AccountItemName).HasMaxLength(500);
            entity.Property(e => e.ColumnName).HasMaxLength(100);
            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreditAccount)
                .HasMaxLength(20)
                .HasComment("Tài khoản có");
            entity.Property(e => e.CreditAccountList)
                .HasMaxLength(2000)
                .HasComment("Tài khoản có");
            entity.Property(e => e.DebitAccount)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("Tài khoản nợ");
            entity.Property(e => e.DebitAccountList)
                .HasMaxLength(2000)
                .HasComment("Tài khoản có");
            entity.Property(e => e.IsCostAccount)
                .HasMaxLength(1)
                .HasDefaultValueSql("((0))")
                .IsFixedLength()
                .HasComment("Tài khoản chính: 1 là tài khoản chính,0 Không phải");
            entity.Property(e => e.IsMainAccount)
                .HasMaxLength(1)
                .HasDefaultValueSql("((0))")
                .IsFixedLength()
                .HasComment("Tài khoản chính: 1 là tài khoản chính,0 Không phải");
            entity.Property(e => e.Orders)
                .HasDefaultValueSql("((0))")
                .HasComment("thứ tự tài khoản");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<ImpExpMethodGroup>(entity =>
        {
            entity.Property(e => e.ImpExpMethodGroupId)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasComment("Mã nhóm phương thức nhập xuất.")
                .HasColumnName("ImpExpMethodGroupID");
            entity.Property(e => e.ImpExpMethodGroupName)
                .HasMaxLength(500)
                .HasComment("Tên nhóm phương thức nhập xuất.");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
        });

        modelBuilder.Entity<ImpExpMethodReport>(entity =>
        {
            entity.HasKey(e => new { e.ImpExpMethodId, e.ReportId });

            entity.Property(e => e.ImpExpMethodId)
                .HasDefaultValueSql("(newid())")
                .HasComment("Key Mã phương thức nhập xuất")
                .HasColumnName("ImpExpMethodID");
            entity.Property(e => e.ReportId)
                .HasDefaultValueSql("(newid())")
                .HasComment("Mã report")
                .HasColumnName("ReportID");
            entity.Property(e => e.ReportAlias)
                .HasMaxLength(50)
                .HasComment("Viết tắt report");
            entity.Property(e => e.ReportName)
                .HasMaxLength(200)
                .HasComment("Tên Report");
        });

        modelBuilder.Entity<ImpExpMethodType>(entity =>
        {
            entity.HasKey(e => e.ImpExpMethodType1);

            entity.ToTable("ImpExpMethodType");

            entity.Property(e => e.ImpExpMethodType1)
                .HasMaxLength(10)
                .HasDefaultValueSql("('NK')")
                .HasComment("Loại phương thức nhập xuất.")
                .HasColumnName("ImpExpMethodType");
            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ImpExpMethodName).HasMaxLength(500);
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<Incident>(entity =>
        {
            entity.HasKey(e => new { e.ZoneId, e.IncidentId, e.IncidentSign });

            entity.ToTable("Incident");

            entity.Property(e => e.ZoneId)
                .HasMaxLength(2)
                .HasColumnName("ZoneID");
            entity.Property(e => e.IncidentId)
                .HasDefaultValueSql("(newid())")
                .HasComment("Mã ID vụ việc")
                .HasColumnName("IncidentID");
            entity.Property(e => e.IncidentSign).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description)
                .HasMaxLength(1000)
                .HasComment("Mô tả vụ việc");
            entity.Property(e => e.IncidentGroupId)
                .HasComment("Mã ID chi phí")
                .HasColumnName("IncidentGroupID");
            entity.Property(e => e.IncidentName).HasMaxLength(500);
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<IncidentGroup>(entity =>
        {
            entity.HasKey(e => new { e.IncidentGroupId, e.ZoneId });

            entity.ToTable("IncidentGroup");

            entity.Property(e => e.IncidentGroupId)
                .HasDefaultValueSql("(newid())")
                .HasComment("Mã ID chi phí")
                .HasColumnName("IncidentGroupID");
            entity.Property(e => e.ZoneId)
                .HasMaxLength(2)
                .HasColumnName("ZoneID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description)
                .HasMaxLength(1000)
                .HasComment("Mô tả chi phí");
            entity.Property(e => e.IncidentGroupName)
                .HasMaxLength(200)
                .HasComment("Tên chi phí");
            entity.Property(e => e.IncidentGroupSign)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasComment("Kí Hiệu viết tắt mã chi phí");
            entity.Property(e => e.ParentIncidentGroupId)
                .HasComment("Mã ID Chi Phí Cha")
                .HasColumnName("ParentIncidentGroupID");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<Inventory>(entity =>
        {
            entity.HasKey(e => new { e.StockId, e.ZoneId, e.GoodId, e.FullGoodId });

            entity.ToTable("INVENTORY");

            entity.Property(e => e.StockId)
                .HasMaxLength(5)
                .HasColumnName("StockID");
            entity.Property(e => e.ZoneId)
                .HasMaxLength(2)
                .HasColumnName("ZoneID");
            entity.Property(e => e.GoodId)
                .HasMaxLength(9)
                .HasColumnName("GoodID");
            entity.Property(e => e.FullGoodId)
                .HasMaxLength(13)
                .HasColumnName("FullGoodID");
            entity.Property(e => e.AverPrice).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.AverPriceVat).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(10)
                .HasColumnName("CustomerID");
            entity.Property(e => e.Total).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.Totalamountvat).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.Totalvat).HasColumnType("decimal(22, 8)");
        });

        modelBuilder.Entity<Inventorylastday>(entity =>
        {
            entity.HasKey(e => new { e.StockId, e.ZoneId, e.GoodId, e.FullGoodId });

            entity.ToTable("INVENTORYLASTDAY");

            entity.Property(e => e.StockId)
                .HasMaxLength(5)
                .HasColumnName("StockID");
            entity.Property(e => e.ZoneId)
                .HasMaxLength(2)
                .HasColumnName("ZoneID");
            entity.Property(e => e.GoodId)
                .HasMaxLength(9)
                .HasColumnName("GoodID");
            entity.Property(e => e.FullGoodId)
                .HasMaxLength(13)
                .HasColumnName("FullGoodID");
            entity.Property(e => e.AverPrice).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.AverPriceVat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(10)
                .HasColumnName("CustomerID");
            entity.Property(e => e.Total).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Totalamountvat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Totalvat).HasColumnType("decimal(18, 6)");
        });

        modelBuilder.Entity<Inventorymark20190601>(entity =>
        {
            entity.HasKey(e => new { e.StockId, e.ZoneId, e.GoodId, e.FullGoodId });

            entity.ToTable("inventorymark_20190601");

            entity.Property(e => e.StockId)
                .HasMaxLength(5)
                .HasColumnName("StockID");
            entity.Property(e => e.ZoneId)
                .HasMaxLength(2)
                .HasColumnName("ZoneID");
            entity.Property(e => e.GoodId)
                .HasMaxLength(9)
                .HasColumnName("GoodID");
            entity.Property(e => e.FullGoodId)
                .HasMaxLength(13)
                .HasColumnName("FullGoodID");
            entity.Property(e => e.AverPrice).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.AverPriceVat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(10)
                .HasColumnName("CustomerID");
            entity.Property(e => e.Total).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Totalamountvat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Totalvat).HasColumnType("decimal(18, 6)");
        });

        modelBuilder.Entity<Inventorymark20200701>(entity =>
        {
            entity.HasKey(e => new { e.StockId, e.ZoneId, e.GoodId, e.FullGoodId });

            entity.ToTable("inventorymark_20200701");

            entity.Property(e => e.StockId)
                .HasMaxLength(5)
                .HasColumnName("StockID");
            entity.Property(e => e.ZoneId)
                .HasMaxLength(2)
                .HasColumnName("ZoneID");
            entity.Property(e => e.GoodId)
                .HasMaxLength(9)
                .HasColumnName("GoodID");
            entity.Property(e => e.FullGoodId)
                .HasMaxLength(13)
                .HasColumnName("FullGoodID");
            entity.Property(e => e.AverPrice).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.AverPriceVat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(10)
                .HasColumnName("CustomerID");
            entity.Property(e => e.Total).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Totalamountvat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Totalvat).HasColumnType("decimal(18, 6)");
        });

        modelBuilder.Entity<Inventorymark20200801>(entity =>
        {
            entity.HasKey(e => new { e.StockId, e.ZoneId, e.GoodId, e.FullGoodId });

            entity.ToTable("inventorymark_20200801");

            entity.Property(e => e.StockId)
                .HasMaxLength(5)
                .HasColumnName("StockID");
            entity.Property(e => e.ZoneId)
                .HasMaxLength(2)
                .HasColumnName("ZoneID");
            entity.Property(e => e.GoodId)
                .HasMaxLength(9)
                .HasColumnName("GoodID");
            entity.Property(e => e.FullGoodId)
                .HasMaxLength(13)
                .HasColumnName("FullGoodID");
            entity.Property(e => e.AverPrice).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.AverPriceVat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(10)
                .HasColumnName("CustomerID");
            entity.Property(e => e.Total).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Totalamountvat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Totalvat).HasColumnType("decimal(18, 6)");
        });

        modelBuilder.Entity<Inventorymark20200901>(entity =>
        {
            entity.HasKey(e => new { e.StockId, e.ZoneId, e.GoodId, e.FullGoodId });

            entity.ToTable("inventorymark_20200901");

            entity.Property(e => e.StockId)
                .HasMaxLength(5)
                .HasColumnName("StockID");
            entity.Property(e => e.ZoneId)
                .HasMaxLength(2)
                .HasColumnName("ZoneID");
            entity.Property(e => e.GoodId)
                .HasMaxLength(9)
                .HasColumnName("GoodID");
            entity.Property(e => e.FullGoodId)
                .HasMaxLength(13)
                .HasColumnName("FullGoodID");
            entity.Property(e => e.AverPrice).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.AverPriceVat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(10)
                .HasColumnName("CustomerID");
            entity.Property(e => e.Total).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Totalamountvat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Totalvat).HasColumnType("decimal(18, 6)");
        });

        modelBuilder.Entity<Inventorymark20201001>(entity =>
        {
            entity.HasKey(e => new { e.StockId, e.ZoneId, e.GoodId, e.FullGoodId });

            entity.ToTable("inventorymark_20201001");

            entity.Property(e => e.StockId)
                .HasMaxLength(5)
                .HasColumnName("StockID");
            entity.Property(e => e.ZoneId)
                .HasMaxLength(2)
                .HasColumnName("ZoneID");
            entity.Property(e => e.GoodId)
                .HasMaxLength(9)
                .HasColumnName("GoodID");
            entity.Property(e => e.FullGoodId)
                .HasMaxLength(13)
                .HasColumnName("FullGoodID");
            entity.Property(e => e.AverPrice).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.AverPriceVat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(10)
                .HasColumnName("CustomerID");
            entity.Property(e => e.Total).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Totalamountvat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Totalvat).HasColumnType("decimal(18, 6)");
        });

        modelBuilder.Entity<Inventorymark20201101>(entity =>
        {
            entity.HasKey(e => new { e.StockId, e.ZoneId, e.GoodId, e.FullGoodId });

            entity.ToTable("inventorymark_20201101");

            entity.Property(e => e.StockId)
                .HasMaxLength(5)
                .HasColumnName("StockID");
            entity.Property(e => e.ZoneId)
                .HasMaxLength(2)
                .HasColumnName("ZoneID");
            entity.Property(e => e.GoodId)
                .HasMaxLength(9)
                .HasColumnName("GoodID");
            entity.Property(e => e.FullGoodId)
                .HasMaxLength(13)
                .HasColumnName("FullGoodID");
            entity.Property(e => e.AverPrice).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.AverPriceVat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(10)
                .HasColumnName("CustomerID");
            entity.Property(e => e.Total).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Totalamountvat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Totalvat).HasColumnType("decimal(18, 6)");
        });

        modelBuilder.Entity<Inventorymark20201201>(entity =>
        {
            entity.HasKey(e => new { e.StockId, e.ZoneId, e.GoodId, e.FullGoodId });

            entity.ToTable("inventorymark_20201201");

            entity.Property(e => e.StockId)
                .HasMaxLength(5)
                .HasColumnName("StockID");
            entity.Property(e => e.ZoneId)
                .HasMaxLength(2)
                .HasColumnName("ZoneID");
            entity.Property(e => e.GoodId)
                .HasMaxLength(9)
                .HasColumnName("GoodID");
            entity.Property(e => e.FullGoodId)
                .HasMaxLength(13)
                .HasColumnName("FullGoodID");
            entity.Property(e => e.AverPrice).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.AverPriceVat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(10)
                .HasColumnName("CustomerID");
            entity.Property(e => e.Total).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Totalamountvat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Totalvat).HasColumnType("decimal(18, 6)");
        });

        modelBuilder.Entity<Inventorymark20210101>(entity =>
        {
            entity.HasKey(e => new { e.StockId, e.ZoneId, e.GoodId, e.FullGoodId });

            entity.ToTable("inventorymark_20210101");

            entity.Property(e => e.StockId)
                .HasMaxLength(5)
                .HasColumnName("StockID");
            entity.Property(e => e.ZoneId)
                .HasMaxLength(2)
                .HasColumnName("ZoneID");
            entity.Property(e => e.GoodId)
                .HasMaxLength(9)
                .HasColumnName("GoodID");
            entity.Property(e => e.FullGoodId)
                .HasMaxLength(13)
                .HasColumnName("FullGoodID");
            entity.Property(e => e.AverPrice).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.AverPriceVat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(10)
                .HasColumnName("CustomerID");
            entity.Property(e => e.Total).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Totalamountvat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Totalvat).HasColumnType("decimal(18, 6)");
        });

        modelBuilder.Entity<Inventorymark20210201>(entity =>
        {
            entity.HasKey(e => new { e.StockId, e.ZoneId, e.GoodId, e.FullGoodId });

            entity.ToTable("inventorymark_20210201");

            entity.Property(e => e.StockId)
                .HasMaxLength(5)
                .HasColumnName("StockID");
            entity.Property(e => e.ZoneId)
                .HasMaxLength(2)
                .HasColumnName("ZoneID");
            entity.Property(e => e.GoodId)
                .HasMaxLength(9)
                .HasColumnName("GoodID");
            entity.Property(e => e.FullGoodId)
                .HasMaxLength(13)
                .HasColumnName("FullGoodID");
            entity.Property(e => e.AverPrice).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.AverPriceVat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(10)
                .HasColumnName("CustomerID");
            entity.Property(e => e.Total).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Totalamountvat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Totalvat).HasColumnType("decimal(18, 6)");
        });

        modelBuilder.Entity<Inventorymark20210301>(entity =>
        {
            entity.HasKey(e => new { e.StockId, e.ZoneId, e.GoodId, e.FullGoodId });

            entity.ToTable("inventorymark_20210301");

            entity.Property(e => e.StockId)
                .HasMaxLength(5)
                .HasColumnName("StockID");
            entity.Property(e => e.ZoneId)
                .HasMaxLength(2)
                .HasColumnName("ZoneID");
            entity.Property(e => e.GoodId)
                .HasMaxLength(9)
                .HasColumnName("GoodID");
            entity.Property(e => e.FullGoodId)
                .HasMaxLength(13)
                .HasColumnName("FullGoodID");
            entity.Property(e => e.AverPrice).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.AverPriceVat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(10)
                .HasColumnName("CustomerID");
            entity.Property(e => e.Total).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Totalamountvat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Totalvat).HasColumnType("decimal(18, 6)");
        });

        modelBuilder.Entity<Inventorymark20210401>(entity =>
        {
            entity.HasKey(e => new { e.StockId, e.ZoneId, e.GoodId, e.FullGoodId });

            entity.ToTable("inventorymark_20210401");

            entity.Property(e => e.StockId)
                .HasMaxLength(5)
                .HasColumnName("StockID");
            entity.Property(e => e.ZoneId)
                .HasMaxLength(2)
                .HasColumnName("ZoneID");
            entity.Property(e => e.GoodId)
                .HasMaxLength(9)
                .HasColumnName("GoodID");
            entity.Property(e => e.FullGoodId)
                .HasMaxLength(13)
                .HasColumnName("FullGoodID");
            entity.Property(e => e.AverPrice).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.AverPriceVat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(10)
                .HasColumnName("CustomerID");
            entity.Property(e => e.Total).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Totalamountvat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Totalvat).HasColumnType("decimal(18, 6)");
        });

        modelBuilder.Entity<Inventorymark20210501>(entity =>
        {
            entity.HasKey(e => new { e.StockId, e.ZoneId, e.GoodId, e.FullGoodId });

            entity.ToTable("inventorymark_20210501");

            entity.Property(e => e.StockId)
                .HasMaxLength(5)
                .HasColumnName("StockID");
            entity.Property(e => e.ZoneId)
                .HasMaxLength(2)
                .HasColumnName("ZoneID");
            entity.Property(e => e.GoodId)
                .HasMaxLength(9)
                .HasColumnName("GoodID");
            entity.Property(e => e.FullGoodId)
                .HasMaxLength(13)
                .HasColumnName("FullGoodID");
            entity.Property(e => e.AverPrice).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.AverPriceVat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(10)
                .HasColumnName("CustomerID");
            entity.Property(e => e.Total).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Totalamountvat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Totalvat).HasColumnType("decimal(18, 6)");
        });

        modelBuilder.Entity<Inventorymark20210601>(entity =>
        {
            entity.HasKey(e => new { e.StockId, e.ZoneId, e.GoodId, e.FullGoodId });

            entity.ToTable("inventorymark_20210601");

            entity.Property(e => e.StockId)
                .HasMaxLength(5)
                .HasColumnName("StockID");
            entity.Property(e => e.ZoneId)
                .HasMaxLength(2)
                .HasColumnName("ZoneID");
            entity.Property(e => e.GoodId)
                .HasMaxLength(9)
                .HasColumnName("GoodID");
            entity.Property(e => e.FullGoodId)
                .HasMaxLength(13)
                .HasColumnName("FullGoodID");
            entity.Property(e => e.AverPrice).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.AverPriceVat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(10)
                .HasColumnName("CustomerID");
            entity.Property(e => e.Total).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Totalamountvat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Totalvat).HasColumnType("decimal(18, 6)");
        });

        modelBuilder.Entity<Inventorymark20210701>(entity =>
        {
            entity.HasKey(e => new { e.StockId, e.ZoneId, e.GoodId, e.FullGoodId }).HasName("[PK_INVENTORYMARK_20210701]");

            entity.ToTable("INVENTORYMARK_20210701");

            entity.Property(e => e.StockId)
                .HasMaxLength(5)
                .HasColumnName("StockID");
            entity.Property(e => e.ZoneId)
                .HasMaxLength(2)
                .HasColumnName("ZoneID");
            entity.Property(e => e.GoodId)
                .HasMaxLength(9)
                .HasColumnName("GoodID");
            entity.Property(e => e.FullGoodId)
                .HasMaxLength(13)
                .HasColumnName("FullGoodID");
            entity.Property(e => e.AverPrice).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.AverPriceVat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(10)
                .HasColumnName("CustomerID");
            entity.Property(e => e.Total).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Totalamountvat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Totalvat).HasColumnType("decimal(18, 6)");
        });

        modelBuilder.Entity<Inventorymark20210801>(entity =>
        {
            entity.HasKey(e => new { e.StockId, e.ZoneId, e.GoodId, e.FullGoodId }).HasName("[PK_INVENTORYMARK_20210801]");

            entity.ToTable("INVENTORYMARK_20210801");

            entity.Property(e => e.StockId)
                .HasMaxLength(5)
                .HasColumnName("StockID");
            entity.Property(e => e.ZoneId)
                .HasMaxLength(2)
                .HasColumnName("ZoneID");
            entity.Property(e => e.GoodId)
                .HasMaxLength(9)
                .HasColumnName("GoodID");
            entity.Property(e => e.FullGoodId)
                .HasMaxLength(13)
                .HasColumnName("FullGoodID");
            entity.Property(e => e.AverPrice).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.AverPriceVat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(10)
                .HasColumnName("CustomerID");
            entity.Property(e => e.Total).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Totalamountvat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Totalvat).HasColumnType("decimal(18, 6)");
        });

        modelBuilder.Entity<Inventorymark20210901>(entity =>
        {
            entity.HasKey(e => new { e.StockId, e.ZoneId, e.GoodId, e.FullGoodId }).HasName("[PK_INVENTORYMARK_20210901]");

            entity.ToTable("INVENTORYMARK_20210901");

            entity.Property(e => e.StockId)
                .HasMaxLength(5)
                .HasColumnName("StockID");
            entity.Property(e => e.ZoneId)
                .HasMaxLength(2)
                .HasColumnName("ZoneID");
            entity.Property(e => e.GoodId)
                .HasMaxLength(9)
                .HasColumnName("GoodID");
            entity.Property(e => e.FullGoodId)
                .HasMaxLength(13)
                .HasColumnName("FullGoodID");
            entity.Property(e => e.AverPrice).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.AverPriceVat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(10)
                .HasColumnName("CustomerID");
            entity.Property(e => e.Total).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Totalamountvat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Totalvat).HasColumnType("decimal(18, 6)");
        });

        modelBuilder.Entity<Inventorymark20211001>(entity =>
        {
            entity.HasKey(e => new { e.StockId, e.ZoneId, e.GoodId, e.FullGoodId }).HasName("[PK_INVENTORYMARK_20211001]");

            entity.ToTable("INVENTORYMARK_20211001");

            entity.Property(e => e.StockId)
                .HasMaxLength(5)
                .HasColumnName("StockID");
            entity.Property(e => e.ZoneId)
                .HasMaxLength(2)
                .HasColumnName("ZoneID");
            entity.Property(e => e.GoodId)
                .HasMaxLength(9)
                .HasColumnName("GoodID");
            entity.Property(e => e.FullGoodId)
                .HasMaxLength(13)
                .HasColumnName("FullGoodID");
            entity.Property(e => e.AverPrice).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.AverPriceVat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(10)
                .HasColumnName("CustomerID");
            entity.Property(e => e.Total).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Totalamountvat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Totalvat).HasColumnType("decimal(18, 6)");
        });

        modelBuilder.Entity<Inventorymark20211014>(entity =>
        {
            entity.HasKey(e => new { e.StockId, e.ZoneId, e.GoodId, e.FullGoodId }).HasName("[PK_INVENTORYMARK_20211014]");

            entity.ToTable("INVENTORYMARK_20211014");

            entity.Property(e => e.StockId)
                .HasMaxLength(5)
                .HasColumnName("StockID");
            entity.Property(e => e.ZoneId)
                .HasMaxLength(2)
                .HasColumnName("ZoneID");
            entity.Property(e => e.GoodId)
                .HasMaxLength(9)
                .HasColumnName("GoodID");
            entity.Property(e => e.FullGoodId)
                .HasMaxLength(13)
                .HasColumnName("FullGoodID");
            entity.Property(e => e.AverPrice).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.AverPriceVat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(10)
                .HasColumnName("CustomerID");
            entity.Property(e => e.Total).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Totalamountvat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Totalvat).HasColumnType("decimal(18, 6)");
        });

        modelBuilder.Entity<Inventorymark20211201>(entity =>
        {
            entity.HasKey(e => new { e.StockId, e.ZoneId, e.GoodId, e.FullGoodId }).HasName("[PK_INVENTORYMARK_20211201]");

            entity.ToTable("INVENTORYMARK_20211201");

            entity.Property(e => e.StockId)
                .HasMaxLength(5)
                .HasColumnName("StockID");
            entity.Property(e => e.ZoneId)
                .HasMaxLength(2)
                .HasColumnName("ZoneID");
            entity.Property(e => e.GoodId)
                .HasMaxLength(9)
                .HasColumnName("GoodID");
            entity.Property(e => e.FullGoodId)
                .HasMaxLength(13)
                .HasColumnName("FullGoodID");
            entity.Property(e => e.AverPrice).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.AverPriceVat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(10)
                .HasColumnName("CustomerID");
            entity.Property(e => e.Total).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Totalamountvat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Totalvat).HasColumnType("decimal(18, 6)");
        });

        modelBuilder.Entity<Inventorymark20220101>(entity =>
        {
            entity.HasKey(e => new { e.StockId, e.ZoneId, e.GoodId, e.FullGoodId }).HasName("[PK_INVENTORYMARK_20220101]");

            entity.ToTable("INVENTORYMARK_20220101");

            entity.Property(e => e.StockId)
                .HasMaxLength(5)
                .HasColumnName("StockID");
            entity.Property(e => e.ZoneId)
                .HasMaxLength(2)
                .HasColumnName("ZoneID");
            entity.Property(e => e.GoodId)
                .HasMaxLength(9)
                .HasColumnName("GoodID");
            entity.Property(e => e.FullGoodId)
                .HasMaxLength(13)
                .HasColumnName("FullGoodID");
            entity.Property(e => e.AverPrice).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.AverPriceVat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(10)
                .HasColumnName("CustomerID");
            entity.Property(e => e.Total).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Totalamountvat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Totalvat).HasColumnType("decimal(18, 6)");
        });

        modelBuilder.Entity<Inventorymark20220805>(entity =>
        {
            entity.HasKey(e => new { e.StockId, e.ZoneId, e.GoodId, e.FullGoodId }).HasName("[PK_INVENTORYMARK_20220805]");

            entity.ToTable("INVENTORYMARK_20220805");

            entity.Property(e => e.StockId)
                .HasMaxLength(5)
                .HasColumnName("StockID");
            entity.Property(e => e.ZoneId)
                .HasMaxLength(2)
                .HasColumnName("ZoneID");
            entity.Property(e => e.GoodId)
                .HasMaxLength(9)
                .HasColumnName("GoodID");
            entity.Property(e => e.FullGoodId)
                .HasMaxLength(13)
                .HasColumnName("FullGoodID");
            entity.Property(e => e.AverPrice).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.AverPriceVat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(10)
                .HasColumnName("CustomerID");
            entity.Property(e => e.Total).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Totalamountvat).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Totalvat).HasColumnType("decimal(18, 6)");
        });

        modelBuilder.Entity<Inventorystart>(entity =>
        {
            entity.HasKey(e => new { e.StockId, e.ZoneId, e.GoodId, e.FullGoodId }).HasName("PK_inventorystart");

            entity.ToTable("Inventorystart");

            entity.Property(e => e.StockId)
                .HasMaxLength(5)
                .HasColumnName("StockID");
            entity.Property(e => e.ZoneId)
                .HasMaxLength(2)
                .HasColumnName("ZoneID");
            entity.Property(e => e.GoodId)
                .HasMaxLength(9)
                .HasColumnName("GoodID");
            entity.Property(e => e.FullGoodId)
                .HasMaxLength(13)
                .HasColumnName("FullGoodID");
            entity.Property(e => e.AverPrice).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.AverPriceVat).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.BranchId)
                .HasMaxLength(5)
                .HasColumnName("BranchID");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(5)
                .HasColumnName("CustomerID");
            entity.Property(e => e.Datestart).HasMaxLength(8);
            entity.Property(e => e.GroupId)
                .HasMaxLength(6)
                .HasColumnName("GroupID");
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.Total).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.Totalamountvat).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.Totalvat).HasColumnType("decimal(22, 8)");
        });

        modelBuilder.Entity<ListScale>(entity =>
        {
            entity.HasKey(e => new { e.Itemcode, e.GoodId });

            entity.ToTable("ListScale");

            entity.Property(e => e.Itemcode).HasMaxLength(5);
            entity.Property(e => e.GoodId)
                .HasMaxLength(9)
                .HasColumnName("GoodID");
            entity.Property(e => e.ExpPrice).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.ExpPriceVat)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("ExpPriceVAT");
            entity.Property(e => e.StorageTemp).HasMaxLength(100);
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");

            entity.HasOne(d => d.Good).WithMany(p => p.ListScales)
                .HasForeignKey(d => d.GoodId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ListScale_Goods");
        });

        modelBuilder.Entity<ListShelf>(entity =>
        {
            entity.HasKey(e => new { e.ShelfId, e.StockId, e.GoodId, e.ZoneId });

            entity.Property(e => e.ShelfId)
                .HasMaxLength(4)
                .HasColumnName("ShelfID");
            entity.Property(e => e.StockId)
                .HasMaxLength(5)
                .HasColumnName("StockID");
            entity.Property(e => e.GoodId)
                .HasMaxLength(9)
                .HasColumnName("GoodID");
            entity.Property(e => e.ZoneId)
                .HasMaxLength(2)
                .HasColumnName("ZoneID");
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");

            entity.HasOne(d => d.Stock).WithMany(p => p.ListShelves)
                .HasForeignKey(d => d.StockId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ListShelves_Stocks");
        });

        modelBuilder.Entity<ListVat>(entity =>
        {
            entity.HasKey(e => e.VatId);

            entity.ToTable("ListVat");

            entity.Property(e => e.VatId)
                .HasMaxLength(2)
                .HasColumnName("VatID");
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.VatName).HasMaxLength(50);
        });

        modelBuilder.Entity<Log>(entity =>
        {
            entity.Property(e => e.LogId)
                .HasMaxLength(50)
                .HasComment("gom: DDMMYYYYHHMMSSMLS")
                .HasColumnName("LogID");
            entity.Property(e => e.ControlId)
                .HasMaxLength(50)
                .HasColumnName("ControlID");
            entity.Property(e => e.DateLog)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FormId)
                .HasMaxLength(100)
                .HasColumnName("FormID");
            entity.Property(e => e.StationId)
                .HasMaxLength(3)
                .HasColumnName("StationID");
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.UserId)
                .HasMaxLength(4)
                .HasColumnName("UserID");
            entity.Property(e => e.ZoneId)
                .HasMaxLength(2)
                .HasColumnName("ZoneID");
        });

        modelBuilder.Entity<LogDetail>(entity =>
        {
            entity.HasKey(e => e.LogId);

            entity.ToTable("LogDetail");

            entity.Property(e => e.LogId)
                .HasMaxLength(50)
                .HasColumnName("LogID");
            entity.Property(e => e.LogContent).HasColumnType("ntext");
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");

            entity.HasOne(d => d.Log).WithOne(p => p.LogDetail)
                .HasForeignKey<LogDetail>(d => d.LogId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LogDetail_Logs");
        });

        modelBuilder.Entity<Manufacture>(entity =>
        {
            entity.Property(e => e.ManufactureId)
                .HasMaxLength(4)
                .HasColumnName("ManufactureID");
            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ManufactureName).HasMaxLength(100);
            entity.Property(e => e.Note).HasMaxLength(200);
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<Menu>(entity =>
        {
            entity.HasKey(e => e.MenuId).HasName("PK_Menus_1");

            entity.Property(e => e.MenuId)
                .HasMaxLength(50)
                .HasColumnName("MenuID");
            entity.Property(e => e.Icon).HasMaxLength(100);
            entity.Property(e => e.MenuName).HasMaxLength(100);
            entity.Property(e => e.Note).HasMaxLength(200);
            entity.Property(e => e.PmenuId)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))")
                .HasColumnName("PMenuID");
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
        });

        modelBuilder.Entity<Mpermission>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.MenuId, e.ZoneId });

            entity.ToTable("MPermission");

            entity.Property(e => e.UserId)
                .HasMaxLength(5)
                .HasColumnName("UserID");
            entity.Property(e => e.MenuId)
                .HasMaxLength(50)
                .HasColumnName("MenuID");
            entity.Property(e => e.ZoneId)
                .HasMaxLength(2)
                .HasColumnName("ZoneID");
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");

            entity.HasOne(d => d.Menu).WithMany(p => p.Mpermissions)
                .HasForeignKey(d => d.MenuId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MPermission_Menus");

            entity.HasOne(d => d.User).WithMany(p => p.Mpermissions)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MPermission_Users");

            entity.HasOne(d => d.Zone).WithMany(p => p.Mpermissions)
                .HasForeignKey(d => d.ZoneId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MPermission_Zones");
        });

        modelBuilder.Entity<NegTransDetail>(entity =>
        {
            entity.HasKey(e => new { e.TransDetailId, e.TransactionId, e.AuTranId, e.FullGoodId, e.BigUnitId, e.ImportId, e.ExportId }).HasName("PK_NegTransDetail_1");

            entity.ToTable("NegTransDetail");

            entity.Property(e => e.TransDetailId).HasColumnName("TransDetailID");
            entity.Property(e => e.TransactionId)
                .HasMaxLength(20)
                .HasColumnName("TransactionID");
            entity.Property(e => e.AuTranId)
                .HasMaxLength(20)
                .HasColumnName("AuTranID");
            entity.Property(e => e.FullGoodId)
                .HasMaxLength(13)
                .HasColumnName("FullGoodID");
            entity.Property(e => e.BigUnitId)
                .HasMaxLength(5)
                .HasColumnName("BigUnitID");
            entity.Property(e => e.ImportId)
                .HasMaxLength(10)
                .HasColumnName("ImportID");
            entity.Property(e => e.ExportId)
                .HasMaxLength(10)
                .HasColumnName("ExportID");
            entity.Property(e => e.BranchId)
                .HasMaxLength(5)
                .HasColumnName("BranchID");
            entity.Property(e => e.CostCreditAccount)
                .HasMaxLength(20)
                .HasComment("TK có thuế GTGT");
            entity.Property(e => e.CostDebitAccount)
                .HasMaxLength(20)
                .HasComment("TK Nợ thuế GTGT");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreditAccount)
                .HasMaxLength(20)
                .HasComment("TK Có");
            entity.Property(e => e.CreditTaxVataccount)
                .HasMaxLength(20)
                .HasComment("TK có thuế GTGT")
                .HasColumnName("CreditTaxVATAccount");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(10)
                .HasColumnName("CustomerID");
            entity.Property(e => e.DebitAccount)
                .HasMaxLength(20)
                .HasComment("TK Nợ");
            entity.Property(e => e.DebitTaxVataccount)
                .HasMaxLength(20)
                .HasComment("TK Nợ thuế GTGT")
                .HasColumnName("DebitTaxVATAccount");
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.ExchangeRate).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.ExpPrice).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.ExpPriceVat)
                .HasColumnType("decimal(22, 8)")
                .HasColumnName("ExpPriceVAT");
            entity.Property(e => e.ExpiredDate)
                .HasMaxLength(8)
                .HasDefaultValueSql("('')")
                .HasComment("Hạn Sử dụng");
            entity.Property(e => e.FeeAmount)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(22, 8)");
            entity.Property(e => e.FeeAmountVat)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(22, 8)")
                .HasColumnName("FeeAmountVAT");
            entity.Property(e => e.GoodId)
                .HasMaxLength(9)
                .HasColumnName("GoodID");
            entity.Property(e => e.GroupId)
                .HasMaxLength(6)
                .HasColumnName("GroupID");
            entity.Property(e => e.ImpPrice).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.ImpPriceVat)
                .HasColumnType("decimal(22, 8)")
                .HasColumnName("ImpPriceVAT");
            entity.Property(e => e.ItemId).HasColumnName("ItemID");
            entity.Property(e => e.LotNumber)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("Số Lô");
            entity.Property(e => e.NegativeQuatity).HasDefaultValueSql("((0))");
            entity.Property(e => e.NegativeStatus)
                .HasMaxLength(1)
                .HasDefaultValueSql("((0))")
                .IsFixedLength();
            entity.Property(e => e.Nqtyimp)
                .HasDefaultValueSql("((0))")
                .HasColumnName("NQTYIMP");
            entity.Property(e => e.OrginalQty).HasDefaultValueSql("((0))");
            entity.Property(e => e.PriceOrg).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.PriceVatOrg).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.Profit).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.TaxVatAmount).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.TaxVatRate)
                .HasDefaultValueSql("((0))")
                .HasComment("Thuế suất GTGT")
                .HasColumnType("decimal(22, 8)");
            entity.Property(e => e.Time)
                .HasMaxLength(6)
                .HasDefaultValueSql("([dbo].[GetStringSysTime]())");
            entity.Property(e => e.TotalExpPrice).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.TotalExpPriceVat)
                .HasColumnType("decimal(22, 8)")
                .HasColumnName("TotalExpPriceVAT");
            entity.Property(e => e.TotalImpPrice).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.TotalImpPriceVat)
                .HasColumnType("decimal(22, 8)")
                .HasColumnName("TotalImpPriceVAT");
            entity.Property(e => e.TotalPriceOrg)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(22, 8)");
            entity.Property(e => e.TotalPriceVatorg)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(22, 8)")
                .HasColumnName("TotalPriceVATOrg");
            entity.Property(e => e.TotalVat)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(22, 8)")
                .HasColumnName("TotalVAT");
            entity.Property(e => e.TransDate).HasMaxLength(8);
            entity.Property(e => e.UnitId)
                .HasMaxLength(5)
                .HasColumnName("UnitID");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.VatId)
                .HasMaxLength(2)
                .HasColumnName("VatID");
            entity.Property(e => e.ZoneId)
                .HasMaxLength(2)
                .HasColumnName("ZoneID");
        });

        modelBuilder.Entity<ObjectCategory>(entity =>
        {
            entity.HasKey(e => e.ObjectId);

            entity.ToTable("ObjectCategory");

            entity.Property(e => e.ObjectId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("ObjectID");
            entity.Property(e => e.CategoryOnTableId)
                .HasMaxLength(50)
                .HasColumnName("CategoryOnTableID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Note).HasMaxLength(200);
            entity.Property(e => e.ObjectCategoryCode).HasMaxLength(50);
            entity.Property(e => e.ObjectCategoryName).HasMaxLength(200);
            entity.Property(e => e.Prefix).HasMaxLength(5);
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.TableName).HasMaxLength(100);
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.OrderId).HasName("PK_Orders_1");

            entity.Property(e => e.OrderId).HasMaxLength(30);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DeliveryDate).HasMaxLength(8);
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.ObjOrderId).HasMaxLength(10);
            entity.Property(e => e.ObjOrderName).HasMaxLength(100);
            entity.Property(e => e.OrderDate).HasMaxLength(8);
            entity.Property(e => e.OrderType).HasMaxLength(2);
            entity.Property(e => e.OrdersStatus).HasMaxLength(2);
            entity.Property(e => e.StaffInChargeId)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')")
                .HasComment("Nhân viên phụ trách")
                .HasColumnName("StaffInChargeID");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SupplierId).HasMaxLength(10);
            entity.Property(e => e.SupplierName).HasMaxLength(100);
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.TotalDiscount).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.TotalPrice).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.TotalPriceVat)
                .HasColumnType("decimal(22, 8)")
                .HasColumnName("TotalPriceVAT");
            entity.Property(e => e.TotalVat)
                .HasColumnType("decimal(22, 8)")
                .HasColumnName("TotalVAT");
            entity.Property(e => e.TransCode)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.TransDate).HasMaxLength(8);
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UserId)
                .HasMaxLength(5)
                .HasColumnName("UserID");
            entity.Property(e => e.ZoneAdress).HasMaxLength(200);
            entity.Property(e => e.ZoneId).HasMaxLength(2);
            entity.Property(e => e.ZoneName).HasMaxLength(100);
        });

        modelBuilder.Entity<OrderConditionSchedule>(entity =>
        {
            entity.HasKey(e => new { e.CustomerId, e.OrderValues });

            entity.ToTable("OrderConditionSchedule");

            entity.Property(e => e.CustomerId)
                .HasMaxLength(10)
                .HasColumnName("CustomerID");
            entity.Property(e => e.OrderValues).HasMaxLength(400);
            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EnableSchedule).HasDefaultValueSql("((0))");
            entity.Property(e => e.OrderConditionType).HasMaxLength(20);
            entity.Property(e => e.ScheduleType)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.ScheduleValue).HasMaxLength(100);
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<OrderDetail>(entity =>
        {
            entity.HasKey(e => new { e.OrderId, e.StockId, e.GoodId, e.BigUnitId });

            entity.ToTable("OrderDetail");

            entity.Property(e => e.OrderId).HasMaxLength(30);
            entity.Property(e => e.StockId).HasMaxLength(10);
            entity.Property(e => e.GoodId)
                .HasMaxLength(9)
                .HasColumnName("GoodID");
            entity.Property(e => e.BigUnitId)
                .HasMaxLength(5)
                .HasColumnName("BigUnitID");
            entity.Property(e => e.BranchId)
                .HasMaxLength(5)
                .HasColumnName("BranchID");
            entity.Property(e => e.CheckedBy).HasMaxLength(5);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DiscountAmount)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(22, 8)");
            entity.Property(e => e.DiscountRate).HasDefaultValueSql("((0))");
            entity.Property(e => e.ExchangeRate).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.GroupId)
                .HasMaxLength(6)
                .HasColumnName("GroupID");
            entity.Property(e => e.ImpPrice).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.ImpPriceVat)
                .HasColumnType("decimal(22, 8)")
                .HasColumnName("ImpPriceVAT");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.Time)
                .HasMaxLength(6)
                .HasDefaultValueSql("([dbo].[GetStringSysTime]())");
            entity.Property(e => e.TotalImpPrice).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.TotalImpPriceVat)
                .HasColumnType("decimal(22, 8)")
                .HasColumnName("TotalImpPriceVAT");
            entity.Property(e => e.TransDate).HasMaxLength(8);
            entity.Property(e => e.UnitId)
                .HasMaxLength(5)
                .HasColumnName("UnitID");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.VatId)
                .HasMaxLength(2)
                .HasDefaultValueSql("((0))")
                .HasColumnName("VatID");
        });

        modelBuilder.Entity<OrganizationUnit>(entity =>
        {
            entity.ToTable("OrganizationUnit", tb => tb.HasComment("Bảng lưu chi nhánh/phòng ban"));

            entity.Property(e => e.OrganizationUnitId)
                .HasDefaultValueSql("(newid())")
                .HasComment("PK")
                .HasColumnName("OrganizationUnitID");
            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .HasComment("Địa chỉ");
            entity.Property(e => e.BranchId)
                .HasComment("Chi nhánh")
                .HasColumnName("BranchID");
            entity.Property(e => e.BusinessRegistrationNumber)
                .HasMaxLength(50)
                .HasComment("Số đăng ký kinh doanh");
            entity.Property(e => e.BusinessRegistrationNumberIssuedDate)
                .HasComment("Ngày cấp")
                .HasColumnType("datetime");
            entity.Property(e => e.BusinessRegistrationNumberIssuedPlace)
                .HasMaxLength(255)
                .HasComment("Nơi cấp");
            entity.Property(e => e.CashierName)
                .HasMaxLength(50)
                .HasComment("Tên Thủ quỹ");
            entity.Property(e => e.CashierTitle)
                .HasMaxLength(50)
                .HasComment("Tiêu đề người ký là Thủ quỹ");
            entity.Property(e => e.ChiefOfAccountingName)
                .HasMaxLength(50)
                .HasComment("Tên Kế toán trưởng");
            entity.Property(e => e.ChiefOfAccountingTitle)
                .HasMaxLength(50)
                .HasComment("Tiêu đề người ký là Kế toán trưởng");
            entity.Property(e => e.CompanyBankAccountId)
                .HasComment("Tài khoản ngân hàng")
                .HasColumnName("CompanyBankAccountID");
            entity.Property(e => e.CompanyCity).HasMaxLength(100);
            entity.Property(e => e.CompanyDistrict).HasMaxLength(100);
            entity.Property(e => e.CompanyEmail)
                .HasMaxLength(100)
                .HasComment("Email");
            entity.Property(e => e.CompanyFax)
                .HasMaxLength(50)
                .HasComment("Fax");
            entity.Property(e => e.CompanyOwnerName)
                .HasMaxLength(128)
                .HasComment("Tên đơn vị chủ quản");
            entity.Property(e => e.CompanyOwnerTaxCode)
                .HasMaxLength(50)
                .HasComment("Mã số thuế đơn vị chủ quản");
            entity.Property(e => e.CompanyTaxCode)
                .HasMaxLength(50)
                .HasComment("Mã số thuế");
            entity.Property(e => e.CompanyTel)
                .HasMaxLength(50)
                .HasComment("Số điện thoại");
            entity.Property(e => e.CompanyWebsite)
                .HasMaxLength(100)
                .HasComment("Website");
            entity.Property(e => e.CostAccount)
                .HasMaxLength(20)
                .HasComment("Tài khoản chi phí lương");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DirectorName)
                .HasMaxLength(50)
                .HasComment("Tên giám đốc");
            entity.Property(e => e.DirectorTitle)
                .HasMaxLength(50)
                .HasComment("Tiêu đề người ký là giám đốc");
            entity.Property(e => e.Grade).HasDefaultValueSql("((1))");
            entity.Property(e => e.Inactive).HasComment("Ngừng theo dõi");
            entity.Property(e => e.IsDependent)
                .HasDefaultValueSql("((1))")
                .HasComment("0 = Hạch toán độc lập; 1 = Hạch toán  phụ thuộc");
            entity.Property(e => e.IsGetReporterNameByUserLogIn).HasComment("Lấy tên người lập biểu theo tên người đăng nhập");
            entity.Property(e => e.IsParent).HasComment("Là đơn vị cha");
            entity.Property(e => e.IsPrintSigner).HasComment("In tên người ký lên chứng từ, báo cáo");
            entity.Property(e => e.IsPrivateVatdeclaration)
                .HasComment("Kê khai thuế giá trị gia tăng riêng")
                .HasColumnName("IsPrivateVATDeclaration");
            entity.Property(e => e.IsSystem).HasComment("Thuộc hệ thống");
            entity.Property(e => e.MisacodeId)
                .HasMaxLength(100)
                .HasColumnName("MISACodeID");
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.OrganizationUnitCode)
                .HasMaxLength(20)
                .HasComment("Mã đơn vị");
            entity.Property(e => e.OrganizationUnitName)
                .HasMaxLength(128)
                .HasComment("Tên đơn vị");
            entity.Property(e => e.OrganizationUnitTypeId)
                .HasDefaultValueSql("((6))")
                .HasComment("Cấp tổ chức: 1 - Tổng công ty; 2 - Chi nhánh; 3 - VP/TT; 4 - Phòng ban; 5- Phân xưởng; 6 - Nhóm/Tổ,hội")
                .HasColumnName("OrganizationUnitTypeID");
            entity.Property(e => e.ParentId)
                .HasComment("ID đơn vị cha")
                .HasColumnName("ParentID");
            entity.Property(e => e.ReporterName)
                .HasMaxLength(50)
                .HasComment("Tên Người lập biểu");
            entity.Property(e => e.ReporterTitle)
                .HasMaxLength(50)
                .HasComment("Tiêu đề người ký là Người lập biểu");
            entity.Property(e => e.SortMisacodeId)
                .HasMaxLength(100)
                .HasComment("Cột dùng để sort trên báo cáo. Không sử dụng trên giao diện.")
                .HasColumnName("SortMISACodeID");
            entity.Property(e => e.StoreKeeperName)
                .HasMaxLength(50)
                .HasComment("Tên thủ kho");
            entity.Property(e => e.StoreKeeperTitle)
                .HasMaxLength(50)
                .HasComment("Tiêu đề người ký là Thủ kho");
        });

        modelBuilder.Entity<OriginalTransaction>(entity =>
        {
            entity.HasKey(e => new { e.TransactionId, e.CustomerId });

            entity.Property(e => e.TransactionId)
                .HasMaxLength(20)
                .HasColumnName("TransactionID");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(5)
                .HasColumnName("CustomerID");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Debt).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.Have).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.OrgTransType)
                .HasMaxLength(4)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.TransDate).HasMaxLength(8);
        });

        modelBuilder.Entity<OriginalTransactionRefer>(entity =>
        {
            entity.HasKey(e => new { e.VouchersId, e.TransactionId });

            entity.ToTable("OriginalTransactionRefer");

            entity.Property(e => e.VouchersId)
                .HasMaxLength(20)
                .HasColumnName("VouchersID");
            entity.Property(e => e.TransactionId)
                .HasMaxLength(20)
                .HasComment("Số giao dịch liên quan")
                .HasColumnName("TransactionID");
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.TransactionDate).HasMaxLength(8);
            entity.Property(e => e.Type)
                .HasMaxLength(20)
                .HasDefaultValueSql("((0))")
                .HasComment("Loại  giao dịch liên quan.");
            entity.Property(e => e.Value).HasColumnType("decimal(22, 8)");
        });

        modelBuilder.Entity<OuterTran>(entity =>
        {
            entity.HasKey(e => e.ExpTranId);

            entity.Property(e => e.ExpTranId)
                .HasMaxLength(20)
                .HasColumnName("ExpTranID");
            entity.Property(e => e.ExportId)
                .HasMaxLength(10)
                .HasColumnName("ExportID");
            entity.Property(e => e.ImpTranId)
                .HasMaxLength(20)
                .HasColumnName("ImpTranID");
            entity.Property(e => e.ImportId)
                .HasMaxLength(10)
                .HasColumnName("ImportID");
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.TranStatus)
                .HasMaxLength(1)
                .HasDefaultValueSql("((0))")
                .IsFixedLength()
                .HasComment("Trạng thái điều chuyển ngoài vùng (sang kho trung chuyển) 0: chưa nhận hàng; 1: đã nhận hàng");
        });

        modelBuilder.Entity<Packet>(entity =>
        {
            entity.Property(e => e.PacketId)
                .HasMaxLength(8)
                .HasColumnName("PacketID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.PacketName).HasMaxLength(50);
            entity.Property(e => e.PacketType).HasMaxLength(1);
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.TotalRetailDiscount).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.TotalRetailPrice).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.TotalRetailPriceVat)
                .HasColumnType("decimal(22, 8)")
                .HasColumnName("TotalRetailPriceVAT");
            entity.Property(e => e.TotalWholesaleDiscount).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.TotalWholesalePrice).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.TotalWholesalePriceVat)
                .HasColumnType("decimal(22, 8)")
                .HasColumnName("TotalWholesalePriceVAT");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ZoneId)
                .HasMaxLength(2)
                .HasColumnName("ZoneID");
        });

        modelBuilder.Entity<PacketDetail>(entity =>
        {
            entity.HasKey(e => new { e.PacketId, e.FullGoodId, e.BigUnitId });

            entity.ToTable("PacketDetail");

            entity.Property(e => e.PacketId)
                .HasMaxLength(8)
                .HasColumnName("PacketID");
            entity.Property(e => e.FullGoodId)
                .HasMaxLength(13)
                .HasColumnName("FullGoodID");
            entity.Property(e => e.BigUnitId)
                .HasMaxLength(5)
                .HasDefaultValueSql("((1))")
                .HasColumnName("BigUnitID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Discount).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.ExchangeRate).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.GoodId)
                .HasMaxLength(9)
                .HasColumnName("GoodID");
            entity.Property(e => e.ItemId)
                .ValueGeneratedOnAdd()
                .HasColumnName("ItemID");
            entity.Property(e => e.RetailPrice).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.RetailPriceVat)
                .HasColumnType("decimal(22, 8)")
                .HasColumnName("RetailPriceVAT");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.UnitId)
                .HasMaxLength(5)
                .HasDefaultValueSql("((1))")
                .HasColumnName("UnitID");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.WholesaleDiscount).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.WholesalePrice).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.WholesalePriceVat)
                .HasColumnType("decimal(22, 8)")
                .HasColumnName("WholesalePriceVAT");

            entity.HasOne(d => d.Packet).WithMany(p => p.PacketDetails)
                .HasForeignKey(d => d.PacketId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PacketDetail_Packets");
        });

        modelBuilder.Entity<Permission>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.FormId, e.ControlId, e.ZoneId });

            entity.ToTable("Permission");

            entity.Property(e => e.UserId)
                .HasMaxLength(5)
                .HasColumnName("UserID");
            entity.Property(e => e.FormId)
                .HasMaxLength(100)
                .HasColumnName("FormID");
            entity.Property(e => e.ControlId)
                .HasMaxLength(50)
                .HasColumnName("ControlID");
            entity.Property(e => e.ZoneId)
                .HasMaxLength(2)
                .HasColumnName("ZoneID");
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");

            entity.HasOne(d => d.Control).WithMany(p => p.Permissions)
                .HasForeignKey(d => d.ControlId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Permission_Controls");

            entity.HasOne(d => d.Form).WithMany(p => p.Permissions)
                .HasForeignKey(d => d.FormId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Permission_Forms");

            entity.HasOne(d => d.User).WithMany(p => p.Permissions)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Permission_Users");

            entity.HasOne(d => d.Zone).WithMany(p => p.Permissions)
                .HasForeignKey(d => d.ZoneId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Permission_Zones");
        });

        modelBuilder.Entity<Price>(entity =>
        {
            entity.HasKey(e => new { e.ZoneId, e.GoodId });

            entity.Property(e => e.ZoneId)
                .HasMaxLength(2)
                .HasColumnName("ZoneID");
            entity.Property(e => e.GoodId)
                .HasMaxLength(9)
                .HasColumnName("GoodID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ExpRetailPrice).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.ExpRetailPriceVat).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.ExpWholePrice).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.ExpWholePriceVat).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Good).WithMany(p => p.Prices)
                .HasForeignKey(d => d.GoodId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Prices_Goods");

            entity.HasOne(d => d.Zone).WithMany(p => p.Prices)
                .HasForeignKey(d => d.ZoneId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Prices_Zones");
        });

        modelBuilder.Entity<ProGroup>(entity =>
        {
            entity.HasKey(e => e.GroupId).HasName("PK_Groups");

            entity.Property(e => e.GroupId)
                .HasMaxLength(6)
                .HasColumnName("GroupID");
            entity.Property(e => e.BranchId)
                .HasMaxLength(5)
                .HasColumnName("BranchID");
            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.GroupName).HasMaxLength(100);
            entity.Property(e => e.MaxPercentRetailPrice).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.MaxPercentWhole).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.MinPercentRetailPrice).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.MinPercentWhole).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.Note).HasMaxLength(200);
            entity.Property(e => e.PercentRetailPrice).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.PercentWhole).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.PgroupId)
                .HasMaxLength(6)
                .HasDefaultValueSql("((0))")
                .HasColumnName("PGroupID");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Branch).WithMany(p => p.ProGroups)
                .HasForeignKey(d => d.BranchId)
                .HasConstraintName("FK_PGroups_Branches");
        });

        modelBuilder.Entity<Promotion>(entity =>
        {
            entity.ToTable("Promotion");

            entity.Property(e => e.PromotionId)
                .HasMaxLength(20)
                .HasColumnName("PromotionID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FromDate).HasMaxLength(8);
            entity.Property(e => e.FromTime).HasMaxLength(6);
            entity.Property(e => e.PromoApplyForSale)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasComment("1 cho bán lẻ, 2 cho bán buôn, 3 cho cả bán lẻ và bán buôn");
            entity.Property(e => e.PromoInclude).HasComment("1 là bao gồm với các khuyến mại khác nếu có, 1 là không tính cùng các KM khác nếu đồng thời có nhiều chương trình Khuyến mại");
            entity.Property(e => e.PromotionName).HasMaxLength(200);
            entity.Property(e => e.PromotionType)
                .HasMaxLength(20)
                .HasComment("có 4 loại 1 là hàng tặng hàng, 2 là hàng tặng tiền, 3 là đơn đạt một giá trị nào đó (PromoValues) tặng tiền, 4 là đơn đạt một giá trị nào đó (PromoValues) tặng hàng");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.ToDate).HasMaxLength(8);
            entity.Property(e => e.ToTime).HasMaxLength(6);
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<PromotionByZone>(entity =>
        {
            entity.HasKey(e => new { e.PromotionId, e.ZoneId });

            entity.ToTable("PromotionByZone");

            entity.Property(e => e.PromotionId)
                .HasMaxLength(20)
                .HasColumnName("PromotionID");
            entity.Property(e => e.ZoneId)
                .HasMaxLength(2)
                .HasColumnName("ZoneID");
        });

        modelBuilder.Entity<PromotionDetail>(entity =>
        {
            entity.HasKey(e => new { e.PromotionId, e.PromoCode, e.PromoPayCode });

            entity.Property(e => e.PromotionId)
                .HasMaxLength(20)
                .HasColumnName("PromotionID");
            entity.Property(e => e.PromoCode)
                .HasMaxLength(200)
                .HasComment("giá trị mã hàng hoặc mã nhóm, mã ngành, mã NCC được khuyến mại");
            entity.Property(e => e.PromoPayCode)
                .HasMaxLength(200)
                .HasDefaultValueSql("((0))")
                .HasComment("Nếu là KM bằng hàng thì mã hàng sẽ được tặng.");
            entity.Property(e => e.PromoPayMaxValues)
                .HasMaxLength(200)
                .HasDefaultValueSql("((0))")
                .HasComment("Số lượng hoặc giá trị tối đa được tặng nếu để là 0 nghĩa là không giới hạn.");
            entity.Property(e => e.PromoPayStock)
                .HasMaxLength(4000)
                .HasDefaultValueSql("((0))")
                .HasComment("Mã kho xuất hàng khuyến mại ở trường PromoPayCode nếu là khuyến mại hàng tặng hàng.");
            entity.Property(e => e.PromoPayValues)
                .HasMaxLength(200)
                .HasDefaultValueSql("((0))")
                .HasComment("Số lượng hàng được tặng nếu là KM hàng tặng hàng, giá trị tiền hoặc % giảm giá nếu là hàng tặng tiền.");
            entity.Property(e => e.PromoTypeDetail)
                .HasMaxLength(50)
                .HasComment("có các giá trị: KM theo Mã hàng, Ngành Hàng, Nhóm Hàng, Nhà cung cấp");
            entity.Property(e => e.PromoValues)
                .HasMaxLength(200)
                .HasDefaultValueSql("((0))")
                .HasComment("Nội dung được Khuyến mại, nếu là khyến mại bằng tiền thì điền số tiền nếu đạt sẽ được khuyến mại, nếu là khuyến mại bằng hàng thì điền số lượng hàng đạt sẽ được khuyến mại");
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
        });

        modelBuilder.Entity<Provision>(entity =>
        {
            entity.HasKey(e => new { e.ProvisionId, e.ZoneId });

            entity.ToTable("Provision");

            entity.Property(e => e.ProvisionId)
                .HasDefaultValueSql("(newid())")
                .HasComment("Mã ID chi phí")
                .HasColumnName("ProvisionID");
            entity.Property(e => e.ZoneId)
                .HasMaxLength(2)
                .HasColumnName("ZoneID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description)
                .HasMaxLength(1000)
                .HasComment("Mô tả chi phí");
            entity.Property(e => e.ProvisionName).HasMaxLength(200);
            entity.Property(e => e.ProvisionSign).HasMaxLength(50);
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<QtyMinMax>(entity =>
        {
            entity.HasKey(e => e.QtyMinMaxId).HasName("PK_QtyMinmax1");

            entity.ToTable("QtyMinMax");

            entity.Property(e => e.QtyMinMaxId).HasMaxLength(6);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EndDate).HasMaxLength(8);
            entity.Property(e => e.QtyMinMaxName).HasMaxLength(100);
            entity.Property(e => e.StartDate).HasMaxLength(8);
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<QtyMinMaxDetail>(entity =>
        {
            entity.HasKey(e => new { e.QtyMinMaxId, e.ZoneId, e.StockId, e.GoodId }).HasName("PK_MinMax");

            entity.ToTable("QtyMinMaxDetail");

            entity.Property(e => e.QtyMinMaxId).HasMaxLength(6);
            entity.Property(e => e.ZoneId)
                .HasMaxLength(2)
                .HasColumnName("ZoneID");
            entity.Property(e => e.StockId)
                .HasMaxLength(5)
                .HasColumnName("StockID");
            entity.Property(e => e.GoodId)
                .HasMaxLength(9)
                .HasColumnName("GoodID");
            entity.Property(e => e.OrderInGeneral)
                .HasDefaultValueSql("((1))")
                .HasComment("0: CK trước thuế; 1: CK sau thuế");
            entity.Property(e => e.QtyMax).HasDefaultValueSql("((0))");
            entity.Property(e => e.QtyMin).HasDefaultValueSql("((0))");
            entity.Property(e => e.RoundBigUnit)
                .HasDefaultValueSql("((0))")
                .HasComment("0: CK trước thuế; 1: CK sau thuế");
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");

            entity.HasOne(d => d.Good).WithMany(p => p.QtyMinMaxDetails)
                .HasForeignKey(d => d.GoodId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_QtyMinMax_Goods");

            entity.HasOne(d => d.Stock).WithMany(p => p.QtyMinMaxDetails)
                .HasForeignKey(d => d.StockId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_QtyMinMax_Stocks");

            entity.HasOne(d => d.Zone).WithMany(p => p.QtyMinMaxDetails)
                .HasForeignKey(d => d.ZoneId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_QtyMinMax_Zones");
        });

        modelBuilder.Entity<ReRetailTransDetail>(entity =>
        {
            entity.HasKey(e => new { e.TransactionId, e.FullGoodId, e.BigUnitId, e.PacketId }).HasName("PK_ReTransDetail_1");

            entity.ToTable("ReRetailTransDetail");

            entity.Property(e => e.TransactionId)
                .HasMaxLength(20)
                .HasColumnName("TransactionID");
            entity.Property(e => e.FullGoodId)
                .HasMaxLength(13)
                .HasColumnName("FullGoodID");
            entity.Property(e => e.BigUnitId)
                .HasMaxLength(5)
                .HasColumnName("BigUnitID");
            entity.Property(e => e.PacketId)
                .HasMaxLength(10)
                .HasColumnName("PacketID");
            entity.Property(e => e.GoodId)
                .HasMaxLength(9)
                .HasColumnName("GoodID");
            entity.Property(e => e.ItemId)
                .ValueGeneratedOnAdd()
                .HasColumnName("ItemID");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");

            entity.HasOne(d => d.Transaction).WithMany(p => p.ReRetailTransDetails)
                .HasForeignKey(d => d.TransactionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReTransDetail_RetailTrans");

            entity.HasOne(d => d.TransactionNavigation).WithMany(p => p.ReRetailTransDetails)
                .HasForeignKey(d => d.TransactionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReTransDetail_Transactions");
        });

        modelBuilder.Entity<ReportCategory>(entity =>
        {
            entity.HasKey(e => e.ReportId).HasName("PK_Reportcategory");

            entity.ToTable("ReportCategory");

            entity.Property(e => e.ReportId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("ReportID");
            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ReportAlias)
                .HasMaxLength(50)
                .HasComment("Viết tắt");
            entity.Property(e => e.ReportName)
                .HasMaxLength(200)
                .HasComment("Tên Report");
            entity.Property(e => e.ReportPath).HasMaxLength(1000);
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<RetailRateByGroupId>(entity =>
        {
            entity.HasKey(e => new { e.GroupId, e.PercentRetailPrice });

            entity.ToTable("RetailRateByGroupID");

            entity.Property(e => e.GroupId)
                .HasMaxLength(6)
                .HasColumnName("GroupID");
            entity.Property(e => e.PercentRetailPrice)
                .HasDefaultValueSql("((11))")
                .HasColumnType("decimal(22, 8)");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'auto')");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.MaxImpPrice)
                .HasDefaultValueSql("((1000))")
                .HasColumnType("money");
            entity.Property(e => e.MaxPercentRetailPrice)
                .HasDefaultValueSql("((12))")
                .HasColumnType("decimal(22, 8)");
            entity.Property(e => e.MaxPercentWhole)
                .HasDefaultValueSql("((12))")
                .HasColumnType("decimal(22, 8)");
            entity.Property(e => e.MinImpPrice).HasColumnType("money");
            entity.Property(e => e.MinPercentRetailPrice)
                .HasDefaultValueSql("((10))")
                .HasColumnType("decimal(22, 8)");
            entity.Property(e => e.MinPercentWhole)
                .HasDefaultValueSql("((10))")
                .HasColumnType("decimal(22, 8)");
            entity.Property(e => e.PercentWhole)
                .HasDefaultValueSql("((11))")
                .HasColumnType("decimal(22, 8)");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .HasDefaultValueSql("((1))")
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .HasDefaultValueSql("((1))")
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'auto')");
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<RetailTran>(entity =>
        {
            entity.HasKey(e => e.TransactionId);

            entity.Property(e => e.TransactionId)
                .HasMaxLength(20)
                .HasColumnName("TransactionID");
            entity.Property(e => e.ContractId)
                .HasComment("PK  hợp đồng bán")
                .HasColumnName("ContractID");
            entity.Property(e => e.CostFormula)
                .HasMaxLength(1000)
                .HasComment("Công thức tính giá vốn");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CurrencyId)
                .HasMaxLength(3)
                .HasComment("Loại tiền")
                .HasColumnName("CurrencyID");
            entity.Property(e => e.CurrencyIdoc)
                .HasMaxLength(3)
                .HasComment("Loại tiền")
                .HasColumnName("CurrencyIDOC");
            entity.Property(e => e.Deliver).HasMaxLength(200);
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.DueDate)
                .HasComment("Ngày thanh toán")
                .HasColumnType("datetime");
            entity.Property(e => e.DueTime).HasComment("Hạn thanh toán (bao nhiêu ngày)");
            entity.Property(e => e.ExchangeRate)
                .HasComment("Tỉ giá hối đoái")
                .HasColumnType("decimal(22, 8)");
            entity.Property(e => e.ExportId)
                .HasMaxLength(10)
                .HasColumnName("ExportID");
            entity.Property(e => e.FormNo)
                .HasMaxLength(20)
                .HasComment("Mau so hoa don");
            entity.Property(e => e.ImpExpMethodCode)
                .HasMaxLength(50)
                .HasComment("Mã phương thức Nhập xuất");
            entity.Property(e => e.ImpExpMethodId)
                .HasDefaultValueSql("(newid())")
                .HasComment("Key Mã phương thức nhập xuất")
                .HasColumnName("ImpExpMethodID");
            entity.Property(e => e.ImpExpMethodName)
                .HasMaxLength(500)
                .HasComment("Tên phương thức nhập xuất.");
            entity.Property(e => e.ImportId)
                .HasMaxLength(10)
                .HasColumnName("ImportID");
            entity.Property(e => e.OrgPrice).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.ReceiptNo).HasMaxLength(50);
            entity.Property(e => e.Receiver).HasMaxLength(200);
            entity.Property(e => e.RevenueFormula)
                .HasMaxLength(1000)
                .HasComment("Công thức tính doanh thu");
            entity.Property(e => e.StaffInChargeId)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')")
                .HasComment("Nhân viên phụ trách")
                .HasColumnName("StaffInChargeID");
            entity.Property(e => e.StationId)
                .HasMaxLength(5)
                .HasColumnName("StationID");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .HasDefaultValueSql("((0))")
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.TaxInvoice)
                .HasMaxLength(1)
                .HasDefaultValueSql("((0))")
                .IsFixedLength()
                .HasComment("Thông tin hóa đơn, 0 là không hóa đơn, 1 là có hóa đơn");
            entity.Property(e => e.TaxSign)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("Kí hiệu hóa đơn");
            entity.Property(e => e.TotalAmountOc)
                .HasComment("Tổng tiền hàng")
                .HasColumnType("decimal(22, 8)")
                .HasColumnName("TotalAmountOC");
            entity.Property(e => e.TotalBank).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.TotalCast).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.TotalDiscount).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.TotalDiscountOc)
                .HasComment("tong ck")
                .HasColumnType("decimal(22, 8)")
                .HasColumnName("TotalDiscountOC");
            entity.Property(e => e.TotalExpPrice).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.TotalExpPriceVat)
                .HasColumnType("decimal(22, 8)")
                .HasColumnName("TotalExpPriceVAT");
            entity.Property(e => e.TotalImpPrice).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.TotalImpPriceVat)
                .HasColumnType("decimal(22, 8)")
                .HasColumnName("TotalImpPriceVAT");
            entity.Property(e => e.TotalProfit).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.TransCode)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.TransDate).HasMaxLength(8);
            entity.Property(e => e.TransType).HasMaxLength(2);
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.VatDate)
                .HasMaxLength(20)
                .HasComment("Ngày hóa đơn");
            entity.Property(e => e.VatNo).HasMaxLength(20);
            entity.Property(e => e.ZoneId)
                .HasMaxLength(2)
                .HasColumnName("ZoneID");

            entity.HasOne(d => d.TransCodeNavigation).WithMany(p => p.RetailTrans)
                .HasForeignKey(d => d.TransCode)
                .HasConstraintName("FK_RetailTrans_TransType");

            entity.HasOne(d => d.Zone).WithMany(p => p.RetailTrans)
                .HasForeignKey(d => d.ZoneId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RetailTrans_Zones");
        });

        modelBuilder.Entity<RetailTranDetail>(entity =>
        {
            entity.HasKey(e => new { e.TransDetailId, e.TransactionId, e.AuTranId, e.FullGoodId, e.BigUnitId, e.ImportId, e.ExportId }).HasName("PK_RetailTranDetails");

            entity.ToTable("RetailTranDetail");

            entity.Property(e => e.TransDetailId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("TransDetailID");
            entity.Property(e => e.TransactionId)
                .HasMaxLength(20)
                .HasColumnName("TransactionID");
            entity.Property(e => e.AuTranId)
                .HasMaxLength(20)
                .HasColumnName("AuTranID");
            entity.Property(e => e.FullGoodId)
                .HasMaxLength(13)
                .HasColumnName("FullGoodID");
            entity.Property(e => e.BigUnitId)
                .HasMaxLength(5)
                .HasColumnName("BigUnitID");
            entity.Property(e => e.ImportId)
                .HasMaxLength(10)
                .HasColumnName("ImportID");
            entity.Property(e => e.ExportId)
                .HasMaxLength(10)
                .HasColumnName("ExportID");
            entity.Property(e => e.BranchId)
                .HasMaxLength(5)
                .HasColumnName("BranchID");
            entity.Property(e => e.CostCreditAccount)
                .HasMaxLength(20)
                .HasComment("TK có thuế GTGT");
            entity.Property(e => e.CostDebitAccount)
                .HasMaxLength(20)
                .HasComment("TK Nợ thuế GTGT");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreditAccount)
                .HasMaxLength(20)
                .HasComment("TK Có");
            entity.Property(e => e.CreditTaxVataccount)
                .HasMaxLength(20)
                .HasComment("TK có thuế GTGT")
                .HasColumnName("CreditTaxVATAccount");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(10)
                .HasColumnName("CustomerID");
            entity.Property(e => e.DebitAccount)
                .HasMaxLength(20)
                .HasComment("TK Nợ");
            entity.Property(e => e.DebitTaxVataccount)
                .HasMaxLength(20)
                .HasComment("TK Nợ thuế GTGT")
                .HasColumnName("DebitTaxVATAccount");
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.ExchangeRate).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.ExpPrice).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.ExpPriceVat)
                .HasColumnType("decimal(22, 8)")
                .HasColumnName("ExpPriceVAT");
            entity.Property(e => e.ExpiredDate)
                .HasMaxLength(8)
                .HasDefaultValueSql("('')")
                .HasComment("Hạn Sử dụng");
            entity.Property(e => e.FeeAmount)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(22, 8)");
            entity.Property(e => e.FeeAmountVat)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(22, 8)")
                .HasColumnName("FeeAmountVAT");
            entity.Property(e => e.GoodId)
                .HasMaxLength(9)
                .HasColumnName("GoodID");
            entity.Property(e => e.GroupId)
                .HasMaxLength(6)
                .HasColumnName("GroupID");
            entity.Property(e => e.ImpPrice).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.ImpPriceVat)
                .HasColumnType("decimal(22, 8)")
                .HasColumnName("ImpPriceVAT");
            entity.Property(e => e.ItemId)
                .ValueGeneratedOnAdd()
                .HasColumnName("ItemID");
            entity.Property(e => e.LotNumber)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("Số Lô");
            entity.Property(e => e.NegativeQuatity).HasDefaultValueSql("((0))");
            entity.Property(e => e.NegativeStatus)
                .HasMaxLength(1)
                .HasDefaultValueSql("((0))")
                .IsFixedLength();
            entity.Property(e => e.Nqtyimp)
                .HasDefaultValueSql("((0))")
                .HasColumnName("NQTYIMP");
            entity.Property(e => e.OrginalQty).HasDefaultValueSql("((0))");
            entity.Property(e => e.PriceOrg).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.PriceVatOrg).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.Profit).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.TaxVatAmount).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.TaxVatRate)
                .HasDefaultValueSql("((0))")
                .HasComment("Thuế suất GTGT")
                .HasColumnType("decimal(22, 8)");
            entity.Property(e => e.Time)
                .HasMaxLength(6)
                .HasDefaultValueSql("([dbo].[GetStringSysTime]())");
            entity.Property(e => e.TotalExpPrice).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.TotalExpPriceVat)
                .HasColumnType("decimal(22, 8)")
                .HasColumnName("TotalExpPriceVAT");
            entity.Property(e => e.TotalImpPrice).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.TotalImpPriceVat)
                .HasColumnType("decimal(22, 8)")
                .HasColumnName("TotalImpPriceVAT");
            entity.Property(e => e.TotalPriceOrg)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(22, 8)");
            entity.Property(e => e.TotalPriceVatorg)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(22, 8)")
                .HasColumnName("TotalPriceVATOrg");
            entity.Property(e => e.TotalVat)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(22, 8)")
                .HasColumnName("TotalVAT");
            entity.Property(e => e.TransDate).HasMaxLength(8);
            entity.Property(e => e.UnitId)
                .HasMaxLength(5)
                .HasColumnName("UnitID");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.VatId)
                .HasMaxLength(2)
                .HasColumnName("VatID");
            entity.Property(e => e.ZoneId)
                .HasMaxLength(2)
                .HasColumnName("ZoneID");

            entity.HasOne(d => d.Transaction).WithMany(p => p.RetailTranDetails)
                .HasForeignKey(d => d.TransactionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RetailTranDetail_RetailTrans");
        });

        modelBuilder.Entity<RetailTranDetailTemp>(entity =>
        {
            entity.HasKey(e => new { e.TransDetailId, e.TransactionId, e.AuTranId, e.FullGoodId, e.BigUnitId, e.ImportId, e.ExportId });

            entity.ToTable("RetailTranDetailTemp");

            entity.Property(e => e.TransDetailId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("TransDetailID");
            entity.Property(e => e.TransactionId)
                .HasMaxLength(20)
                .HasColumnName("TransactionID");
            entity.Property(e => e.AuTranId)
                .HasMaxLength(20)
                .HasColumnName("AuTranID");
            entity.Property(e => e.FullGoodId)
                .HasMaxLength(13)
                .HasColumnName("FullGoodID");
            entity.Property(e => e.BigUnitId)
                .HasMaxLength(5)
                .HasColumnName("BigUnitID");
            entity.Property(e => e.ImportId)
                .HasMaxLength(10)
                .HasColumnName("ImportID");
            entity.Property(e => e.ExportId)
                .HasMaxLength(10)
                .HasColumnName("ExportID");
            entity.Property(e => e.BranchId)
                .HasMaxLength(5)
                .HasColumnName("BranchID");
            entity.Property(e => e.CostCreditAccount)
                .HasMaxLength(20)
                .HasComment("TK có thuế GTGT");
            entity.Property(e => e.CostDebitAccount)
                .HasMaxLength(20)
                .HasComment("TK Nợ thuế GTGT");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreditAccount)
                .HasMaxLength(20)
                .HasComment("TK Có");
            entity.Property(e => e.CreditTaxVataccount)
                .HasMaxLength(20)
                .HasComment("TK có thuế GTGT")
                .HasColumnName("CreditTaxVATAccount");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(10)
                .HasColumnName("CustomerID");
            entity.Property(e => e.DebitAccount)
                .HasMaxLength(20)
                .HasComment("TK Nợ");
            entity.Property(e => e.DebitTaxVataccount)
                .HasMaxLength(20)
                .HasComment("TK Nợ thuế GTGT")
                .HasColumnName("DebitTaxVATAccount");
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.ExchangeRate).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.ExpPrice).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.ExpPriceVat)
                .HasColumnType("decimal(22, 8)")
                .HasColumnName("ExpPriceVAT");
            entity.Property(e => e.ExpriedDate)
                .HasMaxLength(8)
                .HasDefaultValueSql("('')")
                .HasComment("Hạn Sử dụng");
            entity.Property(e => e.FeeAmount)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(22, 8)");
            entity.Property(e => e.FeeAmountVat)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(22, 8)")
                .HasColumnName("FeeAmountVAT");
            entity.Property(e => e.GoodId)
                .HasMaxLength(9)
                .HasColumnName("GoodID");
            entity.Property(e => e.GroupId)
                .HasMaxLength(6)
                .HasColumnName("GroupID");
            entity.Property(e => e.ImpPrice).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.ImpPriceVat)
                .HasColumnType("decimal(22, 8)")
                .HasColumnName("ImpPriceVAT");
            entity.Property(e => e.ItemId)
                .ValueGeneratedOnAdd()
                .HasColumnName("ItemID");
            entity.Property(e => e.LotNumber)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("Số Lô");
            entity.Property(e => e.PriceOrg)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(22, 8)");
            entity.Property(e => e.PriceVatOrg)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(22, 8)");
            entity.Property(e => e.Profit).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.TaxVatAmount).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.TaxVatRate)
                .HasDefaultValueSql("((0))")
                .HasComment("Thuế suất GTGT")
                .HasColumnType("decimal(22, 8)");
            entity.Property(e => e.Time)
                .HasMaxLength(6)
                .HasDefaultValueSql("([dbo].[GetStringSysTime]())");
            entity.Property(e => e.TotalExpPrice).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.TotalExpPriceVat)
                .HasColumnType("decimal(22, 8)")
                .HasColumnName("TotalExpPriceVAT");
            entity.Property(e => e.TotalImpPrice).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.TotalImpPriceVat)
                .HasColumnType("decimal(22, 8)")
                .HasColumnName("TotalImpPriceVAT");
            entity.Property(e => e.TotalPriceOrg)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(22, 8)");
            entity.Property(e => e.TotalPriceVatorg)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(22, 8)")
                .HasColumnName("TotalPriceVATOrg");
            entity.Property(e => e.TotalVat)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(22, 8)")
                .HasColumnName("TotalVAT");
            entity.Property(e => e.TransDate).HasMaxLength(8);
            entity.Property(e => e.UnitId)
                .HasMaxLength(5)
                .HasColumnName("UnitID");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.VatId)
                .HasMaxLength(2)
                .HasColumnName("VatID");
            entity.Property(e => e.ZoneId)
                .HasMaxLength(2)
                .HasColumnName("ZoneID");

            entity.HasOne(d => d.Transaction).WithMany(p => p.RetailTranDetailTemps)
                .HasForeignKey(d => d.TransactionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RetailTranDetailTemp_RetailTransTemp");
        });

        modelBuilder.Entity<RetailTranPromoDetail>(entity =>
        {
            entity.HasKey(e => new { e.TransactionId, e.PromotionId, e.GoodId, e.PromoGoodId });

            entity.ToTable("RetailTranPromoDetail");

            entity.Property(e => e.TransactionId)
                .HasMaxLength(20)
                .HasColumnName("TransactionID");
            entity.Property(e => e.PromotionId)
                .HasMaxLength(20)
                .HasColumnName("PromotionID");
            entity.Property(e => e.GoodId)
                .HasMaxLength(9)
                .HasColumnName("GoodID");
            entity.Property(e => e.PromoGoodId)
                .HasMaxLength(9)
                .HasColumnName("PromoGoodID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(10)
                .HasColumnName("CustomerID");
            entity.Property(e => e.ExpPrice).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.ExpPriceVat)
                .HasColumnType("decimal(22, 8)")
                .HasColumnName("ExpPriceVAT");
            entity.Property(e => e.FullGoodId)
                .HasMaxLength(13)
                .HasColumnName("FullGoodID");
            entity.Property(e => e.ItemId)
                .ValueGeneratedOnAdd()
                .HasColumnName("ItemID");
            entity.Property(e => e.PromoTypeDetail)
                .HasMaxLength(50)
                .HasComment("có các giá trị: KM theo Mã hàng, Ngành Hàng, Nhóm Hàng, Nhà cung cấp");
            entity.Property(e => e.PromotionType)
                .HasMaxLength(20)
                .HasComment("có 4 loại 1 là hàng tặng hàng, 2 là hàng tặng tiền, 3 là đơn đạt một giá trị nào đó (PromoValues) tặng tiền, 4 là đơn đạt một giá trị nào đó (PromoValues) tặng hàng");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.Time)
                .HasMaxLength(6)
                .HasDefaultValueSql("([dbo].[GetStringSysTime]())");
            entity.Property(e => e.TotalExpPrice).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.TotalExpPriceVat)
                .HasColumnType("decimal(22, 8)")
                .HasColumnName("TotalExpPriceVAT");
            entity.Property(e => e.TotalVat)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(22, 8)")
                .HasColumnName("TotalVAT");
            entity.Property(e => e.TransDate).HasMaxLength(8);
            entity.Property(e => e.UnitId)
                .HasMaxLength(5)
                .HasColumnName("UnitID");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.VatId)
                .HasMaxLength(2)
                .HasColumnName("VatID");
            entity.Property(e => e.ZoneId)
                .HasMaxLength(2)
                .HasColumnName("ZoneID");
        });

        modelBuilder.Entity<RetailTransTemp>(entity =>
        {
            entity.HasKey(e => e.TransactionId);

            entity.ToTable("RetailTransTemp");

            entity.Property(e => e.TransactionId)
                .HasMaxLength(20)
                .HasColumnName("TransactionID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.ExportId)
                .HasMaxLength(10)
                .HasColumnName("ExportID");
            entity.Property(e => e.ImportId)
                .HasMaxLength(10)
                .HasColumnName("ImportID");
            entity.Property(e => e.OrgPrice).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.ReceiptNo).HasMaxLength(50);
            entity.Property(e => e.StationId)
                .HasMaxLength(5)
                .HasColumnName("StationID");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .HasDefaultValueSql("((0))")
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.TotalBank).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.TotalCast).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.TotalDiscount).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.TotalExpPrice).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.TotalExpPriceVat)
                .HasColumnType("decimal(22, 8)")
                .HasColumnName("TotalExpPriceVAT");
            entity.Property(e => e.TotalImpPrice).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.TotalImpPriceVat)
                .HasColumnType("decimal(22, 8)")
                .HasColumnName("TotalImpPriceVAT");
            entity.Property(e => e.TotalProfit).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.TransCode)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.TransDate).HasMaxLength(8);
            entity.Property(e => e.TransType).HasMaxLength(2);
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.VatNo).HasMaxLength(20);
            entity.Property(e => e.ZoneId)
                .HasMaxLength(2)
                .HasColumnName("ZoneID");

            entity.HasOne(d => d.TransCodeNavigation).WithMany(p => p.RetailTransTemps)
                .HasForeignKey(d => d.TransCode)
                .HasConstraintName("FK_RetailTransTemp_TransType");

            entity.HasOne(d => d.Zone).WithMany(p => p.RetailTransTemps)
                .HasForeignKey(d => d.ZoneId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RetailTransTemp_Zones");
        });

        modelBuilder.Entity<Rmpermission>(entity =>
        {
            entity.HasKey(e => new { e.RoleId, e.MenuId, e.ZoneId });

            entity.ToTable("RMPermission");

            entity.Property(e => e.RoleId)
                .HasMaxLength(3)
                .HasColumnName("RoleID");
            entity.Property(e => e.MenuId)
                .HasMaxLength(50)
                .HasColumnName("MenuID");
            entity.Property(e => e.ZoneId)
                .HasMaxLength(2)
                .HasColumnName("ZoneID");
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");

            entity.HasOne(d => d.Menu).WithMany(p => p.Rmpermissions)
                .HasForeignKey(d => d.MenuId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RMPermission_Menus");

            entity.HasOne(d => d.Role).WithMany(p => p.Rmpermissions)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RMPermission_Roles");

            entity.HasOne(d => d.Zone).WithMany(p => p.Rmpermissions)
                .HasForeignKey(d => d.ZoneId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RMPermission_Zones");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.Property(e => e.RoleId)
                .HasMaxLength(3)
                .HasColumnName("RoleID");
            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Note).HasMaxLength(200);
            entity.Property(e => e.RoleName).HasMaxLength(100);
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<RoleZone>(entity =>
        {
            entity.HasKey(e => new { e.RoleId, e.ZoneId });

            entity.ToTable("RoleZone");

            entity.Property(e => e.RoleId)
                .HasMaxLength(3)
                .HasColumnName("RoleID");
            entity.Property(e => e.ZoneId)
                .HasMaxLength(2)
                .HasColumnName("ZoneID");
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");

            entity.HasOne(d => d.Role).WithMany(p => p.RoleZones)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RoleZone_Roles");

            entity.HasOne(d => d.Zone).WithMany(p => p.RoleZones)
                .HasForeignKey(d => d.ZoneId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RoleZone_Zones");
        });

        modelBuilder.Entity<Rpermission>(entity =>
        {
            entity.HasKey(e => new { e.RoleId, e.FormId, e.ControlId, e.ZoneId });

            entity.ToTable("RPermission");

            entity.Property(e => e.RoleId)
                .HasMaxLength(3)
                .HasColumnName("RoleID");
            entity.Property(e => e.FormId)
                .HasMaxLength(100)
                .HasColumnName("FormID");
            entity.Property(e => e.ControlId)
                .HasMaxLength(50)
                .HasColumnName("ControlID");
            entity.Property(e => e.ZoneId)
                .HasMaxLength(2)
                .HasColumnName("ZoneID");
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");

            entity.HasOne(d => d.Control).WithMany(p => p.Rpermissions)
                .HasForeignKey(d => d.ControlId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RPermission_Controls");

            entity.HasOne(d => d.Form).WithMany(p => p.Rpermissions)
                .HasForeignKey(d => d.FormId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RPermission_Forms");

            entity.HasOne(d => d.Role).WithMany(p => p.Rpermissions)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RPermission_Roles");

            entity.HasOne(d => d.Zone).WithMany(p => p.Rpermissions)
                .HasForeignKey(d => d.ZoneId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RPermission_Zones");
        });

        modelBuilder.Entity<Server>(entity =>
        {
            entity.HasKey(e => new { e.ServerId, e.ZoneId });

            entity.Property(e => e.ServerId)
                .HasMaxLength(2)
                .HasColumnName("ServerID");
            entity.Property(e => e.ZoneId)
                .HasMaxLength(2)
                .HasColumnName("ZoneID");
            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Note).HasMaxLength(200);
            entity.Property(e => e.ServerIp)
                .HasMaxLength(50)
                .HasColumnName("ServerIP");
            entity.Property(e => e.ServerName).HasMaxLength(100);
            entity.Property(e => e.ServerType).HasMaxLength(1);
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.TranDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Zone).WithMany(p => p.Servers)
                .HasForeignKey(d => d.ZoneId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Servers_Zones");
        });

        modelBuilder.Entity<Shelf>(entity =>
        {
            entity.HasKey(e => new { e.ShelfId, e.StockId });

            entity.Property(e => e.ShelfId)
                .HasMaxLength(4)
                .HasColumnName("ShelfID");
            entity.Property(e => e.StockId)
                .HasMaxLength(5)
                .HasColumnName("StockID");
            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Note).HasMaxLength(200);
            entity.Property(e => e.ShelfName).HasMaxLength(100);
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Stock).WithMany(p => p.Shelves)
                .HasForeignKey(d => d.StockId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Shelves_Stocks");
        });

        modelBuilder.Entity<Station>(entity =>
        {
            entity.HasKey(e => e.StationId).HasName("PK_Stations_1");

            entity.HasIndex(e => new { e.StationName, e.StationCode }, "UQ__Stations__B92E8D2607970BFE").IsUnique();

            entity.Property(e => e.StationId)
                .HasMaxLength(5)
                .HasColumnName("StationID");
            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Note).HasMaxLength(200);
            entity.Property(e => e.StationCode).HasMaxLength(100);
            entity.Property(e => e.StationName).HasMaxLength(100);
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ZoneId)
                .HasMaxLength(2)
                .HasColumnName("ZoneID");

            entity.HasOne(d => d.Zone).WithMany(p => p.Stations)
                .HasForeignKey(d => d.ZoneId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Stations_Zones");
        });

        modelBuilder.Entity<Stock>(entity =>
        {
            entity.Property(e => e.StockId)
                .HasMaxLength(5)
                .HasColumnName("StockID");
            entity.Property(e => e.Address).HasMaxLength(200);
            entity.Property(e => e.AllowAutoOrder)
                .HasDefaultValueSql("((0))")
                .HasComment("0: CK trước thuế; 1: CK sau thuế");
            entity.Property(e => e.AllowCreateAutoOrder)
                .HasDefaultValueSql("((0))")
                .HasComment("0: CK trước thuế; 1: CK sau thuế");
            entity.Property(e => e.AllowFilterBranch)
                .HasDefaultValueSql("((0))")
                .HasComment("0: CK trước thuế; 1: CK sau thuế");
            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Fax).HasMaxLength(100);
            entity.Property(e => e.ManagerName).HasMaxLength(200);
            entity.Property(e => e.Note).HasMaxLength(200);
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.StockName).HasMaxLength(100);
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.Telephone).HasMaxLength(100);
            entity.Property(e => e.TypeId).HasColumnName("TypeID");
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ZoneId)
                .HasMaxLength(2)
                .HasColumnName("ZoneID");

            entity.HasOne(d => d.Zone).WithMany(p => p.Stocks)
                .HasForeignKey(d => d.ZoneId)
                .HasConstraintName("FK_Stocks_Zones");
        });

        modelBuilder.Entity<StockBranch>(entity =>
        {
            entity.HasKey(e => new { e.StockId, e.BranchId }).HasName("PK_StockBranche");

            entity.ToTable("StockBranch");

            entity.Property(e => e.StockId)
                .HasMaxLength(5)
                .HasColumnName("StockID");
            entity.Property(e => e.BranchId)
                .HasMaxLength(5)
                .HasColumnName("BranchID");
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
        });

        modelBuilder.Entity<SysCode>(entity =>
        {
            entity.HasKey(e => new { e.CodeType, e.ZoneId, e.Ctype });

            entity.Property(e => e.CodeType).HasMaxLength(10);
            entity.Property(e => e.ZoneId)
                .HasMaxLength(2)
                .HasColumnName("ZoneID");
            entity.Property(e => e.Ctype)
                .HasMaxLength(10)
                .HasDefaultValueSql("((0))")
                .IsFixedLength()
                .HasColumnName("CType");
            entity.Property(e => e.LastNum).HasMaxLength(10);
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");

            entity.HasOne(d => d.Zone).WithMany(p => p.SysCodes)
                .HasForeignKey(d => d.ZoneId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SysCodes_Zones");
        });

        modelBuilder.Entity<SysParam>(entity =>
        {
            entity.HasKey(e => e.SysParamName).HasName("PK_SysParams_1");

            entity.Property(e => e.SysParamName).HasMaxLength(100);
            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Note).HasMaxLength(2000);
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .HasDefaultValueSql("((1))")
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .HasDefaultValueSql("((1))")
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.SysParamDefaultValue).HasColumnType("ntext");
            entity.Property(e => e.SysParamType).HasDefaultValueSql("((1))");
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<SysParamValue>(entity =>
        {
            entity.HasKey(e => e.OrderSort).HasName("PK_SysParamValues_1");

            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .HasDefaultValueSql("((1))")
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .HasDefaultValueSql("((1))")
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.SysParamName).HasMaxLength(100);
            entity.Property(e => e.SysParamValue1)
                .HasColumnType("ntext")
                .HasColumnName("SysParamValue");
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.SysParamNameNavigation).WithMany(p => p.SysParamValues)
                .HasForeignKey(d => d.SysParamName)
                .HasConstraintName("FK_SysParamValues_SysParams");
        });

        modelBuilder.Entity<Sysmarkdate>(entity =>
        {
            entity.HasKey(e => new { e.ZoneId, e.TransDate, e.Type });

            entity.ToTable("Sysmarkdate");

            entity.Property(e => e.ZoneId)
                .HasMaxLength(2)
                .HasColumnName("ZoneID");
            entity.Property(e => e.TransDate).HasMaxLength(8);
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.Tablename)
                .HasMaxLength(50)
                .IsFixedLength();
        });

        modelBuilder.Entity<Systranscutdate>(entity =>
        {
            entity.HasKey(e => new { e.ZoneId, e.TransCut });

            entity.ToTable("Systranscutdate");

            entity.Property(e => e.ZoneId)
                .HasMaxLength(2)
                .HasColumnName("ZoneID");
            entity.Property(e => e.TransCut).HasMaxLength(8);
            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.FromDate).HasMaxLength(8);
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.ToDate).HasMaxLength(8);
        });

        modelBuilder.Entity<Tool>(entity =>
        {
            entity.HasKey(e => new { e.ZoneId, e.ToolId });

            entity.ToTable("Tool");

            entity.Property(e => e.ZoneId)
                .HasMaxLength(2)
                .HasColumnName("ZoneID");
            entity.Property(e => e.ToolId)
                .HasDefaultValueSql("(newid())")
                .HasComment("Mã ID Công cụ")
                .HasColumnName("ToolID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description)
                .HasMaxLength(1000)
                .HasComment("Mô tả Công cụ");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.ToolGroupId)
                .HasDefaultValueSql("(newid())")
                .HasComment("Mã ID Công cụ")
                .HasColumnName("ToolGroupID");
            entity.Property(e => e.ToolName).HasMaxLength(200);
            entity.Property(e => e.ToolSign).HasMaxLength(50);
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<ToolGroup>(entity =>
        {
            entity.HasKey(e => new { e.ToolGroupId, e.ZoneId });

            entity.Property(e => e.ToolGroupId)
                .HasDefaultValueSql("(newid())")
                .HasComment("Mã ID chi phí")
                .HasColumnName("ToolGroupID");
            entity.Property(e => e.ZoneId)
                .HasMaxLength(2)
                .HasColumnName("ZoneID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description)
                .HasMaxLength(1000)
                .HasComment("Mô tả chi phí");
            entity.Property(e => e.ParentToolGroupId)
                .HasComment("Mã ID Chi Phí Cha")
                .HasColumnName("ParentToolGroupID");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.ToolGroupName)
                .HasMaxLength(200)
                .HasComment("Tên chi phí");
            entity.Property(e => e.ToolGroupSign)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasComment("Kí Hiệu viết tắt mã chi phí");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<TransByPacket>(entity =>
        {
            entity.HasKey(e => new { e.TransactionId, e.FullGoodId, e.PacketId, e.BigUnitId });

            entity.ToTable("TransByPacket");

            entity.Property(e => e.TransactionId)
                .HasMaxLength(20)
                .HasColumnName("TransactionID");
            entity.Property(e => e.FullGoodId)
                .HasMaxLength(13)
                .HasColumnName("FullGoodID");
            entity.Property(e => e.PacketId)
                .HasMaxLength(8)
                .HasColumnName("PacketID");
            entity.Property(e => e.BigUnitId)
                .HasMaxLength(5)
                .HasColumnName("BigUnitID");
            entity.Property(e => e.Discount).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.ExchangeRate).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.ExpPrice)
                .HasDefaultValueSql("((1))")
                .HasColumnType("decimal(22, 8)");
            entity.Property(e => e.ExpPriceVat)
                .HasColumnType("decimal(22, 8)")
                .HasColumnName("ExpPriceVAT");
            entity.Property(e => e.GoodId)
                .HasMaxLength(9)
                .HasColumnName("GoodID");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.TotalExpPrice).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.TotalExpPriceVat)
                .HasColumnType("decimal(22, 8)")
                .HasColumnName("TotalExpPriceVAT");
            entity.Property(e => e.UnitId)
                .HasMaxLength(5)
                .HasColumnName("UnitID");

            entity.HasOne(d => d.Packet).WithMany(p => p.TransByPackets)
                .HasForeignKey(d => d.PacketId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RTransByPacket_Packets");
        });

        modelBuilder.Entity<TransDetail>(entity =>
        {
            entity.HasKey(e => new { e.TransDetailId, e.TransactionId, e.FullGoodId, e.ImportId, e.ExportId }).HasName("PK_TransDetail_1");

            entity.ToTable("TransDetail");

            entity.Property(e => e.TransDetailId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("TransDetailID");
            entity.Property(e => e.TransactionId)
                .HasMaxLength(20)
                .HasColumnName("TransactionID");
            entity.Property(e => e.FullGoodId)
                .HasMaxLength(13)
                .HasColumnName("FullGoodID");
            entity.Property(e => e.ImportId)
                .HasMaxLength(10)
                .HasColumnName("ImportID");
            entity.Property(e => e.ExportId)
                .HasMaxLength(10)
                .HasColumnName("ExportID");
            entity.Property(e => e.BigUnitId)
                .HasMaxLength(5)
                .HasColumnName("BigUnitID");
            entity.Property(e => e.BranchId)
                .HasMaxLength(5)
                .HasColumnName("BranchID");
            entity.Property(e => e.CostCreditAccount)
                .HasMaxLength(20)
                .HasComment("TK có thuế GTGT");
            entity.Property(e => e.CostDebitAccount)
                .HasMaxLength(20)
                .HasComment("TK Nợ thuế GTGT");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreditAccount)
                .HasMaxLength(20)
                .HasComment("TK Có");
            entity.Property(e => e.CreditTaxVataccount)
                .HasMaxLength(20)
                .HasComment("TK có thuế GTGT")
                .HasColumnName("CreditTaxVATAccount");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(10)
                .HasColumnName("CustomerID");
            entity.Property(e => e.DebitAccount)
                .HasMaxLength(20)
                .HasComment("TK Nợ");
            entity.Property(e => e.DebitTaxVataccount)
                .HasMaxLength(20)
                .HasComment("TK Nợ thuế GTGT")
                .HasColumnName("DebitTaxVATAccount");
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.ExchangeRate).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.ExpPrice).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.ExpPriceVat)
                .HasColumnType("decimal(22, 8)")
                .HasColumnName("ExpPriceVAT");
            entity.Property(e => e.ExpiredDate)
                .HasMaxLength(8)
                .HasDefaultValueSql("('')")
                .HasComment("Hạn Sử dụng");
            entity.Property(e => e.FeeAmount).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.FeeAmountVat)
                .HasColumnType("decimal(22, 8)")
                .HasColumnName("FeeAmountVAT");
            entity.Property(e => e.GoodId)
                .HasMaxLength(9)
                .HasColumnName("GoodID");
            entity.Property(e => e.GroupId)
                .HasMaxLength(6)
                .HasColumnName("GroupID");
            entity.Property(e => e.ImpPrice).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.ImpPriceVat)
                .HasColumnType("decimal(22, 8)")
                .HasColumnName("ImpPriceVAT");
            entity.Property(e => e.ItemId)
                .ValueGeneratedOnAdd()
                .HasColumnName("ItemID");
            entity.Property(e => e.LotNumber)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("Số Lô");
            entity.Property(e => e.PriceOrg).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.PriceVatorg)
                .HasColumnType("decimal(22, 8)")
                .HasColumnName("PriceVATOrg");
            entity.Property(e => e.Profit).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.TaxVatAmount).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.TaxVatRate)
                .HasDefaultValueSql("((0))")
                .HasComment("Thuế suất GTGT")
                .HasColumnType("decimal(22, 8)");
            entity.Property(e => e.Time)
                .HasMaxLength(6)
                .HasDefaultValueSql("([dbo].[GetStringSysTime]())");
            entity.Property(e => e.TotalExpPrice).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.TotalExpPriceVat)
                .HasColumnType("decimal(22, 8)")
                .HasColumnName("TotalExpPriceVAT");
            entity.Property(e => e.TotalImpPrice).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.TotalImpPriceVat)
                .HasColumnType("decimal(22, 8)")
                .HasColumnName("TotalImpPriceVAT");
            entity.Property(e => e.TotalPriceOrg)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(22, 8)");
            entity.Property(e => e.TotalPriceVatorg)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(22, 8)")
                .HasColumnName("TotalPriceVATOrg");
            entity.Property(e => e.TransDate).HasMaxLength(8);
            entity.Property(e => e.UnitId)
                .HasMaxLength(5)
                .HasColumnName("UnitID");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.VatId)
                .HasMaxLength(2)
                .HasDefaultValueSql("((1))")
                .HasColumnName("VatID");
            entity.Property(e => e.ZoneId)
                .HasMaxLength(2)
                .HasColumnName("ZoneID");

            entity.HasOne(d => d.Transaction).WithMany(p => p.TransDetails)
                .HasForeignKey(d => d.TransactionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TransDetail_Transactions");
        });

        modelBuilder.Entity<TransDetailTest>(entity =>
        {
            entity.HasKey(e => new { e.TransDetailId, e.TransactionId, e.FullGoodId, e.ImportId, e.ExportId }).HasName("PK_TransDetailTest_1");

            entity.ToTable("TransDetailTest");

            entity.Property(e => e.TransDetailId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("TransDetailID");
            entity.Property(e => e.TransactionId)
                .HasMaxLength(20)
                .HasColumnName("TransactionID");
            entity.Property(e => e.FullGoodId)
                .HasMaxLength(13)
                .HasColumnName("FullGoodID");
            entity.Property(e => e.ImportId)
                .HasMaxLength(10)
                .HasColumnName("ImportID");
            entity.Property(e => e.ExportId)
                .HasMaxLength(10)
                .HasColumnName("ExportID");
            entity.Property(e => e.BigUnitId)
                .HasMaxLength(5)
                .HasColumnName("BigUnitID");
            entity.Property(e => e.BranchId)
                .HasMaxLength(5)
                .HasColumnName("BranchID");
            entity.Property(e => e.CostCreditAccount).HasMaxLength(20);
            entity.Property(e => e.CostDebitAccount).HasMaxLength(20);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.CreditAccount).HasMaxLength(20);
            entity.Property(e => e.CreditTaxVataccount)
                .HasMaxLength(20)
                .HasColumnName("CreditTaxVATAccount");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(10)
                .HasColumnName("CustomerID");
            entity.Property(e => e.DebitAccount).HasMaxLength(20);
            entity.Property(e => e.DebitTaxVataccount)
                .HasMaxLength(20)
                .HasColumnName("DebitTaxVATAccount");
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.ExchangeRate).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.ExpPrice).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.ExpPriceVat)
                .HasColumnType("decimal(22, 8)")
                .HasColumnName("ExpPriceVAT");
            entity.Property(e => e.ExpiredDate).HasMaxLength(8);
            entity.Property(e => e.FeeAmount).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.FeeAmountVat)
                .HasColumnType("decimal(22, 8)")
                .HasColumnName("FeeAmountVAT");
            entity.Property(e => e.GoodId)
                .HasMaxLength(9)
                .HasColumnName("GoodID");
            entity.Property(e => e.GroupId)
                .HasMaxLength(6)
                .HasColumnName("GroupID");
            entity.Property(e => e.ImpPrice).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.ImpPriceVat)
                .HasColumnType("decimal(22, 8)")
                .HasColumnName("ImpPriceVAT");
            entity.Property(e => e.ItemId)
                .ValueGeneratedOnAdd()
                .HasColumnName("ItemID");
            entity.Property(e => e.LotNumber).HasMaxLength(20);
            entity.Property(e => e.PriceOrg).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.PriceVatorg)
                .HasColumnType("decimal(22, 8)")
                .HasColumnName("PriceVATOrg");
            entity.Property(e => e.Profit).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime).HasMaxLength(14);
            entity.Property(e => e.TaxVatAmount).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.TaxVatRate).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.Time).HasMaxLength(6);
            entity.Property(e => e.TotalExpPrice).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.TotalExpPriceVat)
                .HasColumnType("decimal(22, 8)")
                .HasColumnName("TotalExpPriceVAT");
            entity.Property(e => e.TotalImpPrice).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.TotalImpPriceVat)
                .HasColumnType("decimal(22, 8)")
                .HasColumnName("TotalImpPriceVAT");
            entity.Property(e => e.TotalPriceOrg).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.TotalPriceVatorg)
                .HasColumnType("decimal(22, 8)")
                .HasColumnName("TotalPriceVATOrg");
            entity.Property(e => e.TransDate).HasMaxLength(8);
            entity.Property(e => e.UnitId)
                .HasMaxLength(5)
                .HasColumnName("UnitID");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.VatId)
                .HasMaxLength(2)
                .HasColumnName("VatID");
            entity.Property(e => e.ZoneId)
                .HasMaxLength(2)
                .HasColumnName("ZoneID");
        });

        modelBuilder.Entity<TransDocumentType>(entity =>
        {
            entity.HasKey(e => e.InvTypeId).HasName("PK_InvType");

            entity.ToTable("TransDocumentType");

            entity.Property(e => e.InvTypeId)
                .ValueGeneratedNever()
                .HasComment("PK")
                .HasColumnName("InvTypeID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.InvTypeCode)
                .HasMaxLength(25)
                .HasComment("Tên loại hóa đơn");
            entity.Property(e => e.InvTypeName)
                .HasMaxLength(255)
                .HasComment("Diễn giải");
            entity.Property(e => e.InvoiceTemplatePrefix)
                .HasMaxLength(20)
                .HasComment("Tiền tố mẫu số hóa đơn");
            entity.Property(e => e.InvoiceType).HasComment("0=Loại hóa đơn bán hàng;1=Loại hóa đơn xuất chuyển kho");
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<TransType>(entity =>
        {
            entity.HasKey(e => e.TransCode).HasName("PK_TranType");

            entity.ToTable("TransType");

            entity.Property(e => e.TransCode)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.TransName).HasMaxLength(100);
            entity.Property(e => e.Type)
                .HasMaxLength(2)
                .HasDefaultValueSql("((0))")
                .IsFixedLength();
        });

        modelBuilder.Entity<Transaction>(entity =>
        {
            entity.HasKey(e => e.TransactionId).HasName("PK_Transactions_1");

            entity.Property(e => e.TransactionId)
                .HasMaxLength(20)
                .HasColumnName("TransactionID");
            entity.Property(e => e.CheckedBy).HasMaxLength(5);
            entity.Property(e => e.ContractId)
                .HasComment("PK  hợp đồng bán")
                .HasColumnName("ContractID");
            entity.Property(e => e.CostFormula)
                .HasMaxLength(1000)
                .HasComment("Công thức tính giá vốn");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CurrencyId)
                .HasMaxLength(3)
                .HasComment("Loại tiền")
                .HasColumnName("CurrencyID");
            entity.Property(e => e.CurrencyIdoc)
                .HasMaxLength(3)
                .HasComment("Loại tiền")
                .HasColumnName("CurrencyIDOC");
            entity.Property(e => e.Deliver).HasMaxLength(200);
            entity.Property(e => e.Description).HasMaxLength(4000);
            entity.Property(e => e.DiscountType)
                .HasDefaultValueSql("((0))")
                .HasComment("0: CK trước thuế; 1: CK sau thuế");
            entity.Property(e => e.DueDate)
                .HasMaxLength(8)
                .HasComment("Ngày thanh toán");
            entity.Property(e => e.DueTime).HasComment("Hạn thanh toán (bao nhiêu ngày)");
            entity.Property(e => e.ExchangeRate)
                .HasComment("Tỉ giá hối đoái")
                .HasColumnType("decimal(22, 8)");
            entity.Property(e => e.ExportId)
                .HasMaxLength(10)
                .HasColumnName("ExportID");
            entity.Property(e => e.FormNo)
                .HasMaxLength(20)
                .HasComment("Mau so hoa don");
            entity.Property(e => e.ImpExpMethodCode)
                .HasMaxLength(50)
                .HasComment("Mã phương thức Nhập xuất");
            entity.Property(e => e.ImpExpMethodId)
                .HasComment("Key Mã phương thức nhập xuất")
                .HasColumnName("ImpExpMethodID");
            entity.Property(e => e.ImpExpMethodName)
                .HasMaxLength(500)
                .HasComment("Tên phương thức nhập xuất.");
            entity.Property(e => e.ImportId)
                .HasMaxLength(10)
                .HasColumnName("ImportID");
            entity.Property(e => e.OrderId).HasMaxLength(30);
            entity.Property(e => e.OrgPrice)
                .HasComment("Gia von")
                .HasColumnType("decimal(22, 8)");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(50)
                .HasComment("So chung tu/ ky hieu hoa don");
            entity.Property(e => e.Receiver).HasMaxLength(200);
            entity.Property(e => e.RevenueFormula)
                .HasMaxLength(1000)
                .HasComment("Công thức tính doanh thu");
            entity.Property(e => e.StaffInChargeId)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')")
                .HasComment("Nhân viên phụ trách")
                .HasColumnName("StaffInChargeID");
            entity.Property(e => e.StationId)
                .HasMaxLength(5)
                .HasColumnName("StationID");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .HasDefaultValueSql("((0))")
                .IsFixedLength();
            entity.Property(e => e.StockId)
                .HasMaxLength(5)
                .HasColumnName("StockID");
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.TaxInvoice)
                .HasMaxLength(1)
                .HasDefaultValueSql("((0))")
                .IsFixedLength()
                .HasComment("Thông tin hóa đơn, 0 là không hóa đơn, 1 là có hóa đơn");
            entity.Property(e => e.TaxSign)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("Kí hiệu hóa đơn");
            entity.Property(e => e.TotalDiscount)
                .HasComment("tong ck")
                .HasColumnType("decimal(22, 8)");
            entity.Property(e => e.TotalPrice)
                .HasComment("tong tien chua VAT")
                .HasColumnType("decimal(22, 8)");
            entity.Property(e => e.TotalPriceVat)
                .HasComment("tong tien co VAT")
                .HasColumnType("decimal(22, 8)")
                .HasColumnName("TotalPriceVAT");
            entity.Property(e => e.TotalProfit)
                .HasComment("tong lai")
                .HasColumnType("decimal(22, 8)");
            entity.Property(e => e.TotalVat)
                .HasComment("Tong Vat")
                .HasColumnType("decimal(22, 8)")
                .HasColumnName("TotalVAT");
            entity.Property(e => e.TransCode)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.TransDate).HasMaxLength(8);
            entity.Property(e => e.TransType).HasMaxLength(2);
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.VatDate)
                .HasMaxLength(20)
                .HasComment("Ngày hóa đơn");
            entity.Property(e => e.VatNo)
                .HasMaxLength(20)
                .HasComment("Số hóa đơn VAT");
            entity.Property(e => e.ZoneId)
                .HasMaxLength(2)
                .HasColumnName("ZoneID");

            entity.HasOne(d => d.TransCodeNavigation).WithMany(p => p.Transactions)
                .HasForeignKey(d => d.TransCode)
                .HasConstraintName("FK_Transactions_TransType");

            entity.HasOne(d => d.Zone).WithMany(p => p.Transactions)
                .HasForeignKey(d => d.ZoneId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Transactions_Zones");
        });

        modelBuilder.Entity<TransactionAccounting>(entity =>
        {
            entity.HasKey(e => new { e.TransactionId, e.TransactionAccountingId, e.ZoneId, e.DebitAccount, e.CreditAccount, e.ImportId, e.ExportId }).HasName("PK_TransactionAccouting");

            entity.ToTable("TransactionAccounting");

            entity.Property(e => e.TransactionId)
                .HasMaxLength(20)
                .HasColumnName("TransactionID");
            entity.Property(e => e.TransactionAccountingId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("TransactionAccountingID");
            entity.Property(e => e.ZoneId)
                .HasMaxLength(2)
                .HasColumnName("ZoneID");
            entity.Property(e => e.DebitAccount)
                .HasMaxLength(20)
                .HasComment("Tài khoản nợ");
            entity.Property(e => e.CreditAccount)
                .HasMaxLength(20)
                .HasComment("Tài khoản có");
            entity.Property(e => e.ImportId)
                .HasMaxLength(10)
                .HasColumnName("ImportID");
            entity.Property(e => e.ExportId)
                .HasMaxLength(10)
                .HasColumnName("ExportID");
            entity.Property(e => e.AccountItemAliasId)
                .HasComment("Tên người gửi, nhận")
                .HasColumnName("AccountItemAliasID");
            entity.Property(e => e.Amount)
                .HasComment("Số tiền quy đổi")
                .HasColumnType("decimal(22, 8)");
            entity.Property(e => e.AmountOc)
                .HasComment("Số tiền nguyên tệ")
                .HasColumnType("decimal(22, 8)")
                .HasColumnName("AmountOC");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasComment("Diễn giải");
            entity.Property(e => e.ImpExpMethodCode).HasMaxLength(50);
            entity.Property(e => e.SortOrder).HasComment("Thứ tự sắp xếp");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.Time)
                .HasMaxLength(6)
                .HasDefaultValueSql("([dbo].[GetStringSysTime]())");
            entity.Property(e => e.TransCode).HasMaxLength(10);
            entity.Property(e => e.TransDate).HasMaxLength(8);
        });

        modelBuilder.Entity<TransactionDiscountDetail>(entity =>
        {
            entity.HasKey(e => new { e.TransDetailId, e.TransactionId, e.FullGoodId });

            entity.Property(e => e.TransDetailId).HasColumnName("TransDetailID");
            entity.Property(e => e.TransactionId)
                .HasMaxLength(20)
                .HasColumnName("TransactionID");
            entity.Property(e => e.FullGoodId)
                .HasMaxLength(13)
                .HasColumnName("FullGoodID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DiscountAmount)
                .HasComment("%Thuế tiêu thụ đặc biệt")
                .HasColumnType("decimal(22, 8)");
            entity.Property(e => e.DiscountName).HasMaxLength(200);
            entity.Property(e => e.DiscountRate).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.DiscountType)
                .HasMaxLength(3)
                .HasDefaultValueSql("(N'IMP')")
                .HasComment("KIỂU GIẢM GIÁ, IMP CHO GD NHẬP, EXP CHO GIAO DỊCH XUẤT");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<TransactionEnvironmentalTaxDetail>(entity =>
        {
            entity.HasKey(e => new { e.TransDetailId, e.TransactionId, e.FullGoodId });

            entity.Property(e => e.TransDetailId).HasColumnName("TransDetailID");
            entity.Property(e => e.TransactionId)
                .HasMaxLength(20)
                .HasColumnName("TransactionID");
            entity.Property(e => e.FullGoodId)
                .HasMaxLength(13)
                .HasColumnName("FullGoodID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreditAccount)
                .HasMaxLength(20)
                .HasComment("Tài khoản có");
            entity.Property(e => e.DebitAccount)
                .HasMaxLength(20)
                .HasComment("Tài khoản nợ");
            entity.Property(e => e.EnvironmentalTaxAccount).HasMaxLength(20);
            entity.Property(e => e.EnvironmentalTaxAmount).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.EnvironmentalTaxRate)
                .HasComment("%Thuế tiêu thụ đặc biệt")
                .HasColumnType("decimal(22, 8)");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<TransactionExpiredDateDetail>(entity =>
        {
            entity.HasKey(e => new { e.TransactionId, e.FullGoodId, e.ExpiredDate });

            entity.Property(e => e.TransactionId)
                .HasMaxLength(20)
                .HasColumnName("TransactionID");
            entity.Property(e => e.FullGoodId)
                .HasMaxLength(13)
                .HasColumnName("FullGoodID");
            entity.Property(e => e.ExpiredDate)
                .HasMaxLength(8)
                .HasDefaultValueSql("('')")
                .HasComment("Hạn Sử dụng");
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.ZoneId)
                .HasMaxLength(2)
                .HasColumnName("ZoneID");
        });

        modelBuilder.Entity<TransactionFeeDetail>(entity =>
        {
            entity.HasKey(e => new { e.TransDetailId, e.TransactionId, e.FullGoodId }).HasName("PK_TransactionOtherFeeDetails");

            entity.Property(e => e.TransDetailId).HasColumnName("TransDetailID");
            entity.Property(e => e.TransactionId)
                .HasMaxLength(20)
                .HasColumnName("TransactionID");
            entity.Property(e => e.FullGoodId)
                .HasMaxLength(13)
                .HasColumnName("FullGoodID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreditAccount)
                .HasMaxLength(20)
                .HasComment("Tài khoản có");
            entity.Property(e => e.CreditFeeTaxVataccount)
                .HasMaxLength(20)
                .HasComment("TK có thuế GTGT")
                .HasColumnName("CreditFeeTaxVATAccount");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(10)
                .HasColumnName("CustomerID");
            entity.Property(e => e.DebitAccount)
                .HasMaxLength(20)
                .HasComment("Tài khoản nợ");
            entity.Property(e => e.DebitFeeTaxVataccount)
                .HasMaxLength(20)
                .HasComment("TK Nợ thuế GTGT")
                .HasColumnName("DebitFeeTaxVATAccount");
            entity.Property(e => e.FeeAmount)
                .HasComment("%Thuế tiêu thụ đặc biệt")
                .HasColumnType("decimal(22, 8)");
            entity.Property(e => e.FeeAmountVat)
                .HasComment("%Thuế tiêu thụ đặc biệt")
                .HasColumnType("decimal(22, 8)")
                .HasColumnName("FeeAmountVAT");
            entity.Property(e => e.FeeId).HasColumnName("FeeID");
            entity.Property(e => e.FeeNote).HasMaxLength(200);
            entity.Property(e => e.FeeTaxVatAmount).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.FeeTaxVatRate)
                .HasDefaultValueSql("((0))")
                .HasComment("Thuế suất GTGT")
                .HasColumnType("decimal(22, 8)");
            entity.Property(e => e.FeeVatId)
                .HasMaxLength(2)
                .HasDefaultValueSql("((0))")
                .HasColumnName("FeeVatID");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<TransactionImportTaxDetail>(entity =>
        {
            entity.HasKey(e => new { e.TransDetailId, e.TransactionId, e.FullGoodId }).HasName("PK_TransactionImportTaxDetail");

            entity.Property(e => e.TransDetailId).HasColumnName("TransDetailID");
            entity.Property(e => e.TransactionId)
                .HasMaxLength(20)
                .HasColumnName("TransactionID");
            entity.Property(e => e.FullGoodId)
                .HasMaxLength(13)
                .HasColumnName("FullGoodID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreditAccount)
                .HasMaxLength(20)
                .HasComment("Tài khoản có");
            entity.Property(e => e.DebitAccount)
                .HasMaxLength(20)
                .HasComment("Tài khoản nợ");
            entity.Property(e => e.ImportTaxAccount)
                .HasMaxLength(20)
                .HasComment("TK thuế  nhập khẩu");
            entity.Property(e => e.ImportTaxAmount)
                .HasComment("Tiền thuế  nhập khẩu quy đổi")
                .HasColumnType("decimal(22, 8)");
            entity.Property(e => e.ImportTaxRate)
                .HasComment("% Thuế nhập khẩu")
                .HasColumnType("decimal(22, 8)");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<TransactionLotNumberDetail>(entity =>
        {
            entity.HasKey(e => new { e.TransDetailId, e.TransactionId, e.FullGoodId, e.LotNumber }).HasName("PK_TransactionLotNumberDetails_1");

            entity.Property(e => e.TransDetailId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("TransDetailID");
            entity.Property(e => e.TransactionId)
                .HasMaxLength(20)
                .HasColumnName("TransactionID");
            entity.Property(e => e.FullGoodId)
                .HasMaxLength(13)
                .HasColumnName("FullGoodID");
            entity.Property(e => e.LotNumber)
                .HasMaxLength(8)
                .HasDefaultValueSql("('')")
                .HasComment("Hạn Sử dụng");
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.ZoneId)
                .HasMaxLength(2)
                .HasColumnName("ZoneID");
        });

        modelBuilder.Entity<TransactionObjectRelate>(entity =>
        {
            entity.HasKey(e => new { e.TransactionObjectRelateId, e.TransactionId, e.TransactionAccountingId, e.ZoneId });

            entity.ToTable("TransactionObjectRelate");

            entity.Property(e => e.TransactionObjectRelateId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("TransactionObjectRelateID");
            entity.Property(e => e.TransactionId)
                .HasMaxLength(20)
                .HasColumnName("TransactionID");
            entity.Property(e => e.TransactionAccountingId).HasColumnName("TransactionAccountingID");
            entity.Property(e => e.ZoneId)
                .HasMaxLength(2)
                .HasColumnName("ZoneID");
            entity.Property(e => e.CreditAccount)
                .HasMaxLength(20)
                .HasComment("Tài khoản có");
            entity.Property(e => e.DebitAccount)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("Tài khoản nợ");
            entity.Property(e => e.ObjectCategoryCode)
                .HasMaxLength(50)
                .HasDefaultValueSql("(newid())")
                .HasComment("Mã  loại đối tượng");
            entity.Property(e => e.ObjectValueCredit)
                .HasMaxLength(50)
                .HasComment("Mã đối tượng ghi có");
            entity.Property(e => e.ObjectValueDebit)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasComment("Mã đối tượng ghi nợ");
            entity.Property(e => e.OrderColunm).HasDefaultValueSql("((1))");
            entity.Property(e => e.SortOrder).HasDefaultValueSql("((1))");
            entity.Property(e => e.Value)
                .HasComment("Giá trị của đối tượng được chọn, ví dụ đối tượng là Khách Hàng CustomerID thì giá trị là mã khách hàng")
                .HasColumnType("decimal(22, 8)");
        });

        modelBuilder.Entity<TransactionObjectRelateMark20180810>(entity =>
        {
            entity.HasKey(e => e.ObjectMarkId).HasName("PK_TransactionObjectRelateMark_20180810_1");

            entity.ToTable("TransactionObjectRelateMark_20180810");

            entity.Property(e => e.ObjectMarkId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("ObjectMarkID");
            entity.Property(e => e.CreditAccount)
                .HasMaxLength(20)
                .HasComment("Tài khoản có");
            entity.Property(e => e.DebitAccount)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("Tài khoản nợ");
            entity.Property(e => e.ObjectCategoryCode)
                .HasMaxLength(50)
                .HasDefaultValueSql("(newid())")
                .HasComment("Mã  loại đối tượng");
            entity.Property(e => e.ObjectValueCredit)
                .HasMaxLength(50)
                .HasComment("Mã đối tượng ghi có");
            entity.Property(e => e.ObjectValueDebit)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasComment("Mã đối tượng ghi nợ");
            entity.Property(e => e.Value)
                .HasComment("Giá trị của đối tượng được chọn, ví dụ đối tượng là Khách Hàng CustomerID thì giá trị là mã khách hàng")
                .HasColumnType("decimal(22, 8)");
            entity.Property(e => e.ZoneId)
                .HasMaxLength(2)
                .HasColumnName("ZoneID");
        });

        modelBuilder.Entity<TransactionOtherTaxDetail>(entity =>
        {
            entity.HasKey(e => new { e.TransDetailId, e.TransactionId, e.FullGoodId });

            entity.Property(e => e.TransDetailId).HasColumnName("TransDetailID");
            entity.Property(e => e.TransactionId)
                .HasMaxLength(20)
                .HasColumnName("TransactionID");
            entity.Property(e => e.FullGoodId)
                .HasMaxLength(13)
                .HasColumnName("FullGoodID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreditAccount)
                .HasMaxLength(20)
                .HasComment("Tài khoản có");
            entity.Property(e => e.DebitAccount)
                .HasMaxLength(20)
                .HasComment("Tài khoản nợ");
            entity.Property(e => e.OtherTaxAccount)
                .HasMaxLength(20)
                .HasDefaultValueSql("((0))")
                .HasComment("Tài khoản thuế tiêu thụ đặc biệt");
            entity.Property(e => e.OtherTaxAmount)
                .HasComment("Thuế tiêu thụ đặc biệt quy đổi")
                .HasColumnType("decimal(22, 8)");
            entity.Property(e => e.OtherTaxName).HasMaxLength(100);
            entity.Property(e => e.OtherTaxRate)
                .HasComment("%Thuế tiêu thụ đặc biệt")
                .HasColumnType("decimal(22, 8)");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<TransactionPromotionDetail>(entity =>
        {
            entity.HasKey(e => new { e.TransDetailId, e.TransactionId, e.FullGoodId });

            entity.Property(e => e.TransDetailId).HasColumnName("TransDetailID");
            entity.Property(e => e.TransactionId)
                .HasMaxLength(20)
                .HasColumnName("TransactionID");
            entity.Property(e => e.FullGoodId)
                .HasMaxLength(13)
                .HasColumnName("FullGoodID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreditAccount)
                .HasMaxLength(20)
                .HasComment("Tài khoản có");
            entity.Property(e => e.DebitAccount)
                .HasMaxLength(20)
                .HasComment("Tài khoản nợ");
            entity.Property(e => e.PromotionAmount)
                .HasComment("%Thuế tiêu thụ đặc biệt")
                .HasColumnType("decimal(22, 8)");
            entity.Property(e => e.PromotionName).HasMaxLength(200);
            entity.Property(e => e.PromotionRate).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.PromotionType)
                .HasMaxLength(3)
                .HasDefaultValueSql("(N'IMP')")
                .HasComment("KIỂU GIẢM GIÁ, IMP CHO GD NHẬP, EXP CHO GIAO DỊCH XUẤT");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<TransactionSpecialConsumeDetail>(entity =>
        {
            entity.HasKey(e => new { e.TransDetailId, e.TransactionId, e.FullGoodId });

            entity.Property(e => e.TransDetailId).HasColumnName("TransDetailID");
            entity.Property(e => e.TransactionId)
                .HasMaxLength(20)
                .HasColumnName("TransactionID");
            entity.Property(e => e.FullGoodId)
                .HasMaxLength(13)
                .HasColumnName("FullGoodID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreditAccount)
                .HasMaxLength(20)
                .HasComment("Tài khoản có");
            entity.Property(e => e.DebitAccount)
                .HasMaxLength(20)
                .HasComment("Tài khoản nợ");
            entity.Property(e => e.SpecialConsumeTaxAccount)
                .HasMaxLength(20)
                .HasDefaultValueSql("((0))")
                .HasComment("Tài khoản thuế tiêu thụ đặc biệt");
            entity.Property(e => e.SpecialConsumeTaxAmount)
                .HasComment("Thuế tiêu thụ đặc biệt quy đổi")
                .HasColumnType("decimal(22, 8)");
            entity.Property(e => e.SpecialConsumeTaxRate)
                .HasComment("%Thuế tiêu thụ đặc biệt")
                .HasColumnType("decimal(22, 8)");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<TransactionTaxInvoiceInfor>(entity =>
        {
            entity.HasKey(e => new { e.TransactionId, e.TaxSign, e.TaxSerialNumber });

            entity.ToTable("TransactionTaxInvoiceInfor");

            entity.Property(e => e.TransactionId)
                .HasMaxLength(20)
                .HasComment("Số giao dịch")
                .HasColumnName("TransactionID");
            entity.Property(e => e.TaxSign)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasComment("Kí hiệu hóa đơn.");
            entity.Property(e => e.TaxSerialNumber)
                .HasMaxLength(20)
                .HasComment("Số hóa đơn");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description)
                .HasMaxLength(1000)
                .HasComment("Mô tả ");
            entity.Property(e => e.InvTypeCode)
                .HasMaxLength(25)
                .HasComment("Tên loại hóa đơn");
            entity.Property(e => e.ReceivedDate)
                .HasMaxLength(8)
                .HasComment("Ngày nhận hóa đơn");
            entity.Property(e => e.ReceivedFromCustomer)
                .HasMaxLength(20)
                .HasComment("Hóa đơn nhận từ khách hàng?");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.TaxAddress)
                .HasMaxLength(500)
                .HasComment("Địa chỉ hóa đơn");
            entity.Property(e => e.TaxCode)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasComment("Mã số thuế công ty xuất hóa đơn");
            entity.Property(e => e.TaxDate)
                .HasMaxLength(8)
                .HasComment("Ngày số hóa đơn");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<TransactionTransportDetail>(entity =>
        {
            entity.HasKey(e => new { e.TransDetailId, e.TransactionId, e.FullGoodId });

            entity.Property(e => e.TransDetailId).HasColumnName("TransDetailID");
            entity.Property(e => e.TransactionId)
                .HasMaxLength(20)
                .HasColumnName("TransactionID");
            entity.Property(e => e.FullGoodId)
                .HasMaxLength(13)
                .HasColumnName("FullGoodID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreditAccount)
                .HasMaxLength(20)
                .HasComment("Tài khoản có");
            entity.Property(e => e.DebitAccount)
                .HasMaxLength(20)
                .HasComment("Tài khoản nợ");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.TransportAmount)
                .HasComment("%Thuế tiêu thụ đặc biệt")
                .HasColumnType("decimal(22, 8)");
            entity.Property(e => e.TransportAmountOc)
                .HasComment("%Thuế tiêu thụ đặc biệt")
                .HasColumnType("decimal(22, 8)")
                .HasColumnName("TransportAmountOC");
            entity.Property(e => e.TransportNote).HasMaxLength(200);
            entity.Property(e => e.TransporterId)
                .HasMaxLength(10)
                .HasColumnName("TransporterID");
            entity.Property(e => e.TransporterName).HasMaxLength(200);
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<TransactionsSerialNumber>(entity =>
        {
            entity.HasKey(e => new { e.TransactionId, e.FullGoodId, e.SerialNumber }).HasName("PK_TransactionsSerialNumber_1");

            entity.ToTable("TransactionsSerialNumber");

            entity.Property(e => e.TransactionId)
                .HasMaxLength(20)
                .HasColumnName("TransactionID");
            entity.Property(e => e.FullGoodId)
                .HasMaxLength(13)
                .HasColumnName("FullGoodID");
            entity.Property(e => e.SerialNumber).HasMaxLength(50);
            entity.Property(e => e.ExportId)
                .HasMaxLength(10)
                .HasColumnName("ExportID");
            entity.Property(e => e.GoodId)
                .HasMaxLength(9)
                .HasColumnName("GoodID");
            entity.Property(e => e.ImportId)
                .HasMaxLength(10)
                .HasColumnName("ImportID");
            entity.Property(e => e.ItemId).HasColumnName("ItemID");
            entity.Property(e => e.TransCode)
                .HasMaxLength(2)
                .IsFixedLength();
        });

        modelBuilder.Entity<TransactionsTest>(entity =>
        {
            entity.HasKey(e => e.TransactionId).HasName("PK_TransactionsTest_1");

            entity.ToTable("TransactionsTest");

            entity.Property(e => e.TransactionId)
                .HasMaxLength(20)
                .HasColumnName("TransactionID");
            entity.Property(e => e.CheckedBy).HasMaxLength(5);
            entity.Property(e => e.ContractId).HasColumnName("ContractID");
            entity.Property(e => e.CostFormula).HasMaxLength(1000);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.CurrencyId)
                .HasMaxLength(3)
                .HasColumnName("CurrencyID");
            entity.Property(e => e.CurrencyIdoc)
                .HasMaxLength(3)
                .HasColumnName("CurrencyIDOC");
            entity.Property(e => e.Deliver).HasMaxLength(200);
            entity.Property(e => e.Description).HasMaxLength(4000);
            entity.Property(e => e.DueDate).HasMaxLength(8);
            entity.Property(e => e.ExchangeRate).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.ExportId)
                .HasMaxLength(10)
                .HasColumnName("ExportID");
            entity.Property(e => e.FormNo).HasMaxLength(20);
            entity.Property(e => e.ImpExpMethodCode).HasMaxLength(50);
            entity.Property(e => e.ImpExpMethodId).HasColumnName("ImpExpMethodID");
            entity.Property(e => e.ImpExpMethodName).HasMaxLength(500);
            entity.Property(e => e.ImportId)
                .HasMaxLength(10)
                .HasColumnName("ImportID");
            entity.Property(e => e.OrderId).HasMaxLength(20);
            entity.Property(e => e.OrgPrice).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.ReceiptNo).HasMaxLength(50);
            entity.Property(e => e.Receiver).HasMaxLength(200);
            entity.Property(e => e.RevenueFormula).HasMaxLength(1000);
            entity.Property(e => e.StaffInChargeId)
                .HasMaxLength(10)
                .HasColumnName("StaffInChargeID");
            entity.Property(e => e.StationId)
                .HasMaxLength(5)
                .HasColumnName("StationID");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.StockId)
                .HasMaxLength(5)
                .HasColumnName("StockID");
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime).HasMaxLength(14);
            entity.Property(e => e.TaxInvoice)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.TaxSign).HasMaxLength(20);
            entity.Property(e => e.TotalDiscount).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.TotalPrice).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.TotalPriceVat)
                .HasColumnType("decimal(22, 8)")
                .HasColumnName("TotalPriceVAT");
            entity.Property(e => e.TotalProfit).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.TotalVat)
                .HasColumnType("decimal(22, 8)")
                .HasColumnName("TotalVAT");
            entity.Property(e => e.TransCode)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.TransDate).HasMaxLength(8);
            entity.Property(e => e.TransType).HasMaxLength(2);
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.VatDate).HasMaxLength(20);
            entity.Property(e => e.VatNo).HasMaxLength(20);
            entity.Property(e => e.ZoneId)
                .HasMaxLength(2)
                .HasColumnName("ZoneID");
        });

        modelBuilder.Entity<Unit>(entity =>
        {
            entity.Property(e => e.UnitId)
                .HasMaxLength(5)
                .HasColumnName("UnitID");
            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Note).HasMaxLength(200);
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.UnitName).HasMaxLength(20);
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<UnitExchange>(entity =>
        {
            entity.HasKey(e => new { e.GoodId, e.UnitId, e.BigUnitId, e.ConvertUnit });

            entity.Property(e => e.GoodId)
                .HasMaxLength(9)
                .HasColumnName("GoodID");
            entity.Property(e => e.UnitId)
                .HasMaxLength(5)
                .HasColumnName("UnitID");
            entity.Property(e => e.BigUnitId)
                .HasMaxLength(5)
                .HasColumnName("BigUnitID");
            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Good).WithMany(p => p.UnitExchanges)
                .HasForeignKey(d => d.GoodId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UnitExchanges_Goods");

            entity.HasOne(d => d.Unit).WithMany(p => p.UnitExchanges)
                .HasForeignKey(d => d.UnitId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UnitExchanges_Units");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK_Users_1");

            entity.HasIndex(e => e.UserName, "UQ__Users__25918339").IsUnique();

            entity.HasIndex(e => e.UserName, "UserName").IsUnique();

            entity.Property(e => e.UserId)
                .HasMaxLength(5)
                .HasColumnName("UserID");
            entity.Property(e => e.Address).HasMaxLength(100);
            entity.Property(e => e.Birthday).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.Enable).HasDefaultValueSql("((1))");
            entity.Property(e => e.FullName).HasMaxLength(50);
            entity.Property(e => e.Idcard)
                .HasMaxLength(20)
                .HasColumnName("IDCard");
            entity.Property(e => e.LogOnStation).HasMaxLength(3);
            entity.Property(e => e.Password).HasMaxLength(50);
            entity.Property(e => e.Password2).HasMaxLength(50);
            entity.Property(e => e.Phone).HasMaxLength(50);
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.Theme).HasMaxLength(50);
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.UserName).HasMaxLength(20);
        });

        modelBuilder.Entity<UserRole>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.RoleId });

            entity.ToTable("UserRole");

            entity.Property(e => e.UserId)
                .HasMaxLength(5)
                .HasColumnName("UserID");
            entity.Property(e => e.RoleId)
                .HasMaxLength(3)
                .HasColumnName("RoleID");
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");

            entity.HasOne(d => d.Role).WithMany(p => p.UserRoles)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserRole_Roles");

            entity.HasOne(d => d.User).WithMany(p => p.UserRoles)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserRole_Users");
        });

        modelBuilder.Entity<UserStation>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.StationId });

            entity.ToTable("UserStation");

            entity.Property(e => e.UserId)
                .HasMaxLength(5)
                .HasColumnName("UserID");
            entity.Property(e => e.StationId)
                .HasMaxLength(5)
                .HasColumnName("StationID");
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");

            entity.HasOne(d => d.User).WithMany(p => p.UserStations)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserStation_Users");
        });

        modelBuilder.Entity<UserZone>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.ZoneId });

            entity.ToTable("UserZone");

            entity.Property(e => e.UserId)
                .HasMaxLength(5)
                .HasColumnName("UserID");
            entity.Property(e => e.ZoneId)
                .HasMaxLength(2)
                .HasColumnName("ZoneID");
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");

            entity.HasOne(d => d.User).WithMany(p => p.UserZones)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserZone_Users");

            entity.HasOne(d => d.Zone).WithMany(p => p.UserZones)
                .HasForeignKey(d => d.ZoneId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserZone_Zones");
        });

        modelBuilder.Entity<Voucher>(entity =>
        {
            entity.HasKey(e => new { e.VouchersId, e.ZoneId });

            entity.Property(e => e.VouchersId)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("VouchersID");
            entity.Property(e => e.ZoneId)
                .HasMaxLength(2)
                .HasColumnName("ZoneID");
            entity.Property(e => e.Address).HasMaxLength(200);
            entity.Property(e => e.Amount).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.AutoBusinessId)
                .HasMaxLength(50)
                .HasComment("Mã lý do chi")
                .HasColumnName("AutoBusinessID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CurrencyId)
                .HasMaxLength(3)
                .HasDefaultValueSql("(N'VND')")
                .HasColumnName("CurrencyID");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(20)
                .HasComment("Mã khách hàng, nhân viên nhận, nộp")
                .HasColumnName("CustomerID");
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.DueDate)
                .HasComment("Ngày thanh toán")
                .HasColumnType("datetime");
            entity.Property(e => e.DueTime).HasComment("Hạn thanh toán (bao nhiêu ngày)");
            entity.Property(e => e.ExchangeRate)
                .HasDefaultValueSql("((1))")
                .HasColumnType("decimal(22, 8)");
            entity.Property(e => e.Payers)
                .HasMaxLength(100)
                .HasComment("Người Nộp");
            entity.Property(e => e.RecceiverAccountHolder)
                .HasMaxLength(128)
                .HasDefaultValueSql("('')")
                .HasComment("Chủ tài khoản");
            entity.Property(e => e.RecceiverBankAccountNumber)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasComment("Số tài khoản ngân hàng");
            entity.Property(e => e.RecceiverBankBrand)
                .HasMaxLength(250)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.RecceiverBankId)
                .HasComment("Ngân hàng")
                .HasColumnName("RecceiverBankID");
            entity.Property(e => e.RecceiverBankName)
                .HasMaxLength(255)
                .HasDefaultValueSql("('')")
                .HasComment("Nơi mở: ví dụ Ngân hàng VCB chi nhánh 01");
            entity.Property(e => e.SendAccountHolder)
                .HasMaxLength(128)
                .HasDefaultValueSql("('')")
                .HasComment("Chủ tài khoản");
            entity.Property(e => e.SendBankAccountNumber)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasComment("Số tài khoản ngân hàng");
            entity.Property(e => e.SendBankBrand)
                .HasMaxLength(250)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.SendBankId)
                .HasComment("Ngân hàng")
                .HasColumnName("SendBankID");
            entity.Property(e => e.SendBankName)
                .HasMaxLength(255)
                .HasDefaultValueSql("('')")
                .HasComment("Nơi mở: ví dụ Ngân hàng VCB chi nhánh 01");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.TransDate)
                .HasMaxLength(8)
                .HasComment("Ngày hạch toán");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.VoucherDate)
                .HasMaxLength(8)
                .HasDefaultValueSql("('')")
                .HasComment("Ngày chứng từ.");
            entity.Property(e => e.VouchersType)
                .HasMaxLength(20)
                .HasComment("Loại phiếu");
        });

        modelBuilder.Entity<VoucherDefine>(entity =>
        {
            entity.HasKey(e => e.VoucherTypeCategory);

            entity.ToTable("VoucherDefine");

            entity.Property(e => e.VoucherTypeCategory).HasMaxLength(10);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ItemId)
                .ValueGeneratedOnAdd()
                .HasColumnName("ItemID");
            entity.Property(e => e.LengthOfValue).HasDefaultValueSql("((5))");
            entity.Property(e => e.Prefix).HasMaxLength(10);
            entity.Property(e => e.RefTypeCategoryName).HasMaxLength(50);
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<VoucherDetail>(entity =>
        {
            entity.HasKey(e => new { e.VoucherDetailId, e.ZoneId, e.VouchersId, e.AutoBusinessId, e.DebitAccount, e.CreditAccount }).HasName("PK_VoucherDetails_1");

            entity.Property(e => e.VoucherDetailId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("VoucherDetailID");
            entity.Property(e => e.ZoneId)
                .HasMaxLength(2)
                .HasColumnName("ZoneID");
            entity.Property(e => e.VouchersId)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("VouchersID");
            entity.Property(e => e.AutoBusinessId)
                .HasMaxLength(50)
                .HasColumnName("AutoBusinessID");
            entity.Property(e => e.DebitAccount)
                .HasMaxLength(20)
                .HasComment("Tài khoản nợ");
            entity.Property(e => e.CreditAccount)
                .HasMaxLength(20)
                .HasComment("Tài khoản có");
            entity.Property(e => e.AccountObjectId)
                .HasMaxLength(50)
                .HasComment("Đối tượng")
                .HasColumnName("AccountObjectID");
            entity.Property(e => e.Amount)
                .HasComment("Số tiền quy đổi")
                .HasColumnType("decimal(22, 8)");
            entity.Property(e => e.AmountOc)
                .HasComment("Số tiền nguyên tệ")
                .HasColumnType("decimal(22, 8)")
                .HasColumnName("AmountOC");
            entity.Property(e => e.BankAccountId)
                .HasMaxLength(50)
                .HasComment("Tài khoản ngân hàng")
                .HasColumnName("BankAccountID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CustomField1).HasMaxLength(255);
            entity.Property(e => e.CustomField2).HasMaxLength(255);
            entity.Property(e => e.CustomField3).HasMaxLength(255);
            entity.Property(e => e.CustomField4).HasMaxLength(255);
            entity.Property(e => e.CustomField5).HasMaxLength(255);
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasComment("Diễn giải");
            entity.Property(e => e.ReceiverIdnumber)
                .HasMaxLength(50)
                .HasComment("Số CMT")
                .HasColumnName("ReceiverIDNumber");
            entity.Property(e => e.ReceiverName)
                .HasMaxLength(100)
                .HasComment("Tên người gửi, nhận");
            entity.Property(e => e.SortOrder).HasComment("Thứ tự sắp xếp");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.Time)
                .HasMaxLength(6)
                .HasDefaultValueSql("([dbo].[GetStringSysTime]())");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<VoucherMark20190601>(entity =>
        {
            entity.HasKey(e => new { e.Orders, e.VoucherDetailId, e.ZoneId, e.DebitAccount, e.CreditAccount }).HasName("PK_VoucherMark_20190601_1");

            entity.ToTable("VoucherMark_20190601");

            entity.Property(e => e.VoucherDetailId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("VoucherDetailID");
            entity.Property(e => e.ZoneId)
                .HasMaxLength(2)
                .HasColumnName("ZoneID");
            entity.Property(e => e.DebitAccount).HasMaxLength(20);
            entity.Property(e => e.CreditAccount).HasMaxLength(20);
            entity.Property(e => e.Amount).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.AmountOc)
                .HasColumnType("decimal(22, 8)")
                .HasColumnName("AmountOC");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.Time)
                .HasMaxLength(6)
                .HasDefaultValueSql("([dbo].[GetStringSysTime]())");
        });

        modelBuilder.Entity<VoucherTypeCategory>(entity =>
        {
            entity.HasKey(e => e.VoucherTypeCode);

            entity.ToTable("VoucherTypeCategory");

            entity.Property(e => e.VoucherTypeCode)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("Mã loại chứng từ");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreditAccount)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("Tài khoản có");
            entity.Property(e => e.CreditAvaiable)
                .HasMaxLength(4000)
                .HasDefaultValueSql("('')")
                .HasComment("Tài khoản có khả dụng, cách nhau bởi dấu phẩy.");
            entity.Property(e => e.DebitAccount)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("Tài khoản nợ");
            entity.Property(e => e.DebitAvaiable)
                .HasMaxLength(4000)
                .HasDefaultValueSql("('')")
                .HasComment("Tài khoản nợ khả dụng, đặt cách nhau bởi dấu phẩy");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasDefaultValueSql("('')")
                .HasComment("Diễn giải");
            entity.Property(e => e.IsSystem).HasComment("Là dữ liệu hệ thống thì không được xóa.");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.VoucherTypeId)
                .HasDefaultValueSql("(newid())")
                .HasComment("PK của bảng")
                .HasColumnName("VoucherTypeID");
            entity.Property(e => e.VoucherTypeName)
                .HasMaxLength(128)
                .HasDefaultValueSql("('')")
                .HasComment("Tên loại chứng từ");
        });

        modelBuilder.Entity<VouchersObjectRelate>(entity =>
        {
            entity.HasKey(e => new { e.VouchersObjectRelateId, e.ZoneId, e.VouchersId, e.AutoBusinessId, e.ObjectCategoryCode, e.CreditAccount, e.DebitAccount }).HasName("PK_VouchersObjectRelate_1");

            entity.ToTable("VouchersObjectRelate");

            entity.Property(e => e.VouchersObjectRelateId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("VouchersObjectRelateID");
            entity.Property(e => e.ZoneId)
                .HasMaxLength(2)
                .HasColumnName("ZoneID");
            entity.Property(e => e.VouchersId)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasComment("Mã phiếu")
                .HasColumnName("VouchersID");
            entity.Property(e => e.AutoBusinessId)
                .HasMaxLength(50)
                .HasComment("Mã lí do")
                .HasColumnName("AutoBusinessID");
            entity.Property(e => e.ObjectCategoryCode)
                .HasMaxLength(50)
                .HasDefaultValueSql("(newid())")
                .HasComment("Mã  loại đối tượng");
            entity.Property(e => e.CreditAccount)
                .HasMaxLength(20)
                .HasComment("Tài khoản có");
            entity.Property(e => e.DebitAccount)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("Tài khoản nợ");
            entity.Property(e => e.ObjectValueCredit)
                .HasMaxLength(50)
                .HasComment("Mã đối tượng ghi có");
            entity.Property(e => e.ObjectValueDebit)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasComment("Mã đối tượng ghi nợ");
            entity.Property(e => e.OrderColunm).HasDefaultValueSql("((1))");
            entity.Property(e => e.SortOrder).HasDefaultValueSql("((1))");
            entity.Property(e => e.Value)
                .HasComment("Giá trị của đối tượng được chọn, ví dụ đối tượng là Khách Hàng CustomerID thì giá trị là mã khách hàng")
                .HasColumnType("decimal(22, 8)");
            entity.Property(e => e.VoucherDetailId).HasColumnName("VoucherDetailID");
        });

        modelBuilder.Entity<VouchersObjectRelateMark20190601>(entity =>
        {
            entity.HasKey(e => new { e.Orders, e.VouchersObjectRelateId, e.ZoneId, e.ObjectCategoryCode, e.CreditAccount, e.DebitAccount }).HasName("PK_VouchersObjectRelateMark_20190601_1");

            entity.ToTable("VouchersObjectRelateMark_20190601");

            entity.Property(e => e.VouchersObjectRelateId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("VouchersObjectRelateID");
            entity.Property(e => e.ZoneId)
                .HasMaxLength(2)
                .HasColumnName("ZoneID");
            entity.Property(e => e.ObjectCategoryCode)
                .HasMaxLength(50)
                .HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreditAccount).HasMaxLength(20);
            entity.Property(e => e.DebitAccount)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.ObjectValueCredit).HasMaxLength(50);
            entity.Property(e => e.ObjectValueDebit)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Value).HasColumnType("decimal(22, 8)");
            entity.Property(e => e.VoucherDetailId).HasColumnName("VoucherDetailID");
        });

        modelBuilder.Entity<WarrantyInfor>(entity =>
        {
            entity.HasKey(e => new { e.WarrantyId, e.TransactionId, e.GoodId }).HasName("PK_WarrantyInfor_1");

            entity.ToTable("WarrantyInfor");

            entity.Property(e => e.WarrantyId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("WarrantyID");
            entity.Property(e => e.TransactionId)
                .HasMaxLength(20)
                .HasColumnName("TransactionID");
            entity.Property(e => e.GoodId)
                .HasMaxLength(9)
                .HasColumnName("GoodID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ItemId)
                .ValueGeneratedOnAdd()
                .HasColumnName("ItemID");
            entity.Property(e => e.SerialNumber)
                .HasMaxLength(100)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.TransDate).HasMaxLength(8);
            entity.Property(e => e.WarrantyEndDate).HasMaxLength(8);
        });

        modelBuilder.Entity<Zone>(entity =>
        {
            entity.Property(e => e.ZoneId)
                .HasMaxLength(2)
                .HasColumnName("ZoneID");
            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Note).HasMaxLength(200);
            entity.Property(e => e.ParentId)
                .HasMaxLength(2)
                .HasDefaultValueSql("((0))")
                .HasColumnName("ParentID");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ZoneName).HasMaxLength(100);
        });

        modelBuilder.Entity<ZzHrmcheckInOut>(entity =>
        {
            entity.HasKey(e => new { e.UserEnrollNumber, e.TimeStr }).HasName("PK_HRMCheckInOut");

            entity.ToTable("zzHRMCheckInOut");

            entity.Property(e => e.UserEnrollNumber).HasComment("Số chấm công");
            entity.Property(e => e.TimeStr)
                .HasComment("Ngày giờ chấm công")
                .HasColumnType("datetime");
            entity.Property(e => e.MachineNo).HasComment("Số máy chấm công");
            entity.Property(e => e.NewType)
                .HasMaxLength(5)
                .HasComment("Chuyển đổi từ loại I, O sang.");
            entity.Property(e => e.OriginType)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')")
                .HasComment("Loại lần chấm công, I là vào O là ra");
            entity.Property(e => e.Source)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'FP')")
                .HasComment("Nguồn dữ liệu, FP là từ máy chấm công, MN là chấm công bằng tay.");
            entity.Property(e => e.TimeDate)
                .HasComment("Ngày giờ")
                .HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<ZzHrmcriteriaList>(entity =>
        {
            entity.HasKey(e => new { e.Orders, e.CriteriaId }).HasName("PK_HRMCriteriaList");

            entity.ToTable("zzHRMCriteriaList");

            entity.Property(e => e.Orders)
                .ValueGeneratedOnAdd()
                .HasColumnName("orders");
            entity.Property(e => e.CriteriaId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("CriteriaID");
            entity.Property(e => e.CriteriaCode)
                .HasMaxLength(20)
                .HasComment("Mã tiêu chí");
            entity.Property(e => e.CriteriaName)
                .HasMaxLength(500)
                .HasComment("Tên tiêu chí");
            entity.Property(e => e.CriteriaType)
                .HasMaxLength(2)
                .HasDefaultValueSql("(N'TC')")
                .IsFixedLength()
                .HasComment("Nếu là tiêu chí thông thường thì TC, nếu là tiêu chí doanh số thì DS, với tiêu chí doanh số thì sẽ chỉ có một lựa chọn khi sử dụng.");
            entity.Property(e => e.PercentComplete)
                .HasDefaultValueSql("((0))")
                .HasComment("Tỉ lệ hoàn thành tiêu chí")
                .HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.Value).HasColumnType("decimal(18, 6)");
        });

        modelBuilder.Entity<ZzHrmdepartment>(entity =>
        {
            entity.HasKey(e => e.DepartmentId).HasName("PK_Departments");

            entity.ToTable("zzHRMDepartments");

            entity.Property(e => e.DepartmentId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("DepartmentID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DepartmentCode).HasMaxLength(50);
            entity.Property(e => e.DepartmentName).HasMaxLength(200);
            entity.Property(e => e.OtherSalary)
                .HasDefaultValueSql("((0))")
                .HasComment("Phụ cấp khác")
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.OtherSupport)
                .HasDefaultValueSql("((0))")
                .HasComment("Định mức Phụ cấp mất hàng tính theo tỉ lệ")
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PayrollFormula).HasMaxLength(4000);
            entity.Property(e => e.SalaryOnsale)
                .HasDefaultValueSql("((0))")
                .HasComment("Lương định mức tính doanh số")
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.SalaryRateEndWeek)
                .HasDefaultValueSql("((1))")
                .HasComment("tỉ lệ lương tăng khi đi làm cuối tuần")
                .HasColumnType("decimal(3, 2)");
            entity.Property(e => e.SalaryRateHoliday)
                .HasDefaultValueSql("((1))")
                .HasComment("tỉ lệ lương tăng khi đi làm ngày lễ")
                .HasColumnType("decimal(3, 2)");
            entity.Property(e => e.ScheduleId).HasColumnName("ScheduleID");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .HasDefaultValueSql("((0))")
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.WorkOffPerMonth)
                .HasDefaultValueSql("((4))")
                .HasComment("Số ngày nghỉ trên từng tháng");
            entity.Property(e => e.ZoneId)
                .HasMaxLength(2)
                .HasDefaultValueSql("('00')")
                .HasColumnName("ZoneID");
        });

        modelBuilder.Entity<ZzHrmholiday>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_HRMHoliday");

            entity.ToTable("zzHRMHoliday");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Hdate)
                .HasMaxLength(50)
                .HasColumnName("HDate");
            entity.Property(e => e.Holiday).HasMaxLength(50);
            entity.Property(e => e.Type)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'Yearly')")
                .HasComment("YearLy hàng năm, Monthly hàng tháng, Weekly hàng tuần, Once: một lần");
        });

        modelBuilder.Entity<ZzHrmschedule>(entity =>
        {
            entity.HasKey(e => e.ScheduleId).HasName("PK_HRMSchedule");

            entity.ToTable("zzHRMSchedule");

            entity.Property(e => e.ScheduleId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("ScheduleID");
            entity.Property(e => e.CycleMode)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'Monthly')")
                .IsFixedLength()
                .HasComment("chọn kiểu lịch chấm công, weekly: theo tuần, monthly: theo tháng, yearly: theo năm");
            entity.Property(e => e.IsAbsentHol)
                .HasDefaultValueSql("((0))")
                .HasComment("Không tính vắng khi có xếp ca vào ngày lễ mà không đi làm 0 không xét vắng, 1 có xét vắng");
            entity.Property(e => e.SchCode)
                .HasMaxLength(50)
                .HasComment("mã lịch");
            entity.Property(e => e.Schname)
                .HasMaxLength(50)
                .HasComment("Tên lịch");
        });

        modelBuilder.Entity<ZzHrmshift>(entity =>
        {
            entity.HasKey(e => e.ShiftId).HasName("PK_HRMShifts");

            entity.ToTable("zzHRMShifts");

            entity.Property(e => e.ShiftId).HasColumnName("ShiftID");
            entity.Property(e => e.CutIn).HasComment("Số phút trước giờ ra bắt đầu tính checkOut");
            entity.Property(e => e.CutOut).HasComment("Số phút sau giờ ra bắt đầu tính checkOut");
            entity.Property(e => e.DayCount)
                .HasDefaultValueSql("((1))")
                .HasComment("Đếm công theo số ngày");
            entity.Property(e => e.EndNt)
                .HasMaxLength(5)
                .HasComment("Ca qua đêm tách giờ đêm đến giờ này.")
                .HasColumnName("EndNT");
            entity.Property(e => e.IsNightTime)
                .HasDefaultValueSql("((0))")
                .HasComment("Là ca qua đêm 0 là không phải 1 là có.");
            entity.Property(e => e.OffLunch)
                .HasMaxLength(5)
                .HasComment("Giờ kết thúc ăn trưa nếu có");
            entity.Property(e => e.Offduty)
                .HasMaxLength(10)
                .HasComment("Giờ kết thúc làm việc");
            entity.Property(e => e.OnLunch)
                .HasMaxLength(5)
                .HasComment("Giờ ra ăn trưa nếu có");
            entity.Property(e => e.OnTimeIn).HasComment("Số phút trước giờ vào bắt đầu tính checkin");
            entity.Property(e => e.OnTimeOut).HasComment("Số phút sau giờ vào bắt đầu tính checkin");
            entity.Property(e => e.Onduty)
                .HasMaxLength(10)
                .HasComment("Giờ vào làm việc");
            entity.Property(e => e.ShiftCode)
                .HasMaxLength(20)
                .HasComment("Mã kí hiệu ca");
            entity.Property(e => e.StartNt)
                .HasMaxLength(5)
                .HasComment("Ca qua đêm tách giờ đêm từ giờ này.")
                .HasColumnName("StartNT");
            entity.Property(e => e.WorkingTime).HasComment("Tổng thời gian làm việc được tính");
            entity.Property(e => e.Workingday)
                .HasDefaultValueSql("((1))")
                .HasComment("đếm số công");
        });

        modelBuilder.Entity<ZzHrmstaffCriteriaInfor>(entity =>
        {
            entity.HasKey(e => new { e.CustomerId, e.CriteriaId }).HasName("PK_HRMStaffCriteriaInfor");

            entity.ToTable("zzHRMStaffCriteriaInfor");

            entity.Property(e => e.CustomerId)
                .HasMaxLength(10)
                .HasColumnName("CustomerID");
            entity.Property(e => e.CriteriaId).HasColumnName("CriteriaID");
            entity.Property(e => e.CriteriaCode)
                .HasMaxLength(20)
                .HasComment("Mã tiêu chí");
            entity.Property(e => e.CriteriaType)
                .HasMaxLength(2)
                .HasDefaultValueSql("(N'TC')")
                .IsFixedLength()
                .HasComment("Nếu là tiêu chí thông thường thì TC, nếu là tiêu chí doanh số thì DS, với tiêu chí doanh số thì sẽ chỉ có một lựa chọn khi sử dụng.");
            entity.Property(e => e.PercentComplete)
                .HasDefaultValueSql("((0))")
                .HasComment("Tỉ lệ hoàn thành tiêu chí")
                .HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.Value).HasColumnType("decimal(18, 6)");
        });

        modelBuilder.Entity<ZzHrmstaffInfor>(entity =>
        {
            entity.HasKey(e => e.CustomerId).HasName("PK_HRMStaffInfor");

            entity.ToTable("zzHRMStaffInfor");

            entity.Property(e => e.CustomerId)
                .HasMaxLength(10)
                .HasColumnName("CustomerID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.Description)
                .HasMaxLength(1000)
                .HasComment("Mô tả vụ việc");
            entity.Property(e => e.Domicile)
                .HasMaxLength(200)
                .HasDefaultValueSql("('')")
                .HasComment("Quê quán");
            entity.Property(e => e.Gender)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasComment("Giới tính, 0 Nữ, 1 Nam,2 Không xác định");
            entity.Property(e => e.Nationality)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'Việt Nam')")
                .HasComment("Quốc tịch");
            entity.Property(e => e.PayrollFormula)
                .HasMaxLength(4000)
                .HasComment("Công thức tính lương");
            entity.Property(e => e.Salary)
                .HasComment("Lương theo hợp đồng với công ty theo tháng.")
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.SalaryByCriteria)
                .HasDefaultValueSql("((0))")
                .HasComment("Lương ăn theo tiêu chí, nếu 1 thỉ ăn theo tiêu chí ở bảng StaffSalaryByCriteria,0 thì không theo tiêu chí");
            entity.Property(e => e.SalaryByInsRate)
                .HasDefaultValueSql("((0))")
                .HasComment("tỉ lệ cùng đóng tiền bảo hiểm với công ty.")
                .HasColumnType("decimal(3, 2)");
            entity.Property(e => e.SalaryByInsurance)
                .HasComment("Lương theo bảo hiểm, nếu =0 thì không có bảo hiểm")
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.SalaryBySale)
                .HasDefaultValueSql("((0))")
                .HasComment("Lương theo doanh số,mặc định là không 0, 1 thì ăn theo doanh số quy định tại bảng StaffSalaryBySale");
            entity.Property(e => e.SalaryDeductions)
                .HasDefaultValueSql("((1))")
                .HasComment("Các khoản giảm trừ lương");
            entity.Property(e => e.SalaryRateEndWeek)
                .HasDefaultValueSql("((1))")
                .HasComment("tỉ lệ lương tăng khi đi làm cuối tuần")
                .HasColumnType("decimal(3, 2)");
            entity.Property(e => e.SalaryRateHoliday)
                .HasDefaultValueSql("((1))")
                .HasComment("tỉ lệ lương tăng khi đi làm ngày lễ")
                .HasColumnType("decimal(3, 2)");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SynStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.SyncTime)
                .HasMaxLength(14)
                .HasDefaultValueSql("([dbo].[GetStringSyncTime]())");
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .HasComment("Chức vụ");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.WorkOffPerMonth)
                .HasDefaultValueSql("((4))")
                .HasComment("Số ngày nghỉ trên từng tháng");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
