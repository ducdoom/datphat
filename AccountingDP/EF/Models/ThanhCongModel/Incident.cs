﻿using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class Incident
{
    public string ZoneId { get; set; } = null!;

    /// <summary>
    /// Mã ID vụ việc
    /// </summary>
    public Guid IncidentId { get; set; }

    /// <summary>
    /// Mã ID chi phí
    /// </summary>
    public Guid? IncidentGroupId { get; set; }

    public string IncidentSign { get; set; } = null!;

    public string? IncidentName { get; set; }

    /// <summary>
    /// Mô tả vụ việc
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
