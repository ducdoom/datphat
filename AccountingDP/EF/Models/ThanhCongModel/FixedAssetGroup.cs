﻿using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class FixedAssetGroup
{
    /// <summary>
    /// Mã ID Tài sản
    /// </summary>
    public Guid FixedAssetGroupId { get; set; }

    public string ZoneId { get; set; } = null!;

    /// <summary>
    /// Mã ID Tài sản Cha
    /// </summary>
    public Guid? ParentFixedAssetGroupId { get; set; }

    /// <summary>
    /// Kí Hiệu viết tắt mã Tài sản
    /// </summary>
    public string? FixedAssetGroupSign { get; set; }

    /// <summary>
    /// Tên Tài sản
    /// </summary>
    public string? FixedAssetGroupName { get; set; }

    /// <summary>
    /// Mô tả Tài sản
    /// </summary>
    public string? Description { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public string? Status { get; set; }

    public string? SynStatus { get; set; }

    public string? SyncTime { get; set; }
}
