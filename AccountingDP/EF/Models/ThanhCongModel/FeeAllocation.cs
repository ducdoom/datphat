﻿using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class FeeAllocation
{
    public string ZoneId { get; set; } = null!;

    /// <summary>
    /// Mã ID chi phí
    /// </summary>
    public Guid FeeAllocationId { get; set; }

    public string? FeeAllocationSign { get; set; }

    public string? FeeAllocationName { get; set; }

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
