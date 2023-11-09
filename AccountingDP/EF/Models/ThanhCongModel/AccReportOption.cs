﻿using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class AccReportOption
{
    public string UserId { get; set; } = null!;

    public string FormId { get; set; } = null!;

    /// <summary>
    /// ID chi nhánh
    /// </summary>
    public string ZoneId { get; set; } = null!;

    /// <summary>
    /// Là tùy chọn mặc định. Khi thêm mới Tùy chọn theo chi nhánh, theo User thì copy từ Tùy chọn này
    /// </summary>
    public bool IsDefault { get; set; }

    public string? ObjectCategoryName { get; set; }

    public string ObjectCategoryCode { get; set; } = null!;

    public string? ObjectValue { get; set; }

    /// <summary>
    /// Nhóm theo điều kiện lọc
    /// </summary>
    public bool IsGroupBy { get; set; }

    /// <summary>
    /// Nhóm theo điều kiện lọc
    /// </summary>
    public bool IsReportBy { get; set; }

    public int? Sort { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public string? Status { get; set; }

    public string? SyncTime { get; set; }
}
