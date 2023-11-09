﻿using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

/// <summary>
/// Danh mục tài khoản
/// </summary>
public partial class Account
{
    public string ZoneId { get; set; } = null!;

    /// <summary>
    /// PK Tài khoản
    /// </summary>
    public string AccountId { get; set; } = null!;

    /// <summary>
    /// Số hiệu tài khoản
    /// </summary>
    public string AccountNumber { get; set; } = null!;

    /// <summary>
    /// Tên tài khoản
    /// </summary>
    public string AccountName { get; set; } = null!;

    /// <summary>
    /// Tên tài khoản bằng tiếng anh
    /// </summary>
    public string? AccountNameEnglish { get; set; }

    /// <summary>
    /// Diễn giải
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// TK Tổng hợp
    /// </summary>
    public string? ParentId { get; set; }

    public string? PmscodeId { get; set; }

    /// <summary>
    /// Cấp bậc
    /// </summary>
    public int? Grade { get; set; }

    /// <summary>
    /// Là TK tổng hợp
    /// </summary>
    public bool IsParent { get; set; }

    /// <summary>
    /// Tính chất tài khoản: 0: Dư nợ; 1: Dư có; 2: Lưỡng tính
    /// </summary>
    public int AccountCategoryKind { get; set; }

    /// <summary>
    /// Có hạch toán ngoại tệ
    /// </summary>
    public bool IsPostableInForeignCurrency { get; set; }

    /// <summary>
    /// Chi tiết theo đối tượng
    /// </summary>
    public bool DetailByAccountObject { get; set; }

    /// <summary>
    /// Loại đối tượng: 0 - Nhà cung cấp, 1- Khách hàng, 2- Nhân viên
    /// </summary>
    public int? AccountObjectType { get; set; }

    /// <summary>
    /// Chi tiết theo tài khoản ngân hàng
    /// </summary>
    public bool DetailByBankAccount { get; set; }

    /// <summary>
    /// Chi tiết theo đối tượng tập hợp chi phí
    /// </summary>
    public bool DetailByJob { get; set; }

    /// <summary>
    /// 0 = Chỉ cảnh báo; 1 = Bắt buộc nhập
    /// </summary>
    public int? DetailByJobKind { get; set; }

    /// <summary>
    /// Chi tiết theo công trình vụ việc
    /// </summary>
    public bool DetailByProjectWork { get; set; }

    /// <summary>
    /// 0 = Chỉ cảnh báo; 1 = Bắt buộc nhập
    /// </summary>
    public int? DetailByProjectWorkKind { get; set; }

    /// <summary>
    /// Chi tiết theo đơn hàng
    /// </summary>
    public bool DetailByOrder { get; set; }

    /// <summary>
    /// 0 = Chỉ cảnh báo; 1 = Bắt buộc nhập
    /// </summary>
    public int? DetailByOrderKind { get; set; }

    /// <summary>
    /// Chi tiết theo hợp đồng
    /// </summary>
    public bool DetailByContract { get; set; }

    /// <summary>
    /// 0 = Chỉ cảnh báo; 1 = Bắt buộc nhập
    /// </summary>
    public int? DetailByContractKind { get; set; }

    /// <summary>
    /// Chi tiết theo Khoản mục CP
    /// </summary>
    public bool DetailByExpenseItem { get; set; }

    /// <summary>
    /// 0 = Chỉ cảnh báo; 1 = Bắt buộc nhập
    /// </summary>
    public int? DetailByExpenseItemKind { get; set; }

    /// <summary>
    /// Chi tiết theo đơn vị
    /// </summary>
    public bool DetailByDepartment { get; set; }

    /// <summary>
    /// 0 = Chỉ cảnh báo; 1 = Bắt buộc nhập
    /// </summary>
    public int? DetailByDepartmentKind { get; set; }

    /// <summary>
    /// Chi tiết theo mã thống kê
    /// </summary>
    public bool DetailByListItem { get; set; }

    /// <summary>
    /// 0 = Chỉ cảnh báo; 1 = Bắt buộc nhập
    /// </summary>
    public int? DetailByListItemKind { get; set; }

    /// <summary>
    /// Ngừng theo dõi
    /// </summary>
    public bool Inactive { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    /// <summary>
    /// Cột dùng để sort trên báo cáo. Không sử dụng trên giao diện.
    /// </summary>
    public string? SortCodeId { get; set; }

    public bool DetailByPucontract { get; set; }

    public int? DetailByPucontractKind { get; set; }

    public string? SyncTime { get; set; }
}
