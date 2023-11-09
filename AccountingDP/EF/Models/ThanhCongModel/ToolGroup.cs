﻿using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class ToolGroup
{
    /// <summary>
    /// Mã ID chi phí
    /// </summary>
    public Guid ToolGroupId { get; set; }

    public string ZoneId { get; set; } = null!;

    /// <summary>
    /// Mã ID Chi Phí Cha
    /// </summary>
    public Guid? ParentToolGroupId { get; set; }

    /// <summary>
    /// Kí Hiệu viết tắt mã chi phí
    /// </summary>
    public string? ToolGroupSign { get; set; }

    /// <summary>
    /// Tên chi phí
    /// </summary>
    public string? ToolGroupName { get; set; }

    /// <summary>
    /// Mô tả chi phí
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
