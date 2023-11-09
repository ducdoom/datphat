﻿using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

/// <summary>
/// Bảng lưu chi nhánh/phòng ban
/// </summary>
public partial class OrganizationUnit
{
    /// <summary>
    /// PK
    /// </summary>
    public Guid OrganizationUnitId { get; set; }

    /// <summary>
    /// Chi nhánh
    /// </summary>
    public Guid? BranchId { get; set; }

    /// <summary>
    /// Mã đơn vị
    /// </summary>
    public string OrganizationUnitCode { get; set; } = null!;

    /// <summary>
    /// Tên đơn vị
    /// </summary>
    public string OrganizationUnitName { get; set; } = null!;

    /// <summary>
    /// Thuộc hệ thống
    /// </summary>
    public bool IsSystem { get; set; }

    public string? MisacodeId { get; set; }

    public int? Grade { get; set; }

    /// <summary>
    /// ID đơn vị cha
    /// </summary>
    public Guid? ParentId { get; set; }

    /// <summary>
    /// Là đơn vị cha
    /// </summary>
    public bool IsParent { get; set; }

    /// <summary>
    /// Địa chỉ
    /// </summary>
    public string? Address { get; set; }

    /// <summary>
    /// Cấp tổ chức: 1 - Tổng công ty; 2 - Chi nhánh; 3 - VP/TT; 4 - Phòng ban; 5- Phân xưởng; 6 - Nhóm/Tổ,hội
    /// </summary>
    public int OrganizationUnitTypeId { get; set; }

    /// <summary>
    /// Số đăng ký kinh doanh
    /// </summary>
    public string? BusinessRegistrationNumber { get; set; }

    /// <summary>
    /// Ngày cấp
    /// </summary>
    public DateTime? BusinessRegistrationNumberIssuedDate { get; set; }

    /// <summary>
    /// Nơi cấp
    /// </summary>
    public string? BusinessRegistrationNumberIssuedPlace { get; set; }

    /// <summary>
    /// 0 = Hạch toán độc lập; 1 = Hạch toán  phụ thuộc
    /// </summary>
    public bool? IsDependent { get; set; }

    /// <summary>
    /// Kê khai thuế giá trị gia tăng riêng
    /// </summary>
    public bool IsPrivateVatdeclaration { get; set; }

    /// <summary>
    /// Tài khoản chi phí lương
    /// </summary>
    public string? CostAccount { get; set; }

    /// <summary>
    /// Ngừng theo dõi
    /// </summary>
    public bool Inactive { get; set; }

    /// <summary>
    /// Mã số thuế
    /// </summary>
    public string? CompanyTaxCode { get; set; }

    /// <summary>
    /// Số điện thoại
    /// </summary>
    public string? CompanyTel { get; set; }

    /// <summary>
    /// Fax
    /// </summary>
    public string? CompanyFax { get; set; }

    /// <summary>
    /// Email
    /// </summary>
    public string? CompanyEmail { get; set; }

    /// <summary>
    /// Website
    /// </summary>
    public string? CompanyWebsite { get; set; }

    /// <summary>
    /// Tài khoản ngân hàng
    /// </summary>
    public Guid? CompanyBankAccountId { get; set; }

    /// <summary>
    /// Tên đơn vị chủ quản
    /// </summary>
    public string? CompanyOwnerName { get; set; }

    /// <summary>
    /// Mã số thuế đơn vị chủ quản
    /// </summary>
    public string? CompanyOwnerTaxCode { get; set; }

    /// <summary>
    /// Tiêu đề người ký là giám đốc
    /// </summary>
    public string? DirectorTitle { get; set; }

    /// <summary>
    /// Tên giám đốc
    /// </summary>
    public string? DirectorName { get; set; }

    /// <summary>
    /// Tiêu đề người ký là Kế toán trưởng
    /// </summary>
    public string? ChiefOfAccountingTitle { get; set; }

    /// <summary>
    /// Tên Kế toán trưởng
    /// </summary>
    public string? ChiefOfAccountingName { get; set; }

    /// <summary>
    /// Tiêu đề người ký là Thủ kho
    /// </summary>
    public string? StoreKeeperTitle { get; set; }

    /// <summary>
    /// Tên thủ kho
    /// </summary>
    public string? StoreKeeperName { get; set; }

    /// <summary>
    /// Tiêu đề người ký là Thủ quỹ
    /// </summary>
    public string? CashierTitle { get; set; }

    /// <summary>
    /// Tên Thủ quỹ
    /// </summary>
    public string? CashierName { get; set; }

    /// <summary>
    /// Tiêu đề người ký là Người lập biểu
    /// </summary>
    public string? ReporterTitle { get; set; }

    /// <summary>
    /// Tên Người lập biểu
    /// </summary>
    public string? ReporterName { get; set; }

    /// <summary>
    /// In tên người ký lên chứng từ, báo cáo
    /// </summary>
    public bool IsPrintSigner { get; set; }

    /// <summary>
    /// Lấy tên người lập biểu theo tên người đăng nhập
    /// </summary>
    public bool IsGetReporterNameByUserLogIn { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    /// <summary>
    /// Cột dùng để sort trên báo cáo. Không sử dụng trên giao diện.
    /// </summary>
    public string? SortMisacodeId { get; set; }

    public string? CompanyDistrict { get; set; }

    public string? CompanyCity { get; set; }
}
