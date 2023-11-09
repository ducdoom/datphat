﻿using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class AccSysOption
{
    /// <summary>
    /// PK - ID của tùy chọn
    /// </summary>
    public Guid UserOptionId { get; set; }

    /// <summary>
    /// ID của người dùng
    /// </summary>
    public string? UserId { get; set; }

    /// <summary>
    /// ID chi nhánh
    /// </summary>
    public string? ZoneId { get; set; }

    /// <summary>
    /// Mã của tùy chọn
    /// </summary>
    public string OptionName { get; set; } = null!;

    /// <summary>
    /// Giá trị của tùy chọn đó
    /// </summary>
    public string? OptionValue { get; set; }

    /// <summary>
    /// Kiểu giá trị (Thiết lập theo EnumDataType trên chương trình)
    /// </summary>
    public int ValueType { get; set; }

    /// <summary>
    /// Là tùy chọn mặc định. Khi thêm mới Tùy chọn theo chi nhánh, theo User thì copy từ Tùy chọn này
    /// </summary>
    public bool IsDefault { get; set; }

    /// <summary>
    /// Diễn giải: option này để làm gì, có value range nào.
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Khóa
    /// </summary>
    public bool Lock { get; set; }

    /// <summary>
    /// Là tùy chọn chung toàn hệ thống
    /// </summary>
    public bool IsGlobalOption { get; set; }

    /// <summary>
    /// Là tùy chọn theo Người dùng
    /// </summary>
    public bool? IsUserOption { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public string? Status { get; set; }

    public string? SynStatus { get; set; }

    public string SyncTime { get; set; } = null!;
}
