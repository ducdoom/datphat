﻿using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class ImpExpAccountAlias
{
    /// <summary>
    /// Định Danh khoản mục hạch toán
    /// </summary>
    public Guid AccountItemAliasId { get; set; }

    /// <summary>
    /// Tên khoản mục hạch toán
    /// </summary>
    public string? AccountItemName { get; set; }

    /// <summary>
    /// Định Danh khoản mục hạch toán
    /// </summary>
    public string AccountItemAlias { get; set; } = null!;

    /// <summary>
    /// Tên Cột trong bảng
    /// </summary>
    public string? ColumnName { get; set; }

    /// <summary>
    /// Bảng dữ liệu
    /// </summary>
    public string? TableName { get; set; }

    /// <summary>
    /// Tên Cột trong bảng
    /// </summary>
    public string? ColumnCode { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public string? Status { get; set; }

    public string? SynStatus { get; set; }

    public string? SyncTime { get; set; }
}
