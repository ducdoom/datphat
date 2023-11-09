﻿using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class HrSalarySheet
{
    public string SalarySheetId { get; set; } = null!;

    public string? TransCode { get; set; }

    public string? ZoneId { get; set; }

    /// <summary>
    /// Ngày hạch toán
    /// </summary>
    public string SalaryMonth { get; set; } = null!;

    public string DepartmentId { get; set; } = null!;

    /// <summary>
    /// Mã ID chi phí
    /// </summary>
    public Guid? FeeId { get; set; }

    public string? TransDate { get; set; }

    public string? Description { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public string? Status { get; set; }

    public string? SynStatus { get; set; }

    public string? SyncTime { get; set; }

    /// <summary>
    /// Key Mã phương thức nhập xuất
    /// </summary>
    public Guid? ImpExpMethodId { get; set; }

    /// <summary>
    /// Mã phương thức Nhập xuất
    /// </summary>
    public string? ImpExpMethodCode { get; set; }

    /// <summary>
    /// Tên phương thức nhập xuất.
    /// </summary>
    public string? ImpExpMethodName { get; set; }
}
