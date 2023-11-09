﻿using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class ImpExpMethod
{
    /// <summary>
    /// Key Mã phương thức nhập xuất
    /// </summary>
    public Guid ImpExpMethodId { get; set; }

    /// <summary>
    /// Mã phương thức Nhập xuất
    /// </summary>
    public string? ImpExpMethodCode { get; set; }

    /// <summary>
    /// Tên phương thức nhập xuất.
    /// </summary>
    public string? ImpExpMethodName { get; set; }

    /// <summary>
    /// Mã nhóm phương thức nhập xuất.
    /// </summary>
    public string? ImpExpMethodGroupId { get; set; }

    /// <summary>
    /// Loại phương thức nhập xuất.
    /// </summary>
    public string? ImpExpMethodType { get; set; }

    /// <summary>
    /// Thứ tự trên sổ.
    /// </summary>
    public int? OrderOnBook { get; set; }

    /// <summary>
    /// Công thức tính giá vốn
    /// </summary>
    public string? CostFormula { get; set; }

    /// <summary>
    /// Công thức tính doanh thu
    /// </summary>
    public string? RevenueFormula { get; set; }

    /// <summary>
    /// Loại phương thức, mặc định là 0- phương thức nhập xuất, 1- phương thức kết chuyển
    /// </summary>
    public int? Type { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public string? Status { get; set; }

    public string? SynStatus { get; set; }

    public string? SyncTime { get; set; }
}
