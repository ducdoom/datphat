﻿using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class Tool
{
    public string ZoneId { get; set; } = null!;

    /// <summary>
    /// Mã ID Công cụ
    /// </summary>
    public Guid ToolId { get; set; }

    /// <summary>
    /// Mã ID Công cụ
    /// </summary>
    public Guid ToolGroupId { get; set; }

    public string? ToolSign { get; set; }

    public string? ToolName { get; set; }

    /// <summary>
    /// Mô tả Công cụ
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
