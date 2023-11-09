﻿using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class FixedAsset
{
    public string ZoneId { get; set; } = null!;

    /// <summary>
    /// Mã ID Tài sản
    /// </summary>
    public Guid FixedAssetId { get; set; }

    /// <summary>
    /// Mã ID Tài sản
    /// </summary>
    public Guid FixedAssetGroupId { get; set; }

    public string? FixedAssetSign { get; set; }

    public string? FixedAssetName { get; set; }

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
